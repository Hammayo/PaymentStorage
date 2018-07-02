using System;
using System.Collections.Generic;
using PaymentStorage.Model;

namespace PaymentStorage.UI.DataProvider
{
    public interface IDataServiceProvider
    {
        IEnumerable<LookupItem> GetAllPayments();

        Payment GetPaymentById(int paymentId);

        void SavePayment(Payment payment);

        void DeletePayment(int paymentId);
    }
}
