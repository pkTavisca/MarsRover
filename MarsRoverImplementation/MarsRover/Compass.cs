using System.Collections.Generic;

namespace MarsRover
{
    public class Compass
    {
        public IPoles DirectionOfRover { get; set; }

        public Compass(IPoles DirectionOfRover)
        {
            this.DirectionOfRover = DirectionOfRover;
        }

        override
        public string ToString()
        {
            return string.Format("{0}", (char)DirectionOfRover.DirectionOfRover);
        }

    }
}
