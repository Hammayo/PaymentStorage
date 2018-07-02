using System;
using PaymentStorage.UI.ViewModel;
using Xunit;
using Moq;
using Prism.Events;
using PaymentStorage.UI.Events;
using System.Collections.Generic;
using System.Linq;
using PaymentStorage.Model;
using PaymentStorage.UITests.Extensions;
using PaymentStorage.UI.Wrapper;

namespace PaymentStorage.UITests.ViewModel
{
    public class MainViewModelTests
    {
        private Mock<INavigationViewModel> _navigationViewModelMock;
        private MainViewModel _viewModel;
        private Mock<IEventAggregator> _eventAggregatorMock;
        private OpenPaymentEditViewEvent _openPaymentEditViewEvent;
        private List<Mock<IPaymentEditViewModel>> _paymentEditViewModelMocks;
        private PaymentDeletedEvent _paymentDeletedEvent;

        public MainViewModelTests()
        {
            _paymentEditViewModelMocks = new List<Mock<IPaymentEditViewModel>>();
            _navigationViewModelMock = new Mock<INavigationViewModel>();

            _openPaymentEditViewEvent = new OpenPaymentEditViewEvent();
            _paymentDeletedEvent = new PaymentDeletedEvent();
            _eventAggregatorMock = new Mock<IEventAggregator>();
            _eventAggregatorMock.Setup(ea => ea.GetEvent<OpenPaymentEditViewEvent>())
              .Returns(_openPaymentEditViewEvent);
            _eventAggregatorMock.Setup(ea => ea.GetEvent<PaymentDeletedEvent>())
              .Returns(_paymentDeletedEvent);

            _viewModel = new MainViewModel(_navigationViewModelMock.Object,
              CreateFriendEditViewModel, _eventAggregatorMock.Object);
        }

        private IPaymentEditViewModel CreateFriendEditViewModel()
        {
            var friendEditViewModelMock = new Mock<IPaymentEditViewModel>();
            friendEditViewModelMock.Setup(vm => vm.Load(It.IsAny<int>()))
              .Callback<int?>(paymentId =>
              {
                  friendEditViewModelMock.Setup(vm => vm.Payment)
            .Returns(new PaymentWrapper(new Payment { Id = paymentId.Value }));
              });
            _paymentEditViewModelMocks.Add(friendEditViewModelMock);
            return friendEditViewModelMock.Object;
        }

        [Fact]
        public void ShouldCallTheLoadMethodOfTheNavigationViewModel()
        {
            _viewModel.Load();

            _navigationViewModelMock.Verify(vm => vm.Load(), Times.Once);
        }

        [Fact]
        public void ShouldAddFriendEditViewModelAndLoadAndSelectIt()
        {
            const int paymentId = 7;
            _openPaymentEditViewEvent.Publish(paymentId);

            Assert.Equal(1, _viewModel.PaymentEditViewModels.Count);
            var paymentEditVm = _viewModel.PaymentEditViewModels.First();
            Assert.Equal(paymentEditVm, _viewModel.SelectedPaymentEditViewModel);
            _paymentEditViewModelMocks.First().Verify(vm => vm.Load(paymentId), Times.Once);
        }

        [Fact]
        public void ShouldAddFriendEditViewModelAndLoadItWithIdNullAndSelectIt()
        {
            _viewModel.AddPaymentCommand.Execute(null);

            Assert.Equal(1, _viewModel.PaymentEditViewModels.Count);
            var paymentEditVm = _viewModel.PaymentEditViewModels.First();
            Assert.Equal(paymentEditVm, _viewModel.SelectedPaymentEditViewModel);
            _paymentEditViewModelMocks.First().Verify(vm => vm.Load(null), Times.Once);
        }

        [Fact]
        public void ShouldAddFriendEditViewModelsOnlyOnce()
        {
            _openPaymentEditViewEvent.Publish(5);
            _openPaymentEditViewEvent.Publish(5);
            _openPaymentEditViewEvent.Publish(6);
            _openPaymentEditViewEvent.Publish(7);
            _openPaymentEditViewEvent.Publish(7);

            Assert.Equal(3, _viewModel.PaymentEditViewModels.Count);
        }

        [Fact]
        public void ShouldRaisePropertyChangedEventForSelectedFriendEditViewModel()
        {
            var paymentEditVmMock = new Mock<IPaymentEditViewModel>();
            var fired = _viewModel.IsPropertyChangedFired(() =>
            {
                _viewModel.SelectedPaymentEditViewModel = paymentEditVmMock.Object;
            }, nameof(_viewModel.SelectedPaymentEditViewModel));

            Assert.True(fired);
        }

        [Fact]
        public void ShouldRemoveFriendEditViewModelOnCloseFriendTabCommand()
        {
            _openPaymentEditViewEvent.Publish(7);

            var paymentEditVm = _viewModel.SelectedPaymentEditViewModel;

            _viewModel.ClosePaymentTabCommand.Execute(paymentEditVm);

            Assert.Equal(0, _viewModel.PaymentEditViewModels.Count);
        }

        [Fact]
        public void ShouldRemoveFriendEditViewModelOnFriendDeletedEvent()
        {
            const int deletedPaymentId = 7;

            _openPaymentEditViewEvent.Publish(deletedPaymentId);
            _openPaymentEditViewEvent.Publish(8);
            _openPaymentEditViewEvent.Publish(9);

            _paymentDeletedEvent.Publish(deletedPaymentId);

            Assert.Equal(2, _viewModel.PaymentEditViewModels.Count);
            Assert.True(_viewModel.PaymentEditViewModels.All(vm => vm.Payment.Id != deletedPaymentId));
        }
    }
}
