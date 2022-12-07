

using Banking.Domain;

namespace Banking.UnitTest
{
    public class NewAccounts
    {
        [Fact]
        public void HaveTheCorrectOpeningBalance()
        {
            var account = new BankAccount();

            decimal balance = account.GetBalance();
            
            Assert.Equal(5000, balance);

        }
    }
}
