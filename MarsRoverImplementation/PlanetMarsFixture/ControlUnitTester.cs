using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;
using System.Linq;

namespace PlanetMarsFixture
{
    [TestClass]
    public class ControlUnitTester
    {
        [TestMethod]
        public void Moving_rover_along_the_edges_by_giving_excessive_steps()
        {
            ControlCenter controlCenter = new ControlCenter(10, 10, 0, 0, Pole.North);
            string commands = String.Empty;
            commands = string.Join(commands, Enumerable.Repeat('B', 50));
            commands = string.Join(commands, Enumerable.Repeat('L', 50));
            commands = string.Join(commands, Enumerable.Repeat('L', 50));
            commands = string.Join(commands, Enumerable.Repeat('L', 50));

            controlCenter.GiveRoverCommands(commands);
            Assert.AreEqual(0, controlCenter.Rover.XCordinate);
            Assert.AreEqual(0, controlCenter.Rover.YCordinate);
            Assert.AreEqual(Pole.West, controlCenter.Rover.FacingDirection);
        }
    }
}
