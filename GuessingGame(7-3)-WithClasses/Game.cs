using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleLibrary;

namespace GuessingGame_7_3__WithClasses
{
    public class Game
    {
        public int count { get; set; }
        public int diff { get; set; }
        public void DisplayGuessMessage()
        {
            if (diff == 0)
            {
                DisplayWinnerMessage();
            }
            else if (diff < -10)
            {
                MyConsole.PrintLine("Way too low! Guess again.");
            }
            else if (diff < 0)
            {
                MyConsole.PrintLine("Too low! Guess again.");
            }
            else if (diff > 10)
            {
                MyConsole.PrintLine("Way too high! Guess again.");
            }
            else if (diff > 0)
            {
                MyConsole.PrintLine("Too high! Guess again.");
            }
        }

        private void DisplayWinnerMessage()
        {
            MyConsole.PrintLine("You got it in " + count + " tries.");
            if (count <= 3)
            {
                MyConsole.PrintLine("Great work! You are a mathematical wizard.");
            }
            else if (count <= 7)
            {
                MyConsole.PrintLine("Not too bad! You've got some potential.");
            }
            else
            {
                MyConsole.PrintLine("What took you so long? Maybe you should take some lessons.");
            }
        }
    }
}
