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
            Assert.IsFalse(rover.FacingDirection == Pole.South);
            Assert.IsTrue(rover.FacingDirection == Pole.North);
        }

        [TestMethod]
        public void Check_if_rover_moves_forward_from_initial_position()
        {
            var mars = new PlanetMars(1, 1);
            Rover rover = new Rover(mars);
            var roverMoved = rover.Move(Direction.Forward);
            Assert.AreEqual(Pole.North, rover.FacingDirection);
            Assert.IsFalse(roverMoved);
        }

        [TestMethod]
        public void Check_if_rover_moves_backward_from_initial_position()
        {
            Rover rover = new Rover(new PlanetMars());
            var roverMoved = rover.Move(Direction.Back);
            Assert.AreEqual(Pole.South, rover.FacingDirection);
            Assert.IsTrue(roverMoved);
        }

        [TestMethod]
        public void Move_rover_forward_by_2_steps()
        {
            Rover rover = new Rover(new PlanetMars(), 5, 5);
            int inititalY = rover.YCordinate;
            rover.Move(Direction.Forward);
            rover.Move(Direction.Forward);
            int finalY = rover.YCordinate;
            Assert.AreEqual(inititalY - 2, finalY);
            Assert.AreEqual(Pole.North, rover.FacingDirection);
        }

        [TestMethod]
        public void Move_rover_back_by_2_steps()
        {
            Rover rover = new Rover(new PlanetMars(), 5, 5);
            int inititalY = rover.YCordinate;
            rover.Move(Direction.Back);
            rover.Move(Direction.Back);
            int finalY = rover.YCordinate;
            Assert.AreEqual(inititalY, finalY);
            Assert.AreEqual(Pole.North, rover.FacingDirection);
        }

        [TestMethod]
        public void Move_rover_in_all_directions_in_single_tile_planet()
        {
            Rover rover = new Rover(new PlanetMars(1, 1));
            rover.Move(Direction.Forward);
            rover.Move(Direction.Back);
            rover.Move(Direction.Right);
            rover.Move(Direction.Left);
            Assert.IsTrue(rover.XCordinate == 0 && rover.YCordinate == 0);
            Assert.AreEqual(Pole.South, rover.FacingDirection);
        }

        [TestMethod]
        public void Move_rover_left_4_times()
        {
            Rover rover = new Rover(new PlanetMars(), 5, 5);
            rover.Move(Direction.Left);
            rover.Move(Direction.Left);
            rover.Move(Direction.Left);
            rover.Move(Direction.Left);
            Assert.IsTrue(rover.XCordinate == 5 && rover.YCordinate == 5);
            Assert.AreEqual(Pole.North, rover.FacingDirection);
        }
    }
}
