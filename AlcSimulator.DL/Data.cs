using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcSimulator.DL
{
    public class Data
    {
        

        Dictionary<int, string> alcData = new Dictionary<int, string>();

        public void AddData()
        {
            alcData.Add(1, "$abt_PCRLF");
            alcData.Add(2, "$abt_SCRLF");
            alcData.Add(3, "$abt_HICRLF");
            alcData.Add(4, "$abt_STCRLF");
            alcData.Add(5, "$abt_OKCRLF");
            alcData.Add(6, "$abt_Value_xx.xxxCRLF");
            alcData.Add(7, "$abt_Err-BCRLF");
            alcData.Add(8, "$abt_Err-OCRLF");
            alcData.Add(9, "$abt_Err-SCRLF");
            alcData.Add(10, "$abt_Err-tCRLF");

        }

    }
    
}
