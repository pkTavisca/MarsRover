namespace MarsRover
{
    public class PlanetMars
    {
        public int Length { get; }
        public int Breadth { get; }

        public Coordinate RoverPosition { get; set; }

        public PlanetMars(Coordinate RoverPosition, int length = 10, int breadth = 10)
        {
            Length = length;
            Breadth = breadth;
            this.RoverPosition = RoverPosition;
        }

        public bool IsPositionInsidePlanet(Coordinate position)
        {
            return IsXPositionInsidePlanet(position) && IsYPositionInsidePlanet(position);
        }

        private bool IsXPositionInsidePlanet(Coordinate position)
        {
            return position.X < Breadth;
        }
        private bool IsYPositionInsidePlanet(Coordinate position)
        {
            return position.Y < Length;
        }
    }
}
