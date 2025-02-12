using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Numerics;

namespace MurachsCh2HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The user’s full name consists of the user’s first name, a space, and the user’s last
            //name. The temporary password consists of the user’s first name, an asterisk(*), and the
            // Assume that the user will enter a valid 4 - digit integer for the year.
            Console.WriteLine("Hello, World!");

            //prompt for user's firstName, lastName and birthyear

            Console.WriteLine("Enter your firstName: ");
            string firstName = Console.ReadLine();
            

            Console.WriteLine("Enter your lastName: ");
            string lastName = Console.ReadLine();
                

            Console.WriteLine("Enter your birthYear: ");
            string birthYear = Console.ReadLine();
            Console.WriteLine("Welcome " + (firstName + ' ' + lastName));
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + (firstName + '*' + birthYear));
          


            
            Console.WriteLine("Bye!");
        }
    }
}
