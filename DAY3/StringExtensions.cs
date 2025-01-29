using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    public static class StringExtensions
    {
        public static string AddTimeStamp(this string str)
        {
            string strWithTimeStamp = $"{DateTime.Now} : {str}";
            return strWithTimeStamp;
        }

        public static bool FilterLogMessages(this string str,List<string> keywords)
        {
            if(str == "" || keywords.Count() == 0)
            {
                return false;
            }
            
            return keywords.Any(keyword => str.IndexOf(keyword,0) >= 0);
        }
    }
}
