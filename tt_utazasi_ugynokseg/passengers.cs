using System.Collections.Generic;

namespace TTUtazasiUgynokseg
{
    public class Passengers
    {
        public List<Trips> trips = new List<Trips>();
        public string PassengerName { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }

        public Passengers(string passengerName, string address, string phoneNumber)
        {
            PassengerName = passengerName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            string places = string.Join(", ", trips.Select(t => t.Destination));
            return $"{PassengerName} is going to {places}";
        }

        public void SignUp(Trips trip)
        {
            trips.Add(trip);
        }

        public void ChangePassengerName(string newName)
        {
            PassengerName = newName;
        }

        public void ChangeAddress(string newAddress)
        {
            Address = newAddress;
        }

        public void ChangePhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
        }
    }
}