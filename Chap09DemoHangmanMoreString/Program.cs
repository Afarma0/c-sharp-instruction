using ConsoleLibrary;

namespace Chap09DemoHangmanMoreString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangman HiddenWord Resolution.\n");

            //define theWord
            string theWord = "superstitious";
            MyConsole.PrintLine($"theWord: {theWord}");

            //generate hiddenWord (string == theWord.Length, all underscores)
            //# of letters in theWord
            //hiddenWord -> same length as theWord, all underscores

            //display hiddenWord w/ spaces separating the underscores


            string hiddenWord = "";

            foreach (char c in theWord)
            {
                hiddenWord += "_";
            }
            MyConsole.PrintLine($"hiddenWord: {hiddenWord}");

            DisplayHiddenWord(hiddenWord);

            string letter = "";
            bool winner = false;
            while (!winner)
            {


                //prompt user for a letter: string

                letter = MyConsole.PromptString("Guess a letter: ");
                //iterate over characters in theWord and find any matches for letter
                char[] charsTheWord = theWord.ToCharArray();
                char[] charsHiddenWord = hiddenWord.ToCharArray();

                for (int i = 0; i < charsTheWord.Length; i++)
                {
                    char c = charsTheWord[i];

                    //MyConsole.PrintLine($"c is {c}.");
                    if (letter.Equals(c.ToString()))
                    {
                        MyConsole.PrintLine($"Letter found! {i}");
                        //resolve this character in hiddenWord
                        charsHiddenWord[i] = c;
                    }
                }

                //if (hiddenWord == theWord)
                
                hiddenWord = new string(charsHiddenWord);
                if (hiddenWord.IndexOf('_') == -1)
                {
                    winner = true;
                }
                DisplayHiddenWord(hiddenWord);

            }
            //resolve correctly guessed letter
            MyConsole.PrintLine("Bye");



        }

        private static void DisplayHiddenWord(string hiddenWord)
        {
            MyConsole.PrintLine("display hiddenword");

            foreach (char c in hiddenWord)
            {
                MyConsole.Print($"{c} ");
            }

            MyConsole.PrintLine();
        }
    }
}
