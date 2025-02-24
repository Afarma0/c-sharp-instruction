using ConsoleLibrary;

namespace StudentNamesArray
{
    internal class Program
    {
        string message = "hi";
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Hello, World!");

            int nbrStudents = MyConsole.PromptInt("Number of students: ");

            string[] studentArray = new string[nbrStudents];

            NewMethod(studentArray);

            //print array on one line

            //string names = "";
            //foreach (string name in studentArray)
            //{
            //    names += name + "|";
            //}

            //MyConsole.PrintLine(names);

            //foreach (string n in studentArray)
            //{
            //    MyConsole.Print(n + "|");
            //}

            //MyConsole.PrintLine();

            SortAndPrintArray(studentArray);

        }

        private static void NewMethod(string[] studentArray)
        {
            for (int i = 0; i < studentArray.Length; i++)
            {
                string name = MyConsole.PromptString($"Student Name[{i}]: ");
                studentArray[i] = name;
            }
        }

        private static void SortAndPrintArray(string[] studentArray)
        {
            Array.Sort(studentArray);
            Array.ForEach(studentArray, student => Console.Write(student + "|"));
        }
    }
}
