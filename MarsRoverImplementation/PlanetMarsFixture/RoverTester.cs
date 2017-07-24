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
            Rover rover = new Rover(new PlanetMars());
            Assert.IsTrue(rover.XCordinate == 0);
            Assert.IsTrue(rover.YCordinate == 0);
        }

        [TestMethod]
        public void Check_position_of_rover_with_initial_coordinates()
        {
            Rover rover = new Rover(new PlanetMars());
            Assert.IsTrue(rover.XCordinate == 0);
            Assert.IsTrue(rover.YCordinate == 0);
        }

        [TestMethod]
        public void Check_initital_direction_of_rover()
        {
            Rover rover = new Rover(new PlanetMars());
            Assert.IsFalse(rover.FacingDirection == Direction.South);
            Assert.IsTrue(rover.FacingDirection == Direction.North);
        }

        [TestMethod]
        public void Check_if_rover_moves_north_from_initial_position()
        {
            var mars = new PlanetMars(1, 1);
            Rover rover = new Rover(mars);
            var roverMoved = rover.Move(Direction.North);
            Assert.IsFalse(roverMoved);
        }
        [TestMethod]
        public void Check_if_rover_moves_south_from_initial_position()
        {
            Rover rover = new Rover(new PlanetMars());
            var roverMoved = rover.Move(Direction.South);
            Assert.IsTrue(roverMoved);
        }
    }
}
