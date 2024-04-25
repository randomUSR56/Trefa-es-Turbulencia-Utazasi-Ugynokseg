using System;

namespace TTUtazasiUgynokseg
{
    public class Payment
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public Trips Trip { get; set; }

        public Payment(decimal amount, Trips trip)
        {
            Amount = amount;
            Date = DateTime.Now;
            Trip = trip;
        }
    }
}