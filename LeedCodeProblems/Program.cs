using BenchmarkDotNet.Attributes;


//BenchmarkDotNet.Running.BenchmarkRunner.Run<Test.TestRun>();

namespace LeedCodeProblems
{
    [MemoryDiagnoser]
    public class BenchmarkRun()
    {
        [Benchmark]
        public void Test1()
        {
            Solution solution = new();
        }
    }


    public class Run
    {
        public static void Main()
        {
            Solution solution = new();
        }
    }


    public class Solution
    {

    }
}
