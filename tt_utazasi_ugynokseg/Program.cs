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
        }
    }
}