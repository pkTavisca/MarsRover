using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class ControlCenter
    {

        public PlanetMars Mars { get; }
        public IRover Rover { get; }

        public ControlCenter(int planetLenth, int planetBreadth, int roverXCoordinate, int roverYCoordinate, Pole facingDirection)
        {
            Mars = new PlanetMars(planetLenth, planetBreadth);
            Rover = new Rover(Mars, roverXCoordinate, roverYCoordinate, facingDirection);
        }

        public void GiveRoverCommands(string commands)
        {
            foreach (var command in commands)
            {
                Rover.Move((Direction)command);
            }
        }
    }
}
