using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Commands
{
    public class CheckFuelCommand : ICommand
    {
        private readonly UObject _uObject;
        private readonly int _requiredFuel;

        public CheckFuelCommand(UObject uObject, int requiredFuel)
        {
            _uObject = uObject;
            _requiredFuel = requiredFuel;
        }

        public void Execute()
        {
            if (!_uObject.Parameters.ContainsKey("fuel") || _uObject.Parameters["fuel"] < _requiredFuel)
            {
                throw new Exception("Not enough fuel to perform the action.");
            }
        }
    }
}
