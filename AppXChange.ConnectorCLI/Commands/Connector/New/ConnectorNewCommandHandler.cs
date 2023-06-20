namespace AppXChange.ConnectorCLI.Commands.Connector.New;

internal class ConnectorNewCommandHandler
{
    private readonly ConnectorNewOptions _options;

    public ConnectorNewCommandHandler(ConnectorNewCommand command)
    {
        _options = new ConnectorNewOptions(command);
    }

    public int Run()
    {
        Console.WriteLine($"working-directory: {_options.WorkingDirectory}");
        Console.WriteLine($"connector-name: {_options.Name}");
        Console.WriteLine($"output: {_options.Output}");
        Console.WriteLine($"url-part: {_options.UrlPart}");
        Console.WriteLine($"dry-run: {_options.DryRun}");

        return 0;
    }
}