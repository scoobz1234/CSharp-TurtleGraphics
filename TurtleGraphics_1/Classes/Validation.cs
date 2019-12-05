using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics_1.Classes
{
    /// <summary>
    /// The following class will be controlling our output
    /// to the user.
    /// </summary>
    public static class Validation
    {
        public static void Instructions()
        {
            Console.WriteLine("Type a command to draw");
            Console.WriteLine("1 - Pen up | 2 - Pen Down");
            Console.WriteLine("3 - Up | 4 - Right | 5 - Down | 6 - Left");
            Console.WriteLine("7 - Exit Game");
        }
        public static string Error { get; set; }

        public static void InvalidPenAction()
        {
            Error = "\nInvalid Pen Action! Please enter 1 or 2 for pen up/down";
        }

        public static void InvalidDirection()
        {
            Error = "\nInvalid Direction! Please enter 3 - 6 for directions.";
        }

        public static void InvalidInput()
        {
            Error = "\nInvalid Input! Please enter 1 - 7 | Only integers accepted.";
        }
        //TODO - pass in arguments...
        public static void InvalidMovement(Directions.Direction dir, int spaces)
        {
            Error = String.Format("\nInvalid Movement! Your turtle is out of bounds. {0} spaces to the {1}\n",spaces, dir);
        }
    }
}
