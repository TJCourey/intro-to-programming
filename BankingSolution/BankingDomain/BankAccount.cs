namespace Banking.Domain
{
    public enum BankAccountType { Standard, Gold}
    public class BankAccount
    {
        public BankAccountType AccountType = BankAccountType.Standard;
        private decimal _balance = 5000;
        public void Deposit(decimal amountToDeposit)
        {
            decimal bonus = AccountType == BankAccountType.Standard ? 0 : amountToDeposit * .10M;
           _balance += amountToDeposit = bonus;
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