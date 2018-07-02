using System;
using System.Collections.Generic;
using PaymentStorage.Model;

namespace PaymentStorage.DataAccess
{
    public interface IDataService : IDisposable
    {
        IEnumerable<LookupItem> GetAllPayments();

        Payment GetPaymentById(int paymentId);

        void SavePayment(Payment payment);

        void DeletePayment(int paymentId);
    }
}
