using System.Collections.Generic;

namespace AlcSimulator.DL

{
    public class BoudRateData
    {

        public List<int> BoudRateList()
        {
            List<int> boudRate = new List<int>();

            boudRate.Add(1200);
            boudRate.Add(2400);
            boudRate.Add(4800);
            boudRate.Add(9600);
            boudRate.Add(14400);
            boudRate.Add(19200);
            boudRate.Add(28800);
            boudRate.Add(38400);
            boudRate.Add(115200);
            boudRate.Add(128000);
            boudRate.Add(256000);
            boudRate.Add(230400);
            boudRate.Add(460800);
            boudRate.Add(921600);

            return boudRate;
        }
    }
}