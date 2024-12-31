using CoreApp.Ai.Macros.Commands;
using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Tests
{
    public class CheckFuelCommandTests
    {
        [Fact]
        public void Execute_WhenFuelIsSufficient_DoesNotThrowException()
        {
            var uObject = new UObject();
            uObject.Parameters["fuel"] = 10;
            var command = new CheckFuelCommand(uObject, 5);

            Exception exception = Record.Exception(() => command.Execute());

            Assert.Null(exception);
        }

        [Fact]
        public void Execute_WhenFuelIsInsufficient_ThrowsCommandException()
        {
            var uObject = new UObject();
            uObject.Parameters["fuel"] = 3;
            var command = new CheckFuelCommand(uObject, 5);

            Assert.Throws<Exception>(() => command.Execute());
        }
    }
}
