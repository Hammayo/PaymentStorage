using System;
using System.Linq;

namespace PaymentStorage.Model
{
    public class Payment
    {
        public int Id { get; set; }

        public string TransactionReference { get; set; }

        public double TransactionAmount { get; set; }

        public Currency TransactionCurrency { get; set; }

        public DateTime? TransactionDate { get; set; }

        public string SourceAccountNumber { get; set; }

        public string DestinationAccountNumber { get; set; }
    }

    public enum Currency
    {
        GBP,
        EUR,
        USD,
        EGP,
        PKR,
        IRR
    }
}
