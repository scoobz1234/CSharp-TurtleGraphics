using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurtleGraphics_1.Classes;

namespace TurtleGraphics_1
{
    class TurtleGame
    {
        static void Main(string[] args)
        {
            var game = new GameLoop(); // instantiate gameloop object
            game.GameRunLoop(); // runs the games looping method.

            Console.WriteLine("\n Thanks for palying!\n");
        }
    }
}
