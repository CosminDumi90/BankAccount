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

    public class SecretAccount : Account
    {
        public override decimal Balance { get; set; }


        public SecretAccount(string name, string number, decimal balance, bool isAccountActive) : base(name, number, balance, isAccountActive)
        {
            this.Balance = balance;
        }

        public void SecretMakeDeposit(decimal amount)
        {
           
            base.Balance += amount;
           
            

        }




    }
}
