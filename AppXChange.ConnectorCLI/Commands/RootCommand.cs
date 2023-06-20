namespace AppXChange.ConnectorCLI.Commands;

using Connector;
using ProvisionNew;

public class RootCommand : System.CommandLine.RootCommand
{
    public RootCommand() : base("AppXchange CLI")
    {
        AddCommand(new ConnectorNewCommand());
        AddCommand(new ProvisionCommand());
    }
}