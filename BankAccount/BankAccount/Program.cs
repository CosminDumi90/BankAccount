using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Account currentAccount = new Account("Cosmin Dumitru", "1234567", 2000, true);
            currentAccount.MakeDeposit(2000);
            currentAccount.MakeWithdrawal(1000);
       
            

            EconomyAccount economyAccount = new EconomyAccount("Cosmin Dumitru", "1234567e", 1000, true);
            economyAccount.MakeDeposit(1000);
            economyAccount.MakeWithdrawal(1000);

            GameAccount gameAccount = new GameAccount("Cosmin Dumitru", "1234567on", 200, true);
            gameAccount.MakeWithdrawal(200);
            gameAccount.MakeDeposit(100);

            SecretAccount secretAccount = new SecretAccount("Cosmin Dumitru", "1234567sec", 100, true);

            secretAccount.SecretMakeDeposit(100);
            Console.WriteLine(currentAccount.Balance);
           

            

            

        }
    }
}
