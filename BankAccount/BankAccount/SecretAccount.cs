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
        public decimal SecretBalance { get; set; }


        public SecretAccount(string name, string number, decimal balance, bool isAccountActive) : base(name, number, balance, isAccountActive)
        {
            this.SecretBalance = balance;
        }

        public void SecretMakeDeposit(decimal amount,DateTime dateTime,Vice vice)
        {
            if (dateTime.Month == 10)
            {
                Console.WriteLine("can't make purchase in october");
                return;
            }
            base.Balance += amount;
            Console.WriteLine($"{vice}");
            

        }




    }
}
