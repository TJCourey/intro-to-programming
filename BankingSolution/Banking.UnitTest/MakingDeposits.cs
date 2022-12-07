

namespace Banking.UnitTest;

public class MakingDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(50)]
    public void MakingDepositsIncreaseBalance(decimal amountToDeposit)
    {
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        

        account.Deposit(amountToDeposit);

        Assert.Equal(amountToDeposit + openingBalance, account.GetBalance());
    }
}
