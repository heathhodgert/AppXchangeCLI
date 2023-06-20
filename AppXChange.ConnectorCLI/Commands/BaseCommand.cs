namespace AppXChange.ConnectorCLI.Commands;

using System.CommandLine;
using System.CommandLine.Parsing;

public class BaseCommand : Command
{
    public ParseResult? Result;
    
    protected BaseCommand(string name, string? description = null) : base(name, description)
    {
        AddOption(Verbosity);
    }
    
    public Option<VerbosityLevel> Verbosity { get; } =
        new(new[] { "--verbosity", "-v" }, () => VerbosityLevel.Normal, "Verbosity level");
}