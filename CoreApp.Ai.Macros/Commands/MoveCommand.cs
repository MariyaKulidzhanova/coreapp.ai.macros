using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Commands
{
    public class MoveCommand : ICommand
    {
        private readonly UObject _uObject;

        public MoveCommand(UObject uObject)
        {
            _uObject = uObject;
        }

        public void Execute()
        {
            // Implement the movement logic
        }
    }
}
