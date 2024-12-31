using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Commands
{
    public class MoveWithFuelCommand : ICommand
    {
        private readonly MacroCommand _macroCommand;

        public MoveWithFuelCommand(UObject uObject, int fuelConsumption)
        {
            var commands = new List<ICommand>
            {
                new CheckFuelCommand(uObject, fuelConsumption),
                new MoveCommand(uObject),
                new BurnFuelCommand(uObject, fuelConsumption)
            };
            _macroCommand = new MacroCommand(commands);
        }

        public void Execute()
        {
            _macroCommand.Execute();
        }
    }
}
