namespace AppXChange.ConnectorCLI.Commands.Connector.New;

using System.CommandLine;

internal class ConnectorNewCommand : BaseCommand
{
    protected static Func<DirectoryInfo> GetDefaultValue { get; } =
        () => new DirectoryInfo(RootCommand.ExecutablePath);

    public Argument<DirectoryInfo> WorkingDirectory { get; } = new("working-directory", GetDefaultValue,
        "Working directory to create connector");

    public Option<string> ConnectorName { get; } =
        new(new[] { "--name", "-n" }, "ConnectorName");

    public Option<string> Output { get; } =
        new(new[] { "--output", "-o" }, "Output??");

    public Option<string> UrlPart { get; } =
        new(new[] { "--url-part", "-u" }, "Url Part");

    public Option<bool> DryRun { get; } =
        new(new[] { "--dry-run", "-d" }, () => false, "Dry run");

    public ConnectorNewCommand() : base("connector-new", "Create a new connector")
    {
        AddArgument(WorkingDirectory);
        AddOption(ConnectorName);
        AddOption(Output);
        AddOption(UrlPart);
        AddOption(DryRun);

        this.SetHandler(context =>
        {
            Result = context.ParseResult;
            try
            {
                context.ExitCode = new ConnectorNewCommandHandler(this).Run();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
                context.ExitCode = 1;
            }
        });
    }
}