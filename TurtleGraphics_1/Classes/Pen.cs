using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleGraphics_1.Classes
{
    public class Pen
    {
        public Pen()
        {
            penState = PenStates.Up; // default to up position.
        }

        private PenStates penState; //holds our current state
        public enum PenStates
        {
            Up = 1,
            Down = 2
        };

        public PenStates UpdatePenState 
        {
            get { return penState; }
            set 
            {
                switch ((int)value)
                {
                    case 1:
                        penState = PenStates.Up;
                        break;
                    case 2:
                        penState = PenStates.Down;
                        break;
                    default:
                        Validation.InvalidPenAction();
                        break;
                }
            }
        }

        //string method to show pen state...
        public override string ToString()
        {
            return String.Format("Pen is {0}", penState == PenStates.Down ? "Drawing" : "Not Drawing");
        }
    }
}
