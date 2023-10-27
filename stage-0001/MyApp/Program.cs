
using BenchmarkDotNet.Running;

namespace net.robotmodel67 {
    public class Program {
        public static void Main(string[] arguments) {
            BenchmarkRunner.Run<DateParserBenchMarks>();
        }
        
        public static void MainOriginal(string[] arguments) {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("The current time is: " + DateTime.Now.ToString("o"));

        }

    }
}


// See https://aka.ms/new-console-template for more information
