using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public enum Vice
    {
        whiskey,
        watches
    }

   
    public class SecretAccount :Account
    {
        public override decimal Balance { get; set; }

        public Account Account { get; set; }
        public Vice vice { get; set; }
        public SecretAccount(string name, string number, decimal balance, bool isAccountActive, Account account):base(name,number,balance,isAccountActive)
        {
            this.Account = account;
            this.Balance = balance;
        }

        public override void MakeDeposit(decimal amount)
        {
            this.Account.Balance += amount;
        }

        public void SecretPurchase(decimal amount,DateTime shopDate,Vice vice)
        {
            if (shopDate.Month == 10)
            {
                Console.WriteLine("Can't make any purchases in october");
            }
            else
            {
                base.MakeWithdrawal(amount);
                Console.WriteLine($"I could buy {vice} allday ");
            }
        }





    }
}
