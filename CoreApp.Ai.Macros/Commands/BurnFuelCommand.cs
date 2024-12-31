using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Commands
{
    public class BurnFuelCommand : ICommand
    {
        private readonly UObject _uObject;
        private readonly int _fuelConsumption;

        public BurnFuelCommand(UObject uObject, int fuelConsumption)
        {
            _uObject = uObject;
            _fuelConsumption = fuelConsumption;
        }

        public void Execute()
        {
            if (_uObject.Parameters.ContainsKey("fuel"))
            {
                _uObject.Parameters["fuel"] -= _fuelConsumption;
            }
        }
    }
}
