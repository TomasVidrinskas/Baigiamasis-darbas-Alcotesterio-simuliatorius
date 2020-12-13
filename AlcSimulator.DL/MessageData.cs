using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcSimulator.DL
{
    public class MessageData
    {

        public Dictionary<int, string> MessageDictionary()
        {
            Dictionary<int, string> alcData = new Dictionary<int, string>()
            {
                { 1, "$abt_PCRLF\r\n"},
                { 2, "$abt_SCRLF\r\n"},
                { 3, "$abt_HICRLF\r\n"},
                { 4, "$abt_STCRLF\r\n"},
                { 5, "$abt_OKCRLF\r\n"},
                { 6, "$abt_Value_xx.yyyCRLF\r\n"},
                { 7, "$abt_Err-BCRLF\r\n"},
                { 8, "$abt_Err-OCRLF\r\n"},
                { 9, "$abt_Err-SCRLF\r\n"},
                { 10, "$abt_Err-tCRLF\r\n"},

            };
            return alcData;
        }
    }

}
