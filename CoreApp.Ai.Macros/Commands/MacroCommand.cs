using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands;

        public MacroCommand(IEnumerable<ICommand> commands)
        {
            _commands = new List<ICommand>(commands);
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                try
                {
                    command.Execute();
                }
                catch (Exception ex)
                {
                    throw new Exception("MacroCommand execution failed", ex);
                }
            }
        }
    }
}
