using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IPoles
    {
        Pole DirectionOfRover { get; }

        IPoles LeftDirection { get; }

        IPoles RightDirection { get; }

        Coordinate MoveForward(Coordinate originalPosition);
    }
}
