using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics_1.Classes
{
    public static class Directions
    {
        //specify direction of the move every time we move, so
        //no need to have lastDirection, where did we go... ect..
        private static Direction direction;
        public enum Direction {
            Up = 3,
            Right = 4,
            Down = 5,
            Left = 6
        };

        public static Direction UpdateDirection 
        {
            get { return direction; }
            set 
            {
                switch ((int)value) // convert the value to integer because it doesnt like it otherwise.
                {
                    case 3:
                        direction = Direction.Up;
                        break;
                    case 4:
                        direction = Direction.Right;
                        break;
                    case 5:
                        direction = Direction.Down;
                        break;
                    case 6:
                        direction = Direction.Left;
                        break;
                    default:
                        Validation.InvalidDirection(); // if its not 3-6 we send an error message...
                        break;
                }
            }
        }
    }
}
