using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics_1.Classes
{
    public class Board
    {
        public const int BoardSizeX = 20;
        public const int BoardSizeY = 20;
        public const char DrawnSpace = '*';
        public const char EmptySpace = ' '; //can change this to a space later...

        public Board()
        {
            BoardArray = new char[BoardSizeX, BoardSizeY];
            InitBoard();
        }

        public static char [,] BoardArray { get; set; } // array we will draw to for the board.

        //set the array to the empty space character...
        public void InitBoard()
        {
            for (var x = 0; x < BoardSizeX; x++)
            {
                for (var y = 0; y < BoardSizeY; y++)
                {
                    BoardArray[x, y] = EmptySpace;
                }
            }
        }

        //Draw board
        // iterate through the x positions and y positions, if you get to an x and y
        // position that = turtle x and y, then we draw the turtle.
        // if not, we draw the empty space.
        public void DrawBoard(int posX, int posY, char turtle)
        {
            for (var x = 0; x < BoardSizeX; x++)
            {
                for (var y = 0; y < BoardSizeY; y++)
                {
                    if (x == posX && y == posY)
                    {
                        Console.Write(turtle);
                    }
                    else
                    {
                        Console.Write(BoardArray[x, y]);
                    }
                }
                Console.WriteLine();
            }
        }

        //update the board array, this is when the turtle moves we can update his position
        //If turtle is moving up or down
        public static void UpdateBoardX(int startPos, int movNum, int movDir, int constPosY)
        {
            for (var x = 0; x < movNum; x++)
            {
                BoardArray[startPos + (x * movDir), constPosY] = DrawnSpace;
            }
        }

        // here we take in the starting position or current position of the turtle
        // then we iterate through the board array the number of moves
        // then we set the constant (unchaning) x position, and input
        // the y position by using the starting position and adding +1 or - 1
        public static void UpdateBoardY(int startPos, int movNum, int movDir, int constPosX)
        {
            for (var y = 0; y < movNum; y++)
            {
                BoardArray[constPosX, startPos + (y * movDir)] = DrawnSpace;
            }
        }
    }
}
