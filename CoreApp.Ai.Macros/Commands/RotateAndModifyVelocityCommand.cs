using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Commands
{
    public class RotateAndModifyVelocityCommand : ICommand
    {
        private readonly UObject _uObject;
        private readonly int _angle;

        public RotateAndModifyVelocityCommand(UObject uObject, int angle)
        {
            _uObject = uObject;
            _angle = angle;
        }

        public void Execute()
        {
            if (_uObject.Parameters.ContainsKey("velocity"))
            {
                int velocity = _uObject.Parameters["velocity"];
                _uObject.Parameters["velocity"] = velocity; 
            }

            _uObject.Parameters["angle"] = _angle;
        }
    }
}
