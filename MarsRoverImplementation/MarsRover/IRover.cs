using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IRover
    {
        void TurnLeft(Compass compass);
        void TurnRight(Compass compass);
        void MoveForward(Compass compass, PlanetMars mars);
    }
}
