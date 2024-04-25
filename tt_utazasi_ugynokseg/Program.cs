using System;

namespace TTUtazasiUgynokseg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Passengers> passengers = new List<Passengers>();
            List<Trips> listTrips = new List<Trips>();

            System.Console.Clear();

            Trips Barcelona = new Trips("Barcelona", 40000, 12);
            Passengers John = new Passengers("John Doe", "Baker 2", "123456789");
            passengers.Add(John);

            John.SignUp(Barcelona);

            //System.Console.WriteLine(John);

            John.MakePayment(20000, Barcelona);

            bool exit = false;
            while (!exit)
            {
                System.Console.WriteLine("\nWelcome to TT Utazasi Ugynokseg!\n");
                System.Console.WriteLine("Please select an option:");
                System.Console.WriteLine("1. View Trip Details");
                System.Console.WriteLine("2. View Passenger Details");
                System.Console.WriteLine("3. Create Payment Advance");
                System.Console.WriteLine("4. Create New Passenger");
                System.Console.WriteLine("5. Create New Trip");
                System.Console.WriteLine("6. Delete Passenger");
                System.Console.WriteLine("7. Modify Payment Advance");
                System.Console.WriteLine("8. Modify Passenger Details");
                System.Console.WriteLine("9. Sign up");
                System.Console.WriteLine("10, Exit\n");

                string userInput = System.Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                    System.Console.WriteLine("\n--- Trip Details ---");
                    System.Console.WriteLine("\nEnter the index of the trip:");
                    int tripIndex = int.Parse(System.Console.ReadLine()) - 1;
                    Trips chosenTrip = listTrips[tripIndex];
                    System.Console.WriteLine(chosenTrip);
                    System.Console.WriteLine("--------------------\n");
                    break;
                    case "2":
                        System.Console.WriteLine("\n--- Passenger Details ---");
                        System.Console.WriteLine("\nEnter the index of the passenger:");
                        int PassengerIndex = int.Parse(System.Console.ReadLine()) - 1;
                        Passengers chosenPassenger = passengers[PassengerIndex];
                        System.Console.WriteLine(chosenPassenger);
                        System.Console.WriteLine("-------------------------\n");
                        break;
                    case "3":
                        System.Console.WriteLine("\nEnter the amount for the payment advance:");
                        decimal amount = decimal.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("\nEnter the index of the passenger:");
                        PassengerIndex = int.Parse(System.Console.ReadLine()) - 1;
                        chosenPassenger = passengers[PassengerIndex];
                        System.Console.WriteLine("\nEnter the index of the trip:");
                        tripIndex = int.Parse(System.Console.ReadLine()) - 1;
                        chosenTrip = listTrips[tripIndex];
                        chosenPassenger.MakePayment(amount, chosenTrip);
                        System.Console.WriteLine("\nPayment advance created successfully!\n");
                        break;
                    case "4":
                        System.Console.WriteLine("\nEnter the name for the new passenger:");
                        string name = System.Console.ReadLine();
                        System.Console.WriteLine("Enter the address for the new passenger:");
                        string address = System.Console.ReadLine();
                        System.Console.WriteLine("Enter the phone number for the new passenger:");
                        string phoneNumber = System.Console.ReadLine();
                        Passengers newPassenger = new Passengers(name, address, phoneNumber);
                        passengers.Add(newPassenger);
                        System.Console.WriteLine("\nNew passenger created successfully!\n");
                        break;
                    case "5":
                        System.Console.WriteLine("\nEnter the destination for the new trip:");
                        string destination = System.Console.ReadLine();
                        System.Console.WriteLine("\nEnter the price for the new trip:");
                        int price = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("\nEnter the maximum number of passengers for the new trip:");
                        int maxPassengers = int.Parse(System.Console.ReadLine());
                        Trips newTrip = new Trips(destination, price, maxPassengers);
                        listTrips.Add(newTrip);
                        System.Console.WriteLine("\nNew trip created successfully!\n");
                        break;
                    case "6":
                        exit = false;
                        break;
                    case "7":
                        System.Console.WriteLine("\nEnter the index of the payment advance you want to modify:");
                        int index = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("Enter the new amount for the payment advance:");
                        decimal newAmount = decimal.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("\nEnter the index of the passenger:");
                        PassengerIndex = int.Parse(System.Console.ReadLine()) - 1;
                        chosenPassenger = passengers[PassengerIndex];
                        chosenPassenger.Payments[index].Amount = newAmount;
                        System.Console.WriteLine("\nPayment advance modified successfully!\n");
                        break;
                    case "8":
                        System.Console.WriteLine("\nEnter the index of the passenger:");
                        PassengerIndex = int.Parse(System.Console.ReadLine()) - 1;
                        chosenPassenger = passengers[PassengerIndex];
                        System.Console.WriteLine("\nEnter the new name for the passenger:");
                        string newName = System.Console.ReadLine();
                        System.Console.WriteLine("Enter the new address for the passenger:");
                        string newAddress = System.Console.ReadLine();
                        System.Console.WriteLine("Enter the new phone number for the passenger:");
                        string newPhoneNumber = System.Console.ReadLine();

                        chosenPassenger.ChangePassengerName(newName);
                        chosenPassenger.ChangeAddress(newAddress);
                        chosenPassenger.ChangePhoneNumber(newPhoneNumber);

                        System.Console.WriteLine("\nPassenger details modified successfully!\n");
                        break;
                    case "9":
                        System.Console.WriteLine("\nEnter the index of the passenger:");
                        PassengerIndex = int.Parse(System.Console.ReadLine()) - 1;
                        chosenPassenger = passengers[PassengerIndex];
                        System.Console.WriteLine("\nEnter the index of the trip:");
                        tripIndex = int.Parse(System.Console.ReadLine()) - 1;
                        chosenTrip = listTrips[tripIndex];
                        chosenPassenger.SignUp(chosenTrip);
                        System.Console.WriteLine("\nPassenger signed up for the trip successfully!\n");
                        break;
                    case "10":
                        using (StreamWriter writer = new StreamWriter("output.txt"))
                        {
                            writer.WriteLine("--- Passengers ---");
                            foreach (Passengers passenger in passengers)
                            {
                                writer.WriteLine(passenger);
                            }

                            writer.WriteLine("--- Trips ---");
                            foreach (Trips trip in listTrips)
                            {
                                writer.WriteLine(trip);
                            }
                        }
                        System.Console.WriteLine("\nInformation written to output.txt successfully!\n");
                        exit = true;
                        break;
                }
            }
        }
    }
}