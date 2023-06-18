using System;
using System.Threading;

namespace PSSystem
{

    public sealed class NeoQueue
    {
        UInt32 State_Stopped = 0;
        UInt32 State_Run = 0;

        UInt32 m_dwSize;
        UInt32 m_dwHead;
        UInt32 m_dwTail;
        UInt32 m_dwState;
        UInt32 m_ullCurrentPos;
        private byte[] m_pbBuf;
        public object m_cs = new object();   // Semaphore
        bool m_bEOS = false;

        public NeoQueue(UInt32 usize)
        {
            m_pbBuf = new byte[usize];
            m_dwSize = 0;
            m_dwHead = 0;
            m_dwTail = 0;
            m_dwState = 0;
            m_dwSize = usize;
            m_ullCurrentPos = 0;
        }

        public void Initialize()
        {
            m_dwHead = 0;
            m_dwTail = 0;
            m_ullCurrentPos = 0;
        }

        public UInt32 GetCurrentPos()
        {
            lock(m_cs)
            {
                return m_ullCurrentPos;
            }
        }
         
        public UInt32 GetFreeSize()
        {
            UInt32 dwSize = 0;

            lock (m_cs)
            {
                dwSize = (((m_dwTail >= m_dwHead) ? (m_dwSize - (m_dwTail - m_dwHead)) : (m_dwHead - m_dwTail)) - 1);
                return dwSize;
            }
        }

        public UInt32 GetFillSize()
        {
            UInt32 dwSize = 0;

            lock (m_cs)
            {
                dwSize = ((m_dwTail >= m_dwHead) ? (m_dwTail - m_dwHead) : (m_dwSize - (m_dwHead - m_dwTail)));
                return dwSize;
            }
        }

        // dwSize : 1~4
        public UInt32 PeekData(UInt32 dwPos, UInt32 dwSize)
        {
            byte[] bData = new byte[4];
            UInt32 dwFill;
            UInt32 dwData = 0;
            UInt32 dwSizeToEnd;
            UInt32 i;
            Int32 iTemp, iShift;

            if (dwSize > 4)
                return 0;

            while ((dwFill = GetFillSize()) < (dwPos + dwSize)
                && !m_bEOS && (m_dwState != State_Stopped))
                Thread.Sleep(1); 

            if (dwFill < (dwPos + dwSize))
                return 0;

            lock(m_cs)
            {
                dwSizeToEnd = m_dwSize - m_dwHead;

                if (dwSizeToEnd >= dwPos + dwSize)
                {
                    for (i = 0; i < dwSize; i++)
                    {
                        iShift = (Int32)((dwSize - (i + 1)) << 3);
                        iTemp = (Int32)(m_pbBuf[m_dwHead + dwPos + i]);
                        dwData = dwData + (UInt32)(iTemp << iShift);
                    }
                }
                else
                {
                    if (dwSizeToEnd > dwPos)
                    {
                        Buffer.BlockCopy(m_pbBuf, (int)(m_dwHead + dwPos), bData, 0, (int)(dwSizeToEnd - dwPos));
                        Buffer.BlockCopy(m_pbBuf, 0, bData, (int)(dwSizeToEnd - dwPos), (int)(dwPos + dwSize - dwSizeToEnd));
                        for (i = 0; i < dwSize; i++)
                        {
                            iShift = (Int32)((dwSize - (i + 1)) << 3);
                            iTemp = (Int32)(bData[i]);
                            dwData = dwData + (UInt32)(iTemp << iShift);
                        }
                    }
                    else
                    {
                        for (i = 0; i < dwSize; i++)
                        {
                            iShift = (Int32)((dwSize - (i + 1)) << 3);
                            iTemp = (Int32)(m_pbBuf[dwPos - dwSizeToEnd + i]);
                            dwData = dwData + (UInt32)(iTemp << iShift);
                        }
                    }
                }

                return dwData;
            }
        }

        //
        // FlushData
        //
        public void FlushData(UInt32 dwSize)
        {
            UInt32 dwFill, dwIdx;

            while ((dwFill = GetFillSize()) < dwSize && !m_bEOS && m_dwState != State_Stopped)
                Thread.Sleep(1);

            if (dwFill < dwSize)
            {
                if (m_bEOS)
                    dwSize = dwFill;
                else
                    return;
            }

            lock (m_cs)
            {
                dwIdx = m_dwHead + dwSize;

                if (dwIdx < m_dwSize)
                    m_dwHead = dwIdx;
                else
                    m_dwHead = dwIdx - m_dwSize;

                m_ullCurrentPos += dwSize;
            }

        }

