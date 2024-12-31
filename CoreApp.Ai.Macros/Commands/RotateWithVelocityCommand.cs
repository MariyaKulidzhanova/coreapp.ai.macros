using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Commands
{
    public class RotateWithVelocityCommand : ICommand
    {
        private readonly MacroCommand _macroCommand;

        public RotateWithVelocityCommand(UObject uObject, int angle)
        {
            var commands = new List<ICommand>
            {
                new RotateCommand(uObject, angle),
            };
            _macroCommand = new MacroCommand(commands);
        }

        public void Execute()
        {
            _macroCommand.Execute();
        }
    }
}
