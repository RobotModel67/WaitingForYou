using BenchmarkDotNet.Attributes;

namespace net.robotmodel67
{

    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [RPlotExporter]
    public class DateParserBenchMarks
    {
        private const string DateTime = "2023-10-26T11:31:44.0614861-05:00";
        private static readonly DateParser Parser = new DateParser();
        /*
        [Benchmark(Baseline = true)]
        public void GetYearFromDateTime()
        {
            Parser.GetYearFromDateTime(DateTime);
        }
        [Benchmark]
        public void GetYearFromSplit()
        {
            Parser.GetYearFromSplit(DateTime);
        }
        */
        [Benchmark]
        public void GetYearFromSubstring()
        {
            Parser.GetYearFromSubstring(DateTime);
        }
        [Benchmark]
        public void GetYearFromSpan()
        {
            Parser.GetYearFromSpan(DateTime);
        }
        [Benchmark]
        public void GetYearFromSpanManual()
        {
            Parser.GetYearFromSpanManual(DateTime);
        }
    }

}