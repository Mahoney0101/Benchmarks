``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
11th Gen Intel Core i7-1185G7 3.00GHz, 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT
  Job-UQZRFX : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  Job-XTPWQX : .NET Framework 4.8 (4.8.4420.0), X64 RyuJIT


```
|     Method |        Job |            Runtime | Toolchain |      Mean |     Error |    StdDev | Ratio | Allocated |
|----------- |----------- |------------------- |---------- |----------:|----------:|----------:|------:|----------:|
|  EscapeUri | Job-UQZRFX |           .NET 6.0 |     net60 |  7.187 ns | 0.1319 ns | 0.1233 ns |  0.16 |         - |
|  EscapeUri | Job-XTPWQX | .NET Framework 4.8 |     net48 | 43.713 ns | 0.8832 ns | 0.9070 ns |  1.00 |         - |
|            |            |                    |           |           |           |           |       |           |
| EscapeData | Job-UQZRFX |           .NET 6.0 |     net60 |  8.114 ns | 0.1818 ns | 0.1785 ns |  0.20 |         - |
| EscapeData | Job-XTPWQX | .NET Framework 4.8 |     net48 | 41.412 ns | 0.7284 ns | 0.6813 ns |  1.00 |         - |
