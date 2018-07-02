using PaymentStorage.Model;
using PaymentStorage.UI.DataProvider;
using PaymentStorage.UI.Dialogs;
using PaymentStorage.UI.Events;
using PaymentStorage.UI.ViewModel;
using PaymentStorage.UITests.Extensions;
using Moq;
using Prism.Events;
using Xunit;

namespace PaymentStorage.UITests.ViewModel
{
    public class PaymentEditViewModelTests
    {
        private const int _paymentId = 5;
        private Mock<IPaymentTxDataProvider> _dataProviderMock;
        private PaymentEditViewModel _viewModel;
        private Mock<PaymentSavedEvent> _paymentSavedEventMock;
        private Mock<IEventAggregator> _eventAggregatorMock;
        private Mock<PaymentDeletedEvent> _paymentDeletedEventMock;
        private Mock<IMessageDialogService> _messageDialogServiceMock;

        public PaymentEditViewModelTests()
        {
            _paymentDeletedEventMock = new Mock<PaymentDeletedEvent>();
            _paymentSavedEventMock = new Mock<PaymentSavedEvent>();

            _eventAggregatorMock = new Mock<IEventAggregator>();
            _eventAggregatorMock.Setup(ea => ea.GetEvent<PaymentSavedEvent>())
              .Returns(_paymentSavedEventMock.Object);
            _eventAggregatorMock.Setup(ea => ea.GetEvent<PaymentDeletedEvent>())
              .Returns(_paymentDeletedEventMock.Object);

            _dataProviderMock = new Mock<IPaymentTxDataProvider>();
            _dataProviderMock.Setup(dp => dp.GetPaymentTxById(_paymentId))
              .Returns(new Payment { Id = _paymentId, SourceAccountNumber = "Hammy" });

            _messageDialogServiceMock = new Mock<IMessageDialogService>();

            _viewModel = new PaymentEditViewModel(_dataProviderMock.Object,
              _eventAggregatorMock.Object,
              _messageDialogServiceMock.Object);
        }

        [Fact]
        public void ShouldLoadFriend()
        {
            _viewModel.Load(_paymentId);

            Assert.NotNull(_viewModel.Payment);
            Assert.Equal(_paymentId, _viewModel.Payment.Id);

            _dataProviderMock.Verify(dp => dp.GetPaymentTxById(_paymentId), Times.Once);
        }

        [Fact]
        public void ShouldRaisePropertyChangedEventForFriend()
        {
            var fired = _viewModel.IsPropertyChangedFired(
              () => _viewModel.Load(_paymentId),
              nameof(_viewModel.Payment));

            Assert.True(fired);
        }

        [Fact]
        public void ShouldDisableSaveCommandWhenFriendIsLoaded()
        {
            _viewModel.Load(_paymentId);

            Assert.False(_viewModel.SaveCommand.CanExecute(null));
        }

        [Fact]
        public void ShouldEnableSaveCommandWhenFriendIsChanged()
        {
            _viewModel.Load(_paymentId);

            _viewModel.Payment.SourceAccount = "Changed";

            Assert.True(_viewModel.SaveCommand.CanExecute(null));
        }

        [Fact]
        public void ShouldDisableSaveCommandWithoutLoad()
        {
            Assert.False(_viewModel.SaveCommand.CanExecute(null));
        }

        [Fact]
        public void ShouldRaiseCanExecuteChangedForSaveCommandWhenFriendIsChanged()
        {
            _viewModel.Load(_paymentId);
            var fired = false;
            _viewModel.SaveCommand.CanExecuteChanged += (s, e) => fired = true;
            _viewModel.Payment.SourceAccount = "Changed";
            Assert.True(fired);
        }

        [Fact]
        public void ShouldRaiseCanExecuteChangedForSaveCommandAfterLoad()
        {
            var fired = false;
            _viewModel.SaveCommand.CanExecuteChanged += (s, e) => fired = true;
            _viewModel.Load(_paymentId);
            Assert.True(fired);
        }

        [Fact]
        public void ShouldRaiseCanExecuteChangedForDeleteCommandAfterLoad()
        {
            var fired = false;
            _viewModel.DeleteCommand.CanExecuteChanged += (s, e) => fired = true;
            _viewModel.Load(_paymentId);
            Assert.True(fired);
        }

        [Fact]
        public void ShouldRaiseCanExecuteChangedForDeleteCommandWhenAcceptingChanges()
        {
            _viewModel.Load(_paymentId);
            var fired = false;
            _viewModel.Payment.SourceAccount = "Changed";
            _viewModel.DeleteCommand.CanExecuteChanged += (s, e) => fired = true;
            _viewModel.Payment.AcceptChanges();
            Assert.True(fired);
        }

