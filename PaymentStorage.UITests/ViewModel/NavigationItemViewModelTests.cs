using PaymentStorage.UI.Events;
using PaymentStorage.UI.ViewModel;
using Moq;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PaymentStorage.UITests.Extensions;

namespace PaymentStorage.UITests.ViewModel
{
    public class NavigationItemViewModelTests
    {
        const int _paymentId = 7;
        private Mock<IEventAggregator> _eventAggregatorMock;
        private NavigationItemViewModel _viewModel;

        public NavigationItemViewModelTests()
        {
            _eventAggregatorMock = new Mock<IEventAggregator>();

            _viewModel = new NavigationItemViewModel(_paymentId,
              "Hammy", _eventAggregatorMock.Object);
        }
        [Fact]
        public void ShouldPublishOpenFriendEditViewEvent()
        {
            var eventMock = new Mock<OpenPaymentEditViewEvent>();
            _eventAggregatorMock
              .Setup(ea => ea.GetEvent<OpenPaymentEditViewEvent>())
              .Returns(eventMock.Object);

            _viewModel.OpenPaymentEditViewCommand.Execute(null);

            eventMock.Verify(e => e.Publish(_paymentId), Times.Once);
        }

        [Fact]
        public void ShouldRaisePropertyChangedEventForDisplayMember()
        {
            var fired = _viewModel.IsPropertyChangedFired(() =>
            {
                _viewModel.DisplayMember = "Changed";
            }, nameof(_viewModel.DisplayMember));

            Assert.True(fired);
        }
    }
}
