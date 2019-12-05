using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics_1.Classes
{
    public class GameLoop
    {
        private int option;
        private Pen pen;
        private Turtle turtle;
        private bool exit;
        private Board board;

        public GameLoop()
        {
            pen = new Pen();
            turtle = new Turtle();
            board = new Board();
            exit = false;
        }

        //main loop
        public void GameRunLoop()
        {
            do
            {
                Console.Clear(); //clear the console for next play.
                Console.WriteLine(Validation.Error); //displays any current error messages
                Validation.Error = ""; //clear the container so we can get more errors if needed

                board.DrawBoard(turtle.PosX, turtle.PosY, turtle.TurtleSymbol);
                Validation.Instructions(); // show the game instructions
                Console.WriteLine(pen); //displays the state of the pen (tostring) override method
                Console.WriteLine("Select your option: ");

                if (int.TryParse(Console.ReadLine(), out option)) // reads user input
                {
                    if (option > 0 && option < 3) //between 1-2 is pen action
                    {
                        pen.UpdatePenState = (Pen.PenStates)option;
                    }
                    else if (option > 2 && option < 7) // between 3-6 is directions
                    {
                        var direction = (Directions.Direction)option; //direction holds the cast value of option.
                        Console.WriteLine("Turtle is moving {0}", direction); //show what direction was selected
                        Console.WriteLine("Enter the number of spaces to move: ");
                        int spaces;
                        if (int.TryParse(Console.ReadLine(), out spaces))
                        {
                            turtle.Translate(direction, spaces, pen.UpdatePenState);
                        }
                        else
                        {
                            Validation.InvalidInput();
                        }
                    }
                    else if (option == 7)
                    {
                        exit = true;
                    }
                }
                else
                {
                    Validation.InvalidInput();
                }

            } while (!exit);
        }
    }
}
