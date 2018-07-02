using PaymentStorage.UI.DataProvider;
using PaymentStorage.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PaymentStorage.Model;
using Moq;
using Prism.Events;
using PaymentStorage.UI.Events;

namespace PaymentStorage.UITests.ViewModel
{
  public class NavigationViewModelTests
  {
    private NavigationViewModel _viewModel;
    private PaymentSavedEvent _paymentSavedEvent;
    private PaymentDeletedEvent _paymentDeletedEvent;

    public NavigationViewModelTests()
    {
      _paymentSavedEvent = new PaymentSavedEvent();
      _paymentDeletedEvent = new PaymentDeletedEvent();

      var eventAggregatorMock = new Mock<IEventAggregator>();
      eventAggregatorMock.Setup(ea => ea.GetEvent<PaymentSavedEvent>())
        .Returns(_paymentSavedEvent);
      eventAggregatorMock.Setup(ea => ea.GetEvent<PaymentDeletedEvent>())
        .Returns(_paymentDeletedEvent);

      var navigationDataProviderMock = new Mock<INavigationDataProvider>();
      navigationDataProviderMock.Setup(dp => dp.GetAllPayments())
        .Returns(new List<LookupItem>
        {
          new LookupItem { Id = 1, DisplayMember = "Julia" },
          new LookupItem { Id = 2, DisplayMember = "Hammy" }
       });
      _viewModel = new NavigationViewModel(
        navigationDataProviderMock.Object,
        eventAggregatorMock.Object);
    }

    [Fact]
    public void ShouldLoadFriends()
    {
      _viewModel.Load();

      Assert.Equal(2, _viewModel.Payments.Count);

      var payment = _viewModel.Payments.SingleOrDefault(f => f.Id == 1);
      Assert.NotNull(payment);
      Assert.Equal("Julia", payment.DisplayMember);

      payment = _viewModel.Payments.SingleOrDefault(f => f.Id == 2);
      Assert.NotNull(payment);
      Assert.Equal("Hammy", payment.DisplayMember);
    }

    [Fact]
    public void ShouldLoadFriendsOnlyOnce()
    {
      _viewModel.Load();
      _viewModel.Load();

      Assert.Equal(2, _viewModel.Payments.Count);
    }

    [Fact]
    public void ShouldUpdateNavigationItemWhenFriendIsSaved()
    {
      _viewModel.Load();
      var navigationItem = _viewModel.Payments.First();

      var paymentId = navigationItem.Id;

      _paymentSavedEvent.Publish(
        new Payment
        {
          Id = paymentId,
          SourceAccountNumber = "Anna",
          DestinationAccountNumber = "Babar"
        });

      Assert.Equal("Anna Babar", navigationItem.DisplayMember);
    }

    [Fact]
    public void ShouldAddNavigationItemWhenAddedFriendIsSaved()
    {
      _viewModel.Load();

      const int newPaymentId = 97;

      _paymentSavedEvent.Publish(new Payment
      {
        Id = newPaymentId,
        SourceAccountNumber = "Anna",
        DestinationAccountNumber = "Babar"
      });

      Assert.Equal(3, _viewModel.Payments.Count);

      var addedItem = _viewModel.Payments.SingleOrDefault(f => f.Id == newPaymentId);
      Assert.NotNull(addedItem);
      Assert.Equal("Anna Babar", addedItem.DisplayMember);
    }

    [Fact]
    public void ShouldRemoveNavigationItemWhenFriendIsDeleted()
    {
      _viewModel.Load();

      var deletedPaymentId = _viewModel.Payments.First().Id;

      _paymentDeletedEvent.Publish(deletedPaymentId);

      Assert.Equal(1, _viewModel.Payments.Count);
      Assert.NotEqual(deletedPaymentId, _viewModel.Payments.Single().Id);
    }
  }
}
