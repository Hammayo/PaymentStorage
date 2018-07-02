using System.ComponentModel;
using PaymentStorage.Model;
using PaymentStorage.UI.DataProvider;

namespace PaymentStorage.UI.ViewModel
{
    public interface IPaymentViewModel
    {
        void Load(int? paymentId);
        PaymentWrapper Payment { get; }
    }

    class PaymentViewModel : ViewModelBase, IPaymentViewModel
    {
        private IDataServiceProvider _dataProvider;
        private PaymentWrapper _payment;

        public PaymentViewModel(IDataServiceProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public PaymentWrapper Payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged();
            }
        }

        public void Load(int? paymentId)
        {
            var payment = paymentId.HasValue ? _dataProvider.GetPaymentById(paymentId.Value) : new Payment();
            Payment = new PaymentWrapper(payment);
            // Payment.PropertyChanged += Payment_PropertyChanged;
        }

        private void Payment_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }
    }
}
