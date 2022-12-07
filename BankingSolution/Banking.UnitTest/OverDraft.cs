

using System.Runtime.InteropServices;

namespace Banking.UnitTest;

public class OverDraft
{
    [Fact]
    public void CanTakeAllMoney()
    {
        var account = new BankAccount();
        account.Withdraw(account.GetBalance());

        Assert.Equal(0, account.GetBalance());
    }

    [Fact]
    public void OverdraftDoesNotDecreaseTheBalance()
    {
        var account = new BankAccount();

        Assert.Throws<OverDraftException>(() =>
            {
            account.Withdraw(account.GetBalance() + 0.1m);
            });
        }
    }