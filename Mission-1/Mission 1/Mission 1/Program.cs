using System;

namespace Mission_1
{
    class Program
    {
        static void Main(string[] args)
        {
            greetings();
        }
        public static void greetings()
        {
            string greeting;

            Console.WriteLine("Welcome, Please pick a greeting. Press the number of which one you want and hit enter.");
            Console.WriteLine("Greeting 1");
            Console.WriteLine("Greeting 2");
            Console.WriteLine("Greeting 3");
            Console.WriteLine("Which Greeting would you like: ");
            greeting = Console.ReadLine().ToLower();
            Console.Clear();

            switch (greeting)
            {
                case "1":
                case "greeting 1":
                case "one":
                    {
                        Console.WriteLine("Welll how do you do?");
                        Console.ReadLine();
                        done();
                        break;
                    }
                case "2":
                case "greeting 2":
                case "two":
                    {
                        Console.WriteLine("Top of the mornin to ya!");
                        Console.ReadLine();
                        done();
                        break;
                    }
                case "3":
                case "greeting 3":
                case "three":
                    {
                        Console.WriteLine("Welcome...Welcome... Come on in.");
                        Console.ReadLine();
                        done();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        greetings();
                        break;
                    }

            }
        }
            public static void done()
        {
            Console.WriteLine("Hope you liked your greeting.");
            Console.WriteLine("If you want a different one,");
            Console.WriteLine("Hit 'Enter' and make a different choice.");
            Console.ReadLine();
            Console.Clear();
            greetings();
        }
    }
}
