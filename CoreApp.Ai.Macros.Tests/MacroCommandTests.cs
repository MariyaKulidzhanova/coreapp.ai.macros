using CoreApp.Ai.Macros.Commands;
using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Tests
{
    public class MacroCommandTests
    {
        [Fact]
        public void Execute_WhenAllCommandsSucceed_ExecutesAllCommands()
        {
            var uObject = new UObject();
            uObject.Parameters["fuel"] = 10;

            var checkFuelCommand = new CheckFuelCommand(uObject, 5);
            var burnFuelCommand = new BurnFuelCommand(uObject, 5);

            var macroCommand = new MacroCommand(new List<ICommand> { checkFuelCommand, burnFuelCommand });

            Exception exception = Record.Exception(() => macroCommand.Execute());

            Assert.Null(exception);
            Assert.Equal(5, uObject.Parameters["fuel"]);
        }

        [Fact]
        public void Execute_WhenACommandFails_ThrowsCommandExceptionAndStopsExecution()
        {
            var uObject = new UObject();
            uObject.Parameters["fuel"] = 3;

            var checkFuelCommand = new CheckFuelCommand(uObject, 5);
            var burnFuelCommand = new BurnFuelCommand(uObject, 5);

            var macroCommand = new MacroCommand(new List<ICommand> { checkFuelCommand, burnFuelCommand });

            Assert.Throws<Exception>(() => macroCommand.Execute());
            Assert.Equal(3, uObject.Parameters["fuel"]);
        }
    }
}
