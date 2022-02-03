Use this command to run the benchmark application. 
Add any methods to benchmark to program.cs.
Add new versions of .NET to csproj

Run using the following command
dotnet run -c Release -f net48 --runtimes net48 netcoreapp3.1 net50 net60 --filter ** --join