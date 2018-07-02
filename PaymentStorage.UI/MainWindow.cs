using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PaymentStorage.Model;
using PaymentStorage.UI.DataProvider;
using PaymentStorage.UI.ViewModel;

namespace PaymentStorage.UI
{
    public partial class MainWindow : Form
    {
        private PaymentViewModel _viewModel;
        private List<PaymentViewModel> _payments;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {
            _payments = new List<PaymentViewModel>();

            InitResetCaptureControls();
            sbTxCapturedLabel.Text = "Payments: " + _payments.Count.ToString();
            splitContainer.Panel2Collapsed = true;
        }

        private void InitResetCaptureControls()
        {
            txtTxRef.Text = String.Empty;
            txtTxAmount.Text = "00.00";
            cmbCurrency.SelectedIndex = (int)Currency.GBP;
            txtTxSourceAccountNo.Text = String.Empty;
            txtTxDestinationAccountNo.Text = String.Empty;
            dateTimePicker.Text = DateTime.Now.ToString("d");
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (_payments.Count >= 5)
            {
                MessageBox.Show("Max payment records limit is reached!");
                return;
            }

            var isDataOk = ValidateCapturedData();
            if (isDataOk)
                AddToPaymentRecord();
        }

        private void AddToPaymentRecord()
        {
            _viewModel = new PaymentViewModel(new DataServiceProvider());
            _viewModel.Load(null);
            _viewModel.Payment.Id = _payments.Count() + 101;
            _viewModel.Payment.TranasctionReference = txtTxRef.Text;
            _viewModel.Payment.TranasctionAmount = Convert.ToDouble(txtTxAmount.Text);
            _viewModel.Payment.TranasctionCurrency = (Currency)cmbCurrency.SelectedIndex;
            _viewModel.Payment.SourceAccount = txtTxSourceAccountNo.Text;
            _viewModel.Payment.DestinationAccount = txtTxDestinationAccountNo.Text;
            _viewModel.Payment.TransactionDate = dateTimePicker.Value;
            _payments.Add(_viewModel);

            // Track totals rows
            sbTxCapturedLabel.Text = "Payments: " + _payments.Count.ToString();

            // Reset captured data
            InitResetCaptureControls();
        }

        private bool ValidateCapturedData()
        {
            bool isValid = false;
            isValid = !string.IsNullOrEmpty(txtTxRef.Text);
            if (!isValid)
            {
                MessageBox.Show("Invalid Transaction Reference value");
                return false;
            }
                
            double d;
            isValid = double.TryParse(txtTxAmount.Text, out d);
            if (!isValid || d <= 0)
            {
                MessageBox.Show("Invalid Payment Amount");
                return false;
            }

            isValid = Enum.IsDefined(typeof(Currency), cmbCurrency.SelectedIndex);
            if (!isValid)
            {
                MessageBox.Show("Invalid Currency value");
                return false;
            }

            isValid = !string.IsNullOrEmpty(txtTxSourceAccountNo.Text);
            if (!isValid)
            {
                MessageBox.Show("Invalid Source Account");
                return false;
            }

            isValid = !string.IsNullOrEmpty(txtTxDestinationAccountNo.Text);
            if (!isValid)
            {
                MessageBox.Show("Invalid Destination Account");
                return false;
            }

            isValid = DateTime.TryParse(dateTimePicker.Text, out DateTime t);
            if (!isValid)
            {
                MessageBox.Show("Invalid Payment Date");
                return false;
            }

            return true;
        }

        private void btnProcess_Click(object sender, System.EventArgs e)
        {
            //
            if (!rbSortByDate.Checked && !rbSortByAmount.Checked)
            {
                MessageBox.Show("Please select processing order!");
                return;
            }

            // var gridData = _payments.Select(new PaymentViewModel()).OrderBy(p => p.Payment.TranasctionAmount);
            var data = _payments.Select(g => new Payment()
                {
                    Id = g.Payment.Id,
                    TransactionReference =  g.Payment.TranasctionReference,
                    TransactionAmount = g.Payment.TranasctionAmount,
                    TransactionCurrency = g.Payment.TranasctionCurrency,
                    SourceAccountNumber = g.Payment.SourceAccount,
                    DestinationAccountNumber = g.Payment.DestinationAccount,
                    TransactionDate = g.Payment.TransactionDate
                }).ToList();

            List<Payment> gridData;
            if (rbSortByDate.Checked)
                gridData = data.OrderByDescending(g => g.TransactionDate).ToList();
            else
                gridData = data.OrderByDescending(g => g.TransactionAmount).ToList();

            // Bind data to grid and show updated results
            paymentGridView.DataSource = gridData;
            splitContainer.Panel2Collapsed = false;
        }
    }
}
