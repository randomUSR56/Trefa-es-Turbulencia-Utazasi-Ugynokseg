namespace TTUtazasiUgynokseg
{
    public class Trips
    {
        public string Destination { get; private set; }
        public int Price { get; private set; }
        public int MaxPassengers { get; private set; }

        public Trips(string destination, int price, int maxPassengers)
        {
            Destination = destination;
            Price = price;
            MaxPassengers = maxPassengers;
        }

        public override string ToString()
        {
            return $"Destination: {Destination}, Price: {Price}, Max Passengers: {MaxPassengers}";
        }
    }
}