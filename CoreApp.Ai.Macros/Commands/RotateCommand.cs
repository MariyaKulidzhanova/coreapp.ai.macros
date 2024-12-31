using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Commands
{
    public class RotateCommand : ICommand
    {
        private readonly UObject _uObject;
        private readonly int _angle;

        public RotateCommand(UObject uObject, int angle)
        {
            _uObject = uObject;
            _angle = angle;
        }

        public void Execute()
        {
            if (_uObject.Parameters.ContainsKey("velocity"))
            {
                _uObject.Parameters["velocity"] = CalculateNewVelocity(_uObject.Parameters["velocity"], _angle);
            }
            else
            {
                _uObject.Parameters["angle"] = _angle;
            }
        }

        private int CalculateNewVelocity(int currentVelocity, int angle)
        {
            if (angle == 180)
            {
                return -currentVelocity;
            }

            return currentVelocity;
        }
    }
}
