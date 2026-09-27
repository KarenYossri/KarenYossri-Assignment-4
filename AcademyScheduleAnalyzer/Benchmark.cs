using BenchmarkDotNet.Attributes;
using System.Text;

[MemoryDiagnoser]
public class Benchmark
{
    [Params(100, 1000)]
    public int Iterations;

    [Benchmark]
    public string StringConcatenation()
    {
        string result = "";

        for (int i = 0; i < Iterations; i++)
        {
            result += "Academy Schedule Report";
        }

        return result;
    }

    [Benchmark]
    public string StringBuilderConcatenation()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < Iterations; i++)
        {
            sb.Append("Academy Schedule Report");
        }

        return sb.ToString();
    }
}