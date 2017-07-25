using System;

namespace MarsRover
{
    public class North : IPoles
    {
        public Pole DirectionOfRover => Pole.North;

        public IPoles LeftDirection => new West();

        public IPoles RightDirection => new East();

        public Coordinate MoveForward(Coordinate originalPosition)
        {
            return new Coordinate(originalPosition.X, originalPosition.Y + 1);
        }
    }

    public class West : IPoles
    {
        public Pole DirectionOfRover => Pole.West;

        public IPoles LeftDirection => new South();

        public IPoles RightDirection => new North();

        public Coordinate MoveForward(Coordinate originalPosition)
        {
            return new Coordinate(originalPosition.X - 1, originalPosition.Y);
        }
    }

    public class South : IPoles
    {
        public Pole DirectionOfRover => Pole.South;

        public IPoles LeftDirection => new East();

        public IPoles RightDirection => new West();

        public Coordinate MoveForward(Coordinate originalPosition)
        {
            return new Coordinate(originalPosition.X, originalPosition.Y - 1);
        }
    }

    public class East : IPoles
    {
        public Pole DirectionOfRover => Pole.East;

        public IPoles LeftDirection => new North();

        public IPoles RightDirection => new South();

        public Coordinate MoveForward(Coordinate originalPosition)
        {
            return new Coordinate(originalPosition.X + 1, originalPosition.Y);
        }
    }
}
