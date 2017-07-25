using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover : IRover
    {
        public void MoveForward(Compass compass, PlanetMars mars)
        {
            if (mars.IsPositionInsidePlanet(compass.DirectionOfRover.MoveForward(mars.RoverPosition)))
            {
                mars.RoverPosition = compass.DirectionOfRover.MoveForward(mars.RoverPosition);
            }
        }

        public void TurnLeft(Compass compass)
        {
            compass.DirectionOfRover = compass.DirectionOfRover.LeftDirection;
        }

        public void TurnRight(Compass compass)
        {
            compass.DirectionOfRover = compass.DirectionOfRover.RightDirection;
        }
    }
}
