using System.Security.AccessControl;
using ConsoleLibrary;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string hangman = """
                            -----
                            |   |
                            |   O
                            |  /|\
                            |  / \
                            |
                            -------
                            """;
            string guess = GetHangmanImage(0);
            MyConsole.Print(guess);
            string guess2 = GetHangmanImage(1);
            MyConsole.Print(guess2);
            string guess3 = GetHangmanImage(2);
            MyConsole.Print(guess3);
        }

        static string GetHangmanImage(int incorrectGuesses)
        {
            string[] hangmanImages = { """
                            -----
                            |   |
                            |   
                            |  
                            |  
                            |
                            -------
                            """,
                """
                -----
                |   |
                |   O
                |  
                | 
                |
                -------
                
                """, """
                            -----
                            |   |
                            |   O
                            |  /|\
                            |  / \
                            |
                            -------
                            """ };
            if (incorrectGuesses > 2 || incorrectGuesses < 0)
                return "Error, Incorrect guesses are out of scope for hangman.";
            return hangmanImages[incorrectGuesses];
            
        }
    }
}
