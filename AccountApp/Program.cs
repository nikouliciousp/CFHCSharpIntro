using AccountApp.Exceptions;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new()
            {
                Iban = "RO1234567890",
                FirstName = "John",
                LastName = "Doe",
                SSN = "1234567890123",
                Balance = 0
            };

            Console.WriteLine(account.ToString());

            try
            {
                Console.WriteLine("Depositing 100");
                account.Deposit(100m);
                Console.WriteLine(account.ToString());

                Console.WriteLine("Withdrawing 50");
                account.Withdraw(50m);
                Console.WriteLine(account.ToString());

                Console.WriteLine("Withdrawing 100");
                account.Withdraw(100m);
                Console.WriteLine(account.ToString());
            }
            catch (NegativeAmountException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InsuffisientAmountException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
