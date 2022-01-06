using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        private string name;
        private string number;
        private decimal balance;
        private bool isAccountActive;
        private const string pin = "1706";




        public string Name { get { return name; } }
        public string Number { get { return number; } }
        public virtual decimal Balance { 
            get 
            { 
                return this.balance; 
            }
            set
            {
                Console.WriteLine("In order to send money to your regular account please provide the pin number:");
                string password = Console.ReadLine();
                if (password == pin)
                {
                    this.balance = value;
                }
                else
                {
                    Console.WriteLine("pin is not correct");
                }
            }
        }
        public bool IsAccountActive
        {
            get
            {
                return isAccountActive;
            }
            set
            {
                Console.WriteLine("In order to terminate account your pin number is needed:");
                string password = Console.ReadLine();
                if (password == pin)
                {
                    Console.WriteLine($"pin is correct, account {this.number} is closed!");
                    isAccountActive = value;
                }
                else
                {
                    Console.WriteLine("pin is not correct");
                }
            }
        }



        public Account(string name, string number, decimal balance, bool isAccountActive)
        {
            this.name = name;
            this.number = number;
            this.balance = balance;
            Console.WriteLine($"{this.GetType().Name} {this.number} initial balance: {this.balance} ");
            this.isAccountActive = isAccountActive;
        }


        public virtual void MakeDeposit(decimal amount)
        {

            if (this.isAccountActive == false)
            {
                Console.WriteLine($"Account number: {this.number} is closed");
                return;
            }

            else
            {
                this.balance += amount;
                Console.WriteLine($"After deposit the balance for your {this.GetType().Name} is: {this.balance}");
            }
        }

        public virtual void MakeWithdrawal(decimal amount)
        {

            if (this.isAccountActive == false)
            {
                Console.WriteLine($"Account number: {this.number} is closed");
                return;
            }
            if (this.balance <= 0)
            {
                Console.WriteLine("Not enough money in your account");
                return;
            }
            if (this.balance - amount <= 0)
            {
                Console.WriteLine($" current balance is: {this.balance}, not enough funds");
            }
            else
            {
                this.balance -= amount;
                Console.WriteLine($"After withdrawal the balance for your {this.GetType().Name} is: {this.balance}");
            }

        }
    }
}
