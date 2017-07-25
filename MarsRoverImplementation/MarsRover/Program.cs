using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string input = Console.ReadLine();
            int length = int.Parse(input.Split(' ')[0]);
            int breadth = int.Parse(input.Split(' ')[1]);

            while (!input.Equals("-1"))
            {
                input = Console.ReadLine();
                string[] inArr = input.Split(' ');
                Coordinate position = new Coordinate(int.Parse(inArr[0]), int.Parse(inArr[1]));
                PlanetMars mars = new PlanetMars(position, length, breadth);
                IRover rover = new Rover();
                Compass compass;
                switch (inArr[2][0])
                {
                    case 'N':
                        compass = new Compass(new North());
                        break;
                    case 'E':
                        compass = new Compass(new East());
                        break;
                    case 'W':
                        compass = new Compass(new West());
                        break;
                    case 'S':
                        compass = new Compass(new South());
                        break;
                    default:
                        compass = new Compass(new North());
                        break;
                }

                ControlCenter controlCenter = new ControlCenter(mars, rover, compass);

                string commands = Console.ReadLine();

                controlCenter.ExecuteCommand(commands);

                Console.WriteLine("{0} {1}", mars.RoverPosition.ToString(), (char)compass.DirectionOfRover.DirectionOfRover);

            }
        }
    }
}
