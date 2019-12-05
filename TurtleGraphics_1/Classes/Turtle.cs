using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics_1.Classes
{
    public class Turtle
    {
        //CONSTRUCTOR//
        public Turtle()
        {
            TurtleSymbol = 'X';
            PosX = PosY = 0;
            Move = 0;
        }

        //PROPERTIES//
        public char TurtleSymbol { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Move { get; set; }

        const int LEFTUP = -1;
        const int RIGHTDOWN = 1;

        //Handles movement of the turtle based on direction, spaces, and pens state
        public void Translate(Directions.Direction direction, int spaces, Pen.PenStates pen)
        {
            if (ValidateTranslation(direction, spaces))
            {
                var draw = (pen == Pen.PenStates.Down); //draw holds the state of our pen.

                switch (direction)
                {
                    //if moving up were moving in -X
                    case Directions.Direction.Up:
                        if (draw) Board.UpdateBoardX(PosX,spaces,LEFTUP,PosY);
                        PosX -= spaces;
                        break;
                    //if moving down were moving in +X
                    case Directions.Direction.Down:
                        if (draw) Board.UpdateBoardX(PosX, spaces, RIGHTDOWN, PosY);
                        PosX += spaces;
                        break;
                    //if moving Left were moving in -Y
                    case Directions.Direction.Left:
                        if (draw) Board.UpdateBoardY(PosY, spaces, LEFTUP, PosX);
                        PosY -= spaces;
                        break;
                    //if moving Right were moving in +Y
                    case Directions.Direction.Right:
                        if (draw) Board.UpdateBoardY(PosY, spaces, RIGHTDOWN, PosX);
                        PosY += spaces;
                        break;
                }
            }
        }

        //Check if the move is not out of bounds...
        // if moving left were subtracting spaces, if moving right were adding spaces.
        // if moving up were subtracting spaces, if were moving down were adding spaces.
        private bool ValidateTranslation(Directions.Direction dir, int spaces)
        {
            if (dir == Directions.Direction.Up && (PosX - spaces) < 0)
            {
                Validation.InvalidMovement(dir,PosX);
                return false;
            }
            else if (dir == Directions.Direction.Right && (PosY + spaces) > Board.BoardSizeY)
            {
                Validation.InvalidMovement(dir, Board.BoardSizeY - PosY - 1);
                return false;
            }
            else if (dir == Directions.Direction.Down && (PosX + spaces) > Board.BoardSizeX)
            {
                Validation.InvalidMovement(dir, Board.BoardSizeX - PosX - 1);
                return false;
            }
            else if (dir == Directions.Direction.Left && (PosY - spaces) < 0)
            {
                Validation.InvalidMovement(dir, PosY);
                return false;
            }

            return true;
        }
    }
}
