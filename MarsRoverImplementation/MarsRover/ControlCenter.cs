using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class ControlCenter
    {
        public PlanetMars Mars { get; set; }
        public IRover Rover { get; set; }
        public Compass RoverCompass { get; set; }

        public ControlCenter(PlanetMars Mars, IRover Rover, Compass RoverCompass)
        {
            this.Mars = Mars;
            this.Rover = Rover;
            this.RoverCompass = RoverCompass;
        }

        public void ExecuteCommand(Input command)
        {
            if (command == Input.Left) Rover.TurnLeft(RoverCompass);
            else if (command == Input.Right) Rover.TurnRight(RoverCompass);
            else if (command == Input.MoveForward) Rover.MoveForward(RoverCompass, Mars);
        }

        public void ExecuteCommand(char command)
        {
            ExecuteCommand((Input)command);
        }

        public void ExecuteCommand(string commands)
        {
            foreach (var command in commands)
            {
                ExecuteCommand(command);
            }
        }
    }
}
