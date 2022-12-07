

using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class GoldAccountBenefits
{
    [Fact]
    public void GetBonusOnDeposit()
    {
        var StubbedBonusCalculator = new Mock<ICalculateBonuses>();
        var account = new BankAccount(new StubbedBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        var expectedBonus = 10M;
        StubbedBonusCalculator.Setup(s => s.GetBonusForDepositOn(openingBalance, amountToDeposit)).Returns(expectedBonus);

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit + expectedBonus, 
            account.GetBalance());

    }
}