        [Fact]
        public void ShouldCallSaveMethodOfDataProviderWhenSaveCommandIsExecuted()
        {
            _viewModel.Load(_paymentId);
            _viewModel.Payment.SourceAccount = "Changed";

            _viewModel.SaveCommand.Execute(null);
            _dataProviderMock.Verify(dp => dp.SavePaymentTx(_viewModel.Payment.Model), Times.Once);
        }

        [Fact]
        public void ShouldAcceptChangesWhenSaveCommandIsExecuted()
        {
            _viewModel.Load(_paymentId);
            _viewModel.Payment.SourceAccount = "Changed";

            _viewModel.SaveCommand.Execute(null);
            Assert.False(_viewModel.Payment.IsChanged);
        }

        [Fact]
        public void ShouldPublishFriendSavedEventWhenSaveCommandIsExecuted()
        {
            _viewModel.Load(_paymentId);
            _viewModel.Payment.SourceAccount = "Changed";

            _viewModel.SaveCommand.Execute(null);
            _paymentSavedEventMock.Verify(e => e.Publish(_viewModel.Payment.Model), Times.Once);
        }

        [Fact]
        public void ShouldCreateNewFriendWhenNullIsPassedToLoadMethod()
        {
            _viewModel.Load(null);

            Assert.NotNull(_viewModel.Payment);
            Assert.Equal(0, _viewModel.Payment.Id);
            Assert.Null(_viewModel.Payment.SourceAccount);
            Assert.Null(_viewModel.Payment.DestinationAccount);
            Assert.Null(_viewModel.Payment.TransactionDate);
            Assert.False(_viewModel.Payment.IsDebitPayment);

            _dataProviderMock.Verify(dp => dp.GetPaymentTxById(It.IsAny<int>()), Times.Never);
        }

        [Fact]
        public void ShouldEnableDeleteCommandForExistingFriend()
        {
            _viewModel.Load(_paymentId);
            Assert.True(_viewModel.DeleteCommand.CanExecute(null));
        }

        [Fact]
        public void ShouldDisableDeleteCommandForNewFriend()
        {
            _viewModel.Load(null);
            Assert.False(_viewModel.DeleteCommand.CanExecute(null));
        }

        [Fact]
        public void ShouldDisableDeleteCommandWithoutLoad()
        {
            Assert.False(_viewModel.DeleteCommand.CanExecute(null));
        }

        [Theory]
        [InlineData(MessageDialogResult.Yes, 1)]
        [InlineData(MessageDialogResult.No, 0)]
        public void ShouldCallDeleteFriendWhenDeleteCommandIsExecuted(
          MessageDialogResult result, int expectedDeleteFriendCalls)
        {
            _viewModel.Load(_paymentId);

            _messageDialogServiceMock.Setup(ds => ds.ShowYesNoDialog(It.IsAny<string>(),
              It.IsAny<string>())).Returns(result);

            _viewModel.DeleteCommand.Execute(null);

            _dataProviderMock.Verify(dp => dp.DeletePaymentTx(_paymentId),
              Times.Exactly(expectedDeleteFriendCalls));
            _messageDialogServiceMock.Verify(ds => ds.ShowYesNoDialog(It.IsAny<string>(),
              It.IsAny<string>()), Times.Once);
        }

        [Theory]
        [InlineData(MessageDialogResult.Yes, 1)]
        [InlineData(MessageDialogResult.No, 0)]
        public void ShouldPublishFriendDeletedEventWhenDeleteCommandIsExecuted(
          MessageDialogResult result, int expectedPublishCalls)
        {
            _viewModel.Load(_paymentId);

            _messageDialogServiceMock.Setup(ds => ds.ShowYesNoDialog(It.IsAny<string>(),
             It.IsAny<string>())).Returns(result);

            _viewModel.DeleteCommand.Execute(null);

            _paymentDeletedEventMock.Verify(e => e.Publish(_paymentId),
              Times.Exactly(expectedPublishCalls));

            _messageDialogServiceMock.Verify(ds => ds.ShowYesNoDialog(It.IsAny<string>(),
             It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void ShouldDisplayCorrectMessageInDeleteDialog()
        {
            _viewModel.Load(_paymentId);

            var f = _viewModel.Payment;
            f.SourceAccount = "Hammy";
            f.DestinationAccount = "Babar";

            _viewModel.DeleteCommand.Execute(null);

            _messageDialogServiceMock.Verify(d => d.ShowYesNoDialog("Delete Payment",
              $"Do you really want to delete this payment transaction '{f.SourceAccount} {f.DestinationAccount}'"),
              Times.Once);
        }
    }
}
