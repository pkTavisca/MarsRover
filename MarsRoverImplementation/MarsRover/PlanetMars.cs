using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class PlanetMars
    {
        public int Length { get; }
        public int Breadth { get; }

        public PlanetMars(int length = 10, int breadth = 10)
        {
            Length = length;
            Breadth = breadth;
        }

        public bool IsPositionInsidePlanet(int x, int y)
        {
            bool isXPostionInsidePlanet = x < Breadth && x >= 0;
            bool isYPostionInsidePlanet = y < Length && y >= 0;
            if (isXPostionInsidePlanet && isYPostionInsidePlanet) return true;
            return false;
        }
    }
}
