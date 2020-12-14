using System.Collections.Generic;

namespace AlcSimulator.DL
{
    public class MessageData
    {

        public Dictionary<int, string> MessageDictionary()
        {
            Dictionary<int, string> alcData = new Dictionary<int, string>()
            {
                { 1, "$abt_P\r\n"},
                { 2, "$abt_S\r\n"},
                { 3, "$abt_H\r\n"},
                { 4, "$abt_S\r\n"},
                { 5, "$abt_OK\r\n"},
                { 6, "$abt_Value_xxxxx g/L\r\n"},
                { 7, "$abt_Err-B\r\n"},
                { 8, "$abt_Err-O\r\n"},
                { 9, "$abt_Err-S\r\n"},
                { 10, "$abt_Err-t\r\n"},

            };
            return alcData;
        }
    }

}
