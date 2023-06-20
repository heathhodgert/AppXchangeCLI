namespace AppXChange.ConnectorCLI.Commands.Connector.New;

internal class ConnectorNewOptions : BaseOptions
{
    public ConnectorNewOptions(ConnectorNewCommand command) : base(command)
    {
        WorkingDirectory = Argument(command.WorkingDirectory);
        Name = Option(command.ConnectorName) ?? "example";
        Output = Option(command.Output) ?? "example";
        UrlPart = Option(command.UrlPart) ?? "example";
        DryRun = Option(command.DryRun);
    }

    public DirectoryInfo WorkingDirectory { get; set; }
    public string Name { get; set; }
    public string Output { get; set; }
    public string UrlPart { get; set; }
    public bool DryRun { get; set; }
}