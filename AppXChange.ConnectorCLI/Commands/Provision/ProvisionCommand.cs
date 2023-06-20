using AppXChange.ConnectorCLI.Commands.ProvisionNew.Patch;

namespace AppXChange.ConnectorCLI.Commands.ProvisionNew
{
    using New;

    internal class ProvisionCommand : BaseCommand
    {
        public ProvisionCommand() : base("provision", "provision commands")
        {
            AddCommand(new ProvisionNewCommand());
            AddCommand(new ProvisionPatchCommand());
        }
    }
}
