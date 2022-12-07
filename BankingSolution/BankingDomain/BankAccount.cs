﻿namespace Banking.Domain
{
    public class BankAccount
    {
        private decimal _balance = 5000;
        public virtual void Deposit(decimal amountToDeposit)
        {
           _balance += amountToDeposit;
        }
        public virtual void Withdraw(decimal amountToWithdrawl)
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