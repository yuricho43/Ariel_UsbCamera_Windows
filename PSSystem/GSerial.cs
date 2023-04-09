using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace PSSystem
{

    public static class GSerial
    {
        public static System.IO.Ports.SerialPort serialPort1 = new SerialPort();
        public static ComboBox gCombPort;
        public static byte[] gByteRemained = new byte[256];
        public static int gByteRemainedLength = 0;
        public static object gLockObject = new object();   // Semaphore
        public static byte[] gIndexes = new byte[5] { 0xb1, 0xb2, 0xb3, 0xb4, 0xc1 };
        public static void SetupSerialPort(ComboBox cbPort)
        {
            gCombPort = cbPort;

            //--- listup Port name
            string[] PortNames = SerialPort.GetPortNames();
            cbPort.Items.Clear();

            foreach (string portnum in PortNames)
            {
                cbPort.Items.Add(portnum);
            }
            if (PortNames.Count() >= 1)
                cbPort.SelectedIndex = 0;
        }

        public static void Connect(Button btnConnect)
        {
            //--- Disconnect --> Connect
            if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = gCombPort.SelectedItem.ToString();
                serialPort1.BaudRate = 9600;    //  int.Parse(comb_Baud.SelectedItem.ToString());
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Maybe usb cable is not connected. Retry after connecting cable!");
                    return;
                }
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                if (serialPort1.IsOpen)
                {
                    btnConnect.BackColor = Color.Lime;
                    btnConnect.Text = "연결끊기";
                }
                else
                {
                    btnConnect.BackColor = Color.Red;
                    btnConnect.Text = "연결하기";
                }
            }
            else   // Connect --> Disconnect
            {
                Disconnect(btnConnect);         
            }
        }

        public static void Disconnect(Button btnConnect)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                if (serialPort1.IsOpen)
                {
                    btnConnect.BackColor = Color.Lime;
                    btnConnect.Text = "연결끊기";
                }
                else
                {
                    btnConnect.BackColor = Color.Red;
                    btnConnect.Text = "연결하기";
                }
            }
        }

        private static byte GetCheckSum(byte[] data, int offset, int count)
        {
            byte bReturn = 0x00;
            for (int i = 0; i < count; i++)
            {
                bReturn ^= data[offset + i];
            }

            return bReturn;
        }

        public static void Send_Serial_Data_Binary(byte[] data, int size)
        {
            if (!serialPort1.IsOpen)
            {
                Button bTemp = new Button();
                Disconnect(bTemp);
                return;
            }

            serialPort1.Write(data, 0, size);
        }

        //--- bIndex = a1~a4, c0 (보드에 데이타 요청)
        public static void Send_Equiry_Data(byte bIndex)
        {
            //--- send data : STX index    header data checksum ETX    // 6 byte
            //                02  a1~a4/c0 0x01,  0x00  xor     03
            //                STX c1  0x01 data1 data2 data3 checksum ETX           // 8 bytes


            byte[] bSendData = new byte[16];
            bSendData[0] = 0x02;
            bSendData[1] = bIndex;
            bSendData[2] = 0x01;    // header
            bSendData[3] = 0x00;    // Data
            bSendData[4] = GetCheckSum(bSendData, 1, 3);
            bSendData[5] = 0x03;
            Send_Serial_Data_Binary(bSendData, 6);
        }


        public static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.BytesToRead <= 0)
                return;

            byte[] data = new byte[256];
            lock (gLockObject)
            {
                int n = serialPort1.Read(data, 0, serialPort1.BytesToRead);
                Process_Received_Data(data, n);
            }
        }

        //--- Received Sensor or Relay Data
        /*      STX     Index   온도     센서    사운드  자이로 CS    ETX       (39 bytes)
            1번	0x02	0xb1	16byte	16byte	2byte	1byte Ex-Or	0x03
            2번	0x02	0xb2	16byte	16byte	2byte	1byte Ex-Or	0x03
            3번	0x02	0xb3	16byte	16byte	2byte	1byte Ex-Or	0x03
            4번	0x02	0xb4	16byte	16byte	2byte	1byte Ex-Or	0x03

        	    STX	    index	Header	Data1	Data1	Data1	CS	    ETX   (8bytes)
          릴레이	0x02	0xc1	0x01	1byte	1byte	1byte	Ex-Or	0x03
        */
        public static void Process_Received_Data(byte[] data, int iLength)
        {
            Array.Copy(data, 0, gByteRemained, gByteRemainedLength, iLength);
            gByteRemainedLength += iLength;

            //--- find Response STX ~ ETX : 39 or 6 bytes;
            byte stx = (byte)2;
            //byte etx = (byte)3;
            byte bIndex = (byte)0;
            int len = 0;
            byte[] dataSensor = new byte[48];

            while (gByteRemainedLength >= 8)
            {
                int sindex = -1;
                //--- find stx, index;
                for (int i = 0; i < (gByteRemainedLength-2); i++)
                    if (gByteRemained[i] == stx && gIndexes.Contains(gByteRemained[i + 1]))
                    {
                        sindex = i;
                        break;
                    }

                if (sindex < 0)
                {  // not found
                    Buffer.BlockCopy(gByteRemained, gByteRemainedLength - 2, gByteRemained, 0, 2);
                    gByteRemainedLength = 2;
                    return;
                }

                bIndex = gByteRemained[sindex + 1];
                if (bIndex == (byte) 0xc1)
                {
                    if (gByteRemainedLength < (sindex+8))
                    {
                        return;
                    }
                    len = 8;  
                    // check if remained >=39
                } else
                {
                    if (gByteRemainedLength < (sindex + 39))
                    {
                        return;
                    }
                    len = 39;
                }

                Buffer.BlockCopy(gByteRemained, sindex, dataSensor, 0, len);
                Buffer.BlockCopy(gByteRemained, sindex + len, gByteRemained, 0, gByteRemainedLength - sindex - len);
                gByteRemainedLength -= (sindex + len);

                Globals.gMainForm.Process_Received__Data(dataSensor, len);
            }

        }
    }
}