using ConsoleLibrary;

namespace CHap09DemoSubstringandIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letters = "abcdefg";
            string allLetters = letters.Substring(0);
            MyConsole.PrintLine($"all letters: {allLetters}");
            string first3Letters = letters.Substring(0, 3);
            
            MyConsole.PrintLine($"next three letters: {letters.Substring(3, 3)}");
            MyConsole.PrintLine($"next three letters: {letters.Substring(6, 1)}");
            MyConsole.PrintLine($"next three letters: {letters.Substring(6, 1)}");

            string fullName = "Robert Nesta Marley";

            int firstSpace = fullName.IndexOf(" ");
            MyConsole.PrintLine($"firstSpace = {firstSpace}"); //6
            int secondSpace = fullName.IndexOf(" ", firstSpace + 1);
            MyConsole.PrintLine($"secondSpace = {secondSpace}"); //12

            string firstName = fullName.Substring(0, firstSpace);
            MyConsole.PrintLine($"firstName = {firstName}.");
            string middleName = fullName.Substring(firstSpace + 1, (secondSpace - firstSpace - 1));
            MyConsole.PrintLine($"middleName = {middleName}.");
            string lastName = fullName.Substring(secondSpace+1);
            MyConsole.PrintLine($"middleName = {lastName}.");



        }
    }
}
