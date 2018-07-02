using PaymentStorage.Model;
using PaymentStorage.UI.ViewModel;
using System;
using System.Runtime.CompilerServices;

namespace PaymentStorage.UI.ViewModel
{
    public class PaymentWrapper : ViewModelBase
    {
        private Payment _payment;
        private bool _isChanged;

        public PaymentWrapper(Payment payment)
        {
            _payment = payment;
        }

        public Payment Model { get { return _payment; } }

        public int Id
        {
            get { return _payment.Id; }
            set
            {
                _payment.Id = value;
                OnPropertyChanged();
            }
        }

        public string TranasctionReference
        {
            get => _payment.TransactionReference;
            set
            {
                _payment.TransactionReference = value;
                OnPropertyChanged();
            }
        }

        public double TranasctionAmount
        {
            get => _payment.TransactionAmount;
            set
            {
                _payment.TransactionAmount = value;
                OnPropertyChanged();
            }
        }

        public Currency TranasctionCurrency
        {
            get => _payment.TransactionCurrency;
            set
            {
                _payment.TransactionCurrency = value;
                OnPropertyChanged();
            }
        }

        public DateTime? TransactionDate
        {
            get => _payment.TransactionDate;
            set
            {
                _payment.TransactionDate = value;
                OnPropertyChanged();
            }
        }

        public string SourceAccount
        {
            get => _payment.SourceAccountNumber;
            set
            {
                _payment.SourceAccountNumber = value;
                OnPropertyChanged();
            }
        }

        public string DestinationAccount
        {
            get => _payment.DestinationAccountNumber;
            set
            {
                _payment.DestinationAccountNumber = value;
                OnPropertyChanged();
            }
        }

        public bool IsChanged
        {
            get => _isChanged;
            private set
            {
                _isChanged = value;
                OnPropertyChanged();
            }
        }

        public void AcceptChanges()
        {
            IsChanged = false;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName != nameof(IsChanged))
            {
                IsChanged = true;
            }
        }
    }
}
