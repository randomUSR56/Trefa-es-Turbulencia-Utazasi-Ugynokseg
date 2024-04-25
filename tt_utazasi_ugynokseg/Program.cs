using System;

namespace TTUtazasiUgynokseg
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Clear();

            Trips Barcelona = new Trips("Barcelona", 40000, 12);
            Passengers John = new Passengers("John Doe", "Baker 2", "123456789");

            John.SignUp(Barcelona);

            System.Console.WriteLine(John);

            bool exit = false;
            while (!exit)
            {
                System.Console.WriteLine("\nWelcome to TT Utazasi Ugynokseg!\n");
                System.Console.WriteLine("Please select an option:");
                System.Console.WriteLine("1. View Trip Details");
                System.Console.WriteLine("2. View Passenger Details");
                System.Console.WriteLine("3. Exit\n");

                string userInput = System.Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        System.Console.WriteLine("\n--- Trip Details ---");
                        System.Console.WriteLine(Barcelona);
                        System.Console.WriteLine("--------------------\n");
                        break;
                    case "2":
                        System.Console.WriteLine("\n--- Passenger Details ---");
                        System.Console.WriteLine(John);
                        System.Console.WriteLine("-------------------------\n");
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        System.Console.WriteLine("\nInvalid option. Please try again.\n");
                        break;
                }
            }
        }
    }
}