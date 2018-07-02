using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentStorage.DataAccess;
using PaymentStorage.Model;

namespace PaymentStorage.UI.DataProvider
{
    class DataServiceProvider : IDataServiceProvider
    {
        public IEnumerable<LookupItem> GetAllPayments()
        {
            var dataservice = new FileDataService();
            return dataservice.GetAllPayments();
        }

        public Payment GetPaymentById(int paymentId)
        {
            var dataservice = new FileDataService();
            throw new NotImplementedException();
        }

        public void SavePayment(Payment payment)
        {
            var dataservice = new FileDataService();
            throw new NotImplementedException();
        }

        public void DeletePayment(int paymentId)
        {
            var dataservice = new FileDataService();
            throw new NotImplementedException();
        }
    }
}
