using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using PaymentStorage.Model;

namespace PaymentStorage.DataAccess
{
    public class FileDataService : IDataService
    {
        private const string StorageFile = "_payment-store.json";

        public Payment GetPaymentById(int paymentId)
        {
            var friends = ReadFromFile();
            return friends.Single(f => f.Id == paymentId);
        }

        public void SavePayment(Payment payment)
        {
            if (payment.Id <= 0)
                InsertPayment(payment);
            else
                UpdatePayment(payment);
        }

        public void DeletePayment(int paymentId)
        {
            var payments = ReadFromFile();
            var existing = payments.Single(f => f.Id == paymentId);
            payments.Remove(existing);
            SaveToFile(payments);
        }

        private void UpdatePayment(Payment payment)
        {
            var payments = ReadFromFile();
            var existing = payments.Single(f => f.Id == payment.Id);
            var indexOfExisting = payments.IndexOf(existing);
            payments.Insert(indexOfExisting, payment);
            payments.Remove(existing);
            SaveToFile(payments);
        }

        private void InsertPayment(Payment payment)
        {
            var payments = ReadFromFile();
            var maxPaymentId = payments.Count == 0 ? 0 : payments.Max(f => f.Id);
            payment.Id = maxPaymentId + 1;
            payments.Add(payment);
            SaveToFile(payments);
        }

        public IEnumerable<LookupItem> GetAllPayments()
        {
            return ReadFromFile()
              .Select(p => new LookupItem
              {
                  Id = p.Id,
                  DisplayMember = $"{p.TransactionReference}: {p.SourceAccountNumber} -> {p.DestinationAccountNumber}"
              });
        }

        private void SaveToFile(List<Payment> paymentList)
        {
            string json = JsonConvert.SerializeObject(paymentList, Formatting.Indented);
            File.WriteAllText(StorageFile, json);
        }

        private List<Payment> ReadFromFile()
        {
            if (!File.Exists(StorageFile))
            {
                // Generate stub data
                var file = new List<Payment>
                {
                    new Payment
                    {
                        Id = 1,
                        TransactionReference = "Hammy Babar",
                        SourceAccountNumber = "1051",
                        DestinationAccountNumber = "2001",
                        TransactionCurrency = Currency.EUR,
                        TransactionAmount = 3600.00,
                        TransactionDate = new DateTime(2017, 12, 29)
                    },
                    new Payment
                    {
                        Id = 2,
                        TransactionReference = "Julia Red",
                        SourceAccountNumber = "2051",
                        DestinationAccountNumber = "3001",
                        TransactionCurrency = Currency.USD,
                        TransactionAmount = 3250.00,
                        TransactionDate = new DateTime(2018, 03, 13)
                    },
                    new Payment
                    {
                        Id = 3,
                        TransactionReference = "Anna Cortana",
                        SourceAccountNumber = "3051",
                        DestinationAccountNumber = "4001",
                        TransactionCurrency = Currency.GBP,
                        TransactionAmount = 3875.00,
                        TransactionDate = new DateTime(2018, 02, 17)
                    },
                    new Payment
                    {
                        Id = 4,
                        TransactionReference = "Sara Bay",
                        SourceAccountNumber = "4051",
                        DestinationAccountNumber = "5001",
                        TransactionCurrency = Currency.PKR,
                        TransactionAmount = 2935.00,
                        TransactionDate = new DateTime(2018, 04, 25)
                    },
                    new Payment
                    {
                        Id = 5,
                        TransactionReference = "Mariam Shaz",
                        SourceAccountNumber = "5051",
                        DestinationAccountNumber = "6001",
                        TransactionCurrency = Currency.GBP,
                        TransactionAmount = 4335.00,
                        TransactionDate = new DateTime(2018, 03, 30)
                    }
                };

                return file;
            }

            string json = File.ReadAllText(StorageFile);
            return JsonConvert.DeserializeObject<List<Payment>>(json);
        }

        public void Dispose()
        {
            
        }
    }
}
