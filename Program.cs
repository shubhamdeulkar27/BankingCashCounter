using System;

namespace BankingCashCounter
{
    class Program
    {
        //Constants
        private const int DEPOSIT = 0;
        private const int WITHDRAW = 1;
        private const int EXIT = 9;
        private const int MINIMUM_BALANCE = 500;

        //Variables
        private static int choice = 0;
        private static int amount = 0;

        /// <summary>
        /// Function to perform the transactions.
        /// </summary>
        static void DoTransaction()
        {
            Program program = new Program();
            Customer customer = new Customer();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 0 to Deposite");
                    Console.WriteLine("Enter 1 to Withdraw");
                    Console.WriteLine("Enter 9 to Exit");
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                if (choice == EXIT)
                {
                    break;
                }
                switch (choice)
                {
                    case DEPOSIT:
                        program.Deposit(customer);
                        break;
                    case WITHDRAW:
                        program.Withdraw(customer);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice ");
                        break;
                }
                
            }
        }

        /// <summary>
        /// Function for Deposit money to account.
        /// </summary>
        /// <param name="customer"></param>
        public void Deposit(Customer customer)
        {
            try
            {
                Console.WriteLine("Enter Account Number");
                customer.AccountNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Amount");
                amount = Int32.Parse(Console.ReadLine());
                customer.Balance = customer.Balance + amount;
                Console.WriteLine($"Updated Account Balance is {customer.Balance}");
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Function for Withdraw money from account.
        /// </summary>
        /// <param name="customer"></param>
        public void Withdraw(Customer customer)
        {
            try
            {
                Console.WriteLine("Enter Account Number");
                customer.AccountNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Amount");
                amount = Int32.Parse(Console.ReadLine());
                if (customer.Balance - amount > MINIMUM_BALANCE)
                {
                    customer.Balance = customer.Balance - amount;
                    Console.WriteLine($"Updated Account Balance is {customer.Balance}");
                }
                else
                {
                    Console.WriteLine("Account Balance Is Low");
                }
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        
        /// <summary>
        /// Main Function for performing transaction.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Cash Counter");
            Program.DoTransaction();
        }
    }
}
