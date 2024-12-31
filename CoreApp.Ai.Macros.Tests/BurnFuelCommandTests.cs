using CoreApp.Ai.Macros.Commands;
using CoreApp.Ai.Macros.Models;

namespace CoreApp.Ai.Macros.Tests
{
    public class BurnFuelCommandTests
    {
        [Fact]
        public void Execute_WhenFuelIsSufficient_ReducesFuelByConsumption()
        {
            var uObject = new UObject();
            uObject.Parameters["fuel"] = 10;
            var command = new BurnFuelCommand(uObject, 5);

            command.Execute();

            Assert.Equal(5, uObject.Parameters["fuel"]);
        }
    }
}
