using AccountApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        public long Id { get; init; }
        public string? Iban { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SSN { get; set; }
        public decimal Balance { get; set; }

        /// <summary>
        /// Withdraws the specified amount from the account
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount > 0)
                {
                    Balance += amount;
                }
                else
                {
                    throw new NegativeAmountException("Amount must be greater than 0");
                }
            }
            catch (NegativeAmountException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }

        }

        /// <summary>
        /// Withdraws the specified amount from the account
        /// </summary>
        /// <param name="amount"></param>
        public void Withdraw(decimal amount)
        {
            try
            {
                if (amount > 0)
                {
                    // Check if the account has enough funds
                    if (Balance >= amount)
                    {
                        Balance -= amount;
                    }
                    else
                    {
                        throw new InsuffisientAmountException("Insufficient funds");
                    }
                }
                else
                {
                    throw new NegativeAmountException("Amount must be greater than 0");
                }
            }
            catch (InsuffisientAmountException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
            catch (NegativeAmountException e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Returns a string representation of the account
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Account: {Id}, {Iban}, {FirstName}, {LastName}, {SSN}, {Balance}";
        }
    }
}
