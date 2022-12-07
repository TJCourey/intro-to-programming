namespace Banking.UnitTests.TestDoubles;



// Canned responses to questions.
public class StubbedBonusCalculator : ICalculateBonuses
{
    public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
    {
        return currentBalance >= 5000M ? amountOfDeposit * .1M : 0;
    }
}