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
            Assert.AreEqual(Direction.North, rover.FacingDirection);
            Assert.IsFalse(roverMoved);
        }

        [TestMethod]
        public void Check_if_rover_moves_south_from_initial_position()
        {
            Rover rover = new Rover(new PlanetMars());
            var roverMoved = rover.Move(Direction.South);
            Assert.AreEqual(Direction.South, rover.FacingDirection);
            Assert.IsTrue(roverMoved);
        }

        [TestMethod]
        public void Move_rover_north_by_2_steps()
        {
            Rover rover = new Rover(new PlanetMars(), 5, 5);
            int inititalY = rover.YCordinate;
            rover.Move(Direction.North);
            rover.Move(Direction.North);
            int finalY = rover.YCordinate;
            Assert.AreEqual(inititalY - 2, finalY);
            Assert.AreEqual(Direction.North, rover.FacingDirection);
        }

        [TestMethod]
        public void Move_rover_south_by_2_steps()
        {
            Rover rover = new Rover(new PlanetMars(), 5, 5);
            int inititalY = rover.YCordinate;
            rover.Move(Direction.South);
            rover.Move(Direction.South);
            int finalY = rover.YCordinate;
            Assert.AreEqual(inititalY + 2, finalY);
            Assert.AreEqual(Direction.South, rover.FacingDirection);
        }

        [TestMethod]
        public void Move_rover_in_all_directions_in_single_tile_planet()
        {
            Rover rover = new Rover(new PlanetMars(1, 1));
            rover.Move(Direction.North);
            rover.Move(Direction.South);
            rover.Move(Direction.East);
            rover.Move(Direction.West);
            Assert.IsTrue(rover.XCordinate == 0 && rover.YCordinate == 0);
            Assert.AreEqual(Direction.West, rover.FacingDirection);
        }

        [TestMethod]
        public void Move_rover_in_all_directions()
        {
            Rover rover = new Rover(new PlanetMars(), 5, 5);
            rover.Move(Direction.North);
            rover.Move(Direction.South);
            rover.Move(Direction.East);
            rover.Move(Direction.West);
            Assert.IsTrue(rover.XCordinate == 5 && rover.YCordinate == 5);
            Assert.AreEqual(Direction.West, rover.FacingDirection);
        }
    }
}
