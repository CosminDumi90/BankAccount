using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class EconomyAccount:Account
    {

        private const decimal bonus = 0.01M;
        private const decimal fee = 0.02M;

        public EconomyAccount(string name, string number, decimal balance,bool isAccountActive):base(name,number,balance,isAccountActive)
        {

        }

        public override void MakeDeposit(decimal amount)
        {
            base.MakeDeposit(amount+(amount*bonus));
        }
        public override void MakeWithdrawal(decimal amount)
        {
            base.MakeWithdrawal(amount+(amount*fee));
        }
    }
}
