using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class DiagonalRover : Rover, IRover
    {
        public DiagonalRover(PlanetMars mars, int xCordinate = 0, int yCordinate = 0, Pole direction = Pole.North) : base(mars, xCordinate, yCordinate, direction)
        {
        }
    }
}
