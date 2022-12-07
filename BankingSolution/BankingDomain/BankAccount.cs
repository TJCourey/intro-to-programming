namespace Banking.Domain
{
    public class BankAccount
    {   
        private readonly ICalculateBonuses _calculator;
        private decimal _balance = 5000;

        public BankAccount(ICalculateBonuses calculator)
        {
            _calculator = calculator;
        }

        public void Deposit(decimal amountToDeposit)
        {
            // decimal bonus = _bonusCaluculator.GetBonusForDepositOn(_balance, amountToDeposit);
            var bonus = _calculator.GetBonusForDepositOn(_balance, amountToDeposit);
            _balance += amountToDeposit + bonus;
        }
        public void Withdraw(decimal amountToWithdrawl)
        {
            if (amountToWithdrawl > _balance)
            {
                throw new OverDraftException();
            }
            else
            {
                _balance -= amountToWithdrawl;
            }
        }
        public decimal GetBalance()
        {
           return _balance; 
        }
        

    }
}