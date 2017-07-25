using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IRover
    {
        int XCordinate { get; }
        int YCordinate { get; }
        Pole FacingDirection { get; }

        bool Move(Direction direction);
    }
}