        //--- Set m_dwTail
        private void FillData(UInt32 dwSize)
        {
            UInt32 dwFree, dwIdx;

            while ((dwFree = GetFreeSize()) < dwSize && !m_bEOS && m_dwState != State_Stopped)
                Thread.Sleep(1);

            if (dwFree < dwSize)
                return;

            lock(m_cs)
            {
                dwIdx = m_dwTail + dwSize;

                if (dwIdx < m_dwSize)
                    m_dwTail = dwIdx;
                else
                    m_dwTail = dwIdx - m_dwSize;
            }

        }

        public UInt32 GetData(UInt32 dwSize)
        {
            byte[] bData = new byte[4];
            UInt32 dwFill, dwData = 0, dwSizeToEnd, dwIdx, i;
            int iShift, iTemp;

            if (dwSize > 4)
                return 0;

            while ((dwFill = GetFillSize()) < dwSize && !m_bEOS && m_dwState != State_Stopped)
                Thread.Sleep(1);

            if (dwFill < dwSize)
                return 0;

            lock(m_cs)
            {
                dwSizeToEnd = m_dwSize - m_dwHead;

                if (dwSizeToEnd >= dwSize)
                {
                    for (i = 0; i < dwSize; i++)
                    {
                        iShift = (Int32)((dwSize - (i + 1)) << 3);
                        iTemp = (Int32)(m_pbBuf[m_dwHead + i]);
                        dwData = dwData + (UInt32)(iTemp << iShift);
                    }
                }
                else
                {
                    Buffer.BlockCopy(m_pbBuf, (int)(m_dwHead), bData, 0, (int)(dwSizeToEnd));
                    Buffer.BlockCopy(m_pbBuf, 0, bData, (int)(dwSizeToEnd), (int)(dwSize - dwSizeToEnd));
                    for (i = 0; i < dwSize; i++)
                    {
                        iShift = (Int32)((dwSize - (i + 1)) << 3);
                        iTemp = (Int32)(bData[i]);
                        dwData = dwData + (UInt32)(iTemp << iShift);
                    }
                }

                dwIdx = m_dwHead + dwSize;

                if (dwIdx < m_dwSize)
                    m_dwHead = dwIdx;
                else
                    m_dwHead = dwIdx - m_dwSize;

                m_ullCurrentPos += dwSize;

                return dwData;
            }
        }


        //
        // PutData
        //
        public UInt32 PutData(byte[] pbSrc, UInt32 dwBytesToCopy)
        {
            if (pbSrc.Length == 0)
                return 0;

            if (dwBytesToCopy == 0)
                return 0;

            //--- check if there is enough free size
            UInt32 dwFree = 0;
            UInt32 dwSizeToEnd;
            while ((dwFree = GetFreeSize()) < dwBytesToCopy && !m_bEOS && m_dwState != State_Stopped)
                Thread.Sleep(1);

            if (dwFree < dwBytesToCopy)
                return 0;
            
            lock(m_cs)
            {
                dwSizeToEnd = m_dwSize - m_dwTail;

                //--- boundary 경계 없이 data를 채울 수 있으면
                if (dwSizeToEnd >= dwBytesToCopy)
                {
                    Buffer.BlockCopy(pbSrc, 0, m_pbBuf, (int)m_dwTail, (int)dwBytesToCopy);
                }
                //--- boundary 경계를 지나면 2번 copy
                else
                {
                    Buffer.BlockCopy(pbSrc, 0, m_pbBuf, (int)m_dwTail, (int)dwSizeToEnd);
                    Buffer.BlockCopy(pbSrc, (int)dwSizeToEnd, m_pbBuf, 0, (int)(dwBytesToCopy - dwSizeToEnd));
                }
            }

            FillData(dwBytesToCopy);

            return dwBytesToCopy;
        }

        public UInt32 GetData(byte[] pbDst, UInt32 dwBytesToCopy)
        {
            if (pbDst.Length == 0)
                return 0;

            if (dwBytesToCopy == 0)
                return 0;

            UInt32 dwFill, dwSizeToEnd;

            //--- wait data fill
            while ((dwFill = GetFillSize()) < dwBytesToCopy && !m_bEOS && m_dwState != State_Stopped)
                Thread.Sleep(1);

            if (dwFill < dwBytesToCopy)
                return 0;
            
            lock(m_cs)
            {
                dwSizeToEnd = m_dwSize - m_dwHead;

                //--- 경계까지의 data 만으로 채울 수 있으면 
                if (dwSizeToEnd > dwBytesToCopy)
                {
                    Buffer.BlockCopy(m_pbBuf, (int)m_dwHead, pbDst, 0, (int)dwBytesToCopy);
                }
                else
                {
                    Buffer.BlockCopy(m_pbBuf, (int)m_dwHead, pbDst, 0, (int)dwSizeToEnd);
                    Buffer.BlockCopy(m_pbBuf, 0, pbDst, (int)dwSizeToEnd, (int)(dwBytesToCopy - dwSizeToEnd));
                }
            }

            FlushData(dwSizeToEnd);

            return dwSizeToEnd;
        }
    }

}
