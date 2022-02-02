using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using BenchmarkDotNet.Diagnosers;


[MemoryDiagnoser]
public class MemoryBenchmarkerDemo
{
    [Benchmark]
    public void EscapeUri()
    {
#pragma warning disable SYSLIB0013 // Type or member is obsolete
		_ = Uri.EscapeUriString("MERCHID");
#pragma warning restore SYSLIB0013 // Type or member is obsolete
    }

    [Benchmark]
    public void EscapeData()
    {
		_ = Uri.EscapeDataString("MERCHID");
	}
	static void Main(string[] args) => BenchmarkSwitcher.FromAssemblies(new[] { typeof(MemoryBenchmarkerDemo).Assembly }).Run(args);
}

