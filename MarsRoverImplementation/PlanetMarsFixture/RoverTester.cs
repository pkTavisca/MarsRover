using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace PlanetMarsFixture
{
    [TestClass]
    public class RoverTester
    {
        [TestMethod]
        public void Check_position_of_rover_with_no_initial_coordinates()
        {
            Rover rover = new Rover();
            Assert.IsTrue(rover.XCordinate == 0);
            Assert.IsTrue(rover.YCordinate == 0);
        }
        [TestMethod]
        public void Check_position_of_rover_with_initial_coordinates()
        {
            Rover rover = new Rover();
            Assert.IsTrue(rover.XCordinate == 0);
            Assert.IsTrue(rover.YCordinate == 0);
        }
    }
}
