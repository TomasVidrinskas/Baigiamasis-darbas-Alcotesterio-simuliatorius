using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcSimulator.DL
{
    public class MessageData
    {


        Dictionary<int, string> alcData = new Dictionary<int, string>()
        {
            { 1, "$abt_PCRLF"},
            { 2, "$abt_SCRLF"},
            { 3, "$abt_HICRLF"},
            { 4, "$abt_STCRLF"},
            { 5, "$abt_OKCRLF"},
            { 6, "$abt_Value_xx.yyyCRLF"},
            { 7, "$abt_Err-BCRLF"},
            { 8, "$abt_Err-OCRLF"},
            { 9, "$abt_Err-SCRLF"},
            { 10, "$abt_Err-tCRLF"},

        };
    }

}
