namespace CH05Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //p 139 relational operators
            int a = 5;
            int b = 5;
            Console.WriteLine(a == b);

            //comparing strings
            string name1 = "Bob";
            string name2 = "Bob";
            Console.WriteLine(name1 == name2);

            //p. 141 logical operators
            //is sky blue and is temp above 74?
            int temp = 76;
            string color = "blue";

            if (color == "blue" & temp > 74)
            {
                Console.WriteLine("sky is blue and above 74");
            }





            //p. 143 nested if - traffic light
            //simple r, y, g
            //yellow light rules:
            //dist <20yd --> go
            //dist>20yd && dist<30yd --> speed up
            //dist >= 30yd--> slow down
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Light color? (r,y,g): ");
                string lightColor = Console.ReadLine();
                if (lightColor == "r")
                {
                    Console.WriteLine("Stop!");
                }
                else if (lightColor == "y")
                {
                    Console.Write("distance to light in yd? ");
                    int dist = Convert.ToInt32(Console.ReadLine());
                    string msg = "";
                    if (dist < 20)
                    {
                        msg = "Go!";
                    }
                    else if (dist < 30)
                    {
                        msg = "Hurry, GO!";
                    }
                    else
                    {
                        msg = "Stop!";
                    }
                    Console.WriteLine(msg);

                }
                else if (lightColor == "g")
                {
                    Console.WriteLine("Go!");
                }
                else Console.WriteLine("invalid light color: " + lightColor);


                Console.WriteLine("continue? ");
                choice = Console.ReadLine();
            }

            //p. 145 switch statement
            // CRUD operations
            Console.WriteLine("Movie table - which action to perform? ");
            string action = "";
            while (action != "exit pleaseeeee")
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("============");
                Console.WriteLine("Get : Get All Movies ");
                Console.WriteLine("GID : Get Movie by ID ");
                Console.WriteLine("Add : Add Movie ");
                Console.WriteLine("Upd : Update Movie ");
                Console.WriteLine("Del : Delete Movie ");
                Console.WriteLine("Ext : Exit ");
                Console.Write("Action: ");
                action = Console.ReadLine().ToLower();

                switch (action) 
                {
                    case "get":
                        Console.WriteLine("Get was selected");
                        break;
                    case "gid":
                        Console.WriteLine("GID was selected");
                        break;
                    case "add":
                        Console.WriteLine("Add was selected");
                        break;
                    case "upd":
                        Console.WriteLine("Upd was selected");
                        break;
                    case "del":
                        Console.WriteLine("Del was selected");
                        break;
                    case "ext":
                        Console.WriteLine("Are you sure?\n Type exit to really exit");
                        break;
                    case "exit":
                        Console.WriteLine("Are you sure you're sure?\n Type EXIT PLEASEEEEE if that's what you really want");
                        break;
                    default:
                        Console.WriteLine("Invalid selection - " + action);
                        break;
                }
            }

            //p. 147 case w/arrow operators
            //customer type: discountPct
            //"R" - 10%
            //"C" - 20%
            //else - 0%
            string custType = "R";
            decimal discPct = 0.0m;

            discPct = custType switch
            {
                "R" => .1m,
                "C" => .2m,
                _ => .0m
            };
            Console.WriteLine("discPct = " + discPct);

            //p. 151 conditional expression / ternary operator
            //day of week: weekday/weekend conversion
            //day is 1-5: weekday, 6 or 7, weekend
            //int dow = 4;
            //string msg = "";
            //if (dow <= 5)
            //{
            //    msg = "weekday";
            //}
            //else
            //{
            //    msg = "weekend";
            //}


            //as conditional expr, from the 'if' onwards
            int dow = 4;
            string msg1 = (dow <= 5) ? "weekday" : "weekend";
            Console.WriteLine(msg1);










            Console.WriteLine("Bye!");
        }
    }
}
