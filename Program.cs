using System;

namespace BankingCashCounter
{
    class Program
    {
        //Constants
        private const int DEPOSIT = 0;
        private const int WITHDRAW = 1;
        private const int ADD_CUSTOMER = 2;
        private const int DETAIL = 3;
        private const int EXIT = 9;
        private const int MINIMUM_BALANCE = 500;

        //Variables
        private static int choice = 0;
        private static int amount = 0;
        private static int accountNumber;
        /// <summary>
        /// Function to perform the transactions.
        /// </summary>
        static void DoTransaction(ref LinkedList list)
        {
            Program program = new Program();
            Customer customer = new Customer();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 0 to Deposite");
                    Console.WriteLine("Enter 1 to Withdraw");
                    Console.WriteLine("Enter 2 to Add Customer");
                    Console.WriteLine("Enter 3 to View Account Detail");
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
                        program.Deposit(ref list);
                        break;
                    case WITHDRAW:
                        program.Withdraw(ref list);
                        break;
                    case ADD_CUSTOMER:
                        program.AddCustomer(ref list);
                        break;
                    case DETAIL:
                        program.ShowDetail(ref list);
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
        public void Deposit(ref LinkedList list)
        {
            try
            {
                Console.WriteLine("Enter Account Number");
                accountNumber = Int32.Parse(Console.ReadLine());
                Customer customer=list.Search(accountNumber);
                if (customer != null)
                {
                    Console.WriteLine("Enter Amount");
                    amount = Int32.Parse(Console.ReadLine());
                    customer.Balance = customer.Balance + amount;
                    Console.WriteLine($"Updated Account Balance is {customer.Balance}");
                }
                else
                {
                    Console.WriteLine($"{accountNumber} Not Found");
                }
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
        public void Withdraw(ref LinkedList list)
        {
            try
            {
                Console.WriteLine("Enter Account Number");
                accountNumber = Int32.Parse(Console.ReadLine());
                Customer customer = list.Search(accountNumber);
                if (customer != null)
                {
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
                else
                {
                    Console.WriteLine($"{accountNumber} Not Found");
                }
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        /// <summary>
        /// Function to Create Account of Customer and Add it to Linkd List.
        /// </summary>
        /// <param name="list"></param>
        public void AddCustomer(ref LinkedList list)
        {
            Customer customer = new Customer();
            try
            {
                Console.WriteLine("Enter the Name");
                customer.Name = Console.ReadLine();
                Console.WriteLine("Enter Account Number");
                customer.AccountNumber = Int32.Parse(Console.ReadLine());
                list.AddNode(customer);
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }

        /// <summary>
        /// Function to Show Account Detail.
        /// </summary>
        /// <param name="list"></param>
        public void ShowDetail(ref LinkedList list)
        {
            try
            {
                Console.WriteLine("Enter Account Number");
                accountNumber = Int32.Parse(Console.ReadLine());
                Customer customer = list.Search(accountNumber);
                if (customer != null)
                {
                    Console.WriteLine($"Name : {customer.Name}");
                    Console.WriteLine($"Account Number : {customer.AccountNumber}");
                    Console.WriteLine($"Account Balance : {customer.Balance}");
                }
                else
                {
                    Console.WriteLine($"{accountNumber} Not Found");
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
            LinkedList list = new LinkedList();
            Program.DoTransaction(ref list);
        }
    }
}
