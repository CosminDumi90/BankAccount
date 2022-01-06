using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class GameAccount:Account
    {

        public GameAccount(string name, string number, decimal balance,bool isAccountActive):base(name,number,balance,isAccountActive)
        {

        }

        public override void MakeWithdrawal(decimal amount)
        {
            Console.WriteLine($"Can't make withdrawal, {this.GetType().Name} is only for deposits\n");
        }

      




    }
}
