        public  string CheckSums(string strSource)
        {
            byte[] byteToCalculate = Encoding.ASCII.GetBytes(strSource);
            int checksum = 0;
            foreach (byte bData in byteToCalculate)
            {
                checksum = checksum + bData;
            }
            int hexSum = (checksum % 256);
            string textCheckSum = hexSum.ToString("X");
            if (textCheckSum.Length == 1)
            {
                textCheckSum = "0" + textCheckSum;
            }
            return textCheckSum;

        }

        private string CalculateChecksum(string dataToCalculate)
        {
            byte[] byteToCalculate = Encoding.ASCII.GetBytes(dataToCalculate);
            int checksum = 0;
            foreach (byte chData in byteToCalculate)
            {
                checksum += chData;
            }
            checksum &= 0xff;
            return checksum.ToString("X2");
        }