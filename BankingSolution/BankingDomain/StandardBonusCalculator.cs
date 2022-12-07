namespace Banking.Domain
{
    public class StandardBonusCalculator : ICalculateBonuses
    {


        public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountofDeposit)
        {
            return currentBalance >= 5000 ? amountofDeposit * .10M : 0;
        }
    }
}