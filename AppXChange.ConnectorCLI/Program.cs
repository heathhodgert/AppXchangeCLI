namespace AppXChange.ConnectorCLI;

using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using Commands;

internal abstract class Program
{
    private static int Main(string[] args) =>
        new CommandLineBuilder(new RootCommand())
            .UseVersionOption("--version", "-v")
            .UseParseErrorReporting()
            .UseHelp()
            .UseTypoCorrections()
            .Build()
            .Invoke(args);


}