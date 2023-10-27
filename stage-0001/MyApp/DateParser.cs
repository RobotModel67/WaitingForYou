using Microsoft.CodeAnalysis;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;

namespace net.robotmodel67
{

    //2023-10-26T11:24:36.6085212-05:00
    public class DateParser
    {

        public int GetYearFromDateTime(string dateTimeAsString)
        {
            var dateTime = DateTime.Parse(dateTimeAsString);
            return dateTime.Year;
        }
        public int GetYearFromSplit(string dateTimeAsString)
        {
            var splitOnHyphe = dateTimeAsString.Split("-");
            return int.Parse(splitOnHyphe[0]);
        }
        public int GetYearFromSubstring(string dateTimeAsString)
        {
            var i = dateTimeAsString.IndexOf("-");
            return int.Parse(dateTimeAsString.Substring(0, i));
        }
        public int GetYearFromSpan(ReadOnlySpan<char> dateTimeAsSpan)
        {
            var i = dateTimeAsSpan.IndexOf("-");
            return int.Parse(dateTimeAsSpan.Slice(0, i));
        }
        public int GetYearFromSpanManual(string dateTimeAsString)
        {
            ReadOnlySpan<char> dateTimeAsSpan = dateTimeAsString;
            var i = dateTimeAsSpan.IndexOf("-");
            var yearAsSpan = dateTimeAsSpan.Slice(0, i);
            var tmp = 0;
            for (int j = 0; j < yearAsSpan.Length; j++)
            {
                tmp = tmp * 10 + yearAsSpan[j];
            }
            //Console.WriteLine(tmp);
            return tmp;
        }
    }

}