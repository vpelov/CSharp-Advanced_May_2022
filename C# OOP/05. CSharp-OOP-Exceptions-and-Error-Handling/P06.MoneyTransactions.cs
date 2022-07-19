using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.MoneyTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> accountDict = new Dictionary<int, double>();

            string[] accountData = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < accountData.Length; i++)
            {
                string[] data = accountData[i].Split('-');
                int accountNumber = int.Parse(data[0]);
                double balanceAccount = double.Parse(data[1]);
                accountDict.Add(accountNumber, balanceAccount);
            }

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                string[] command = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string operation = command[0];

                try
                {
                    if (operation == "Deposit")
                    {
                        int numberAccount = int.Parse(command[1]);
                        double sum = double.Parse(command[2]);
                        accountDict[numberAccount] += sum;
                        Console.WriteLine($"Account {numberAccount} has new balance: {accountDict[numberAccount]:f2}");
                    }
                    else if (operation == "Withdraw")
                    {
                        int numberAccount = int.Parse(command[1]);
                        double sum = double.Parse(command[2]);
                        if (sum > accountDict[numberAccount])
                        {
                            Console.WriteLine("Insufficient balance!");
                            //cmd = Console.ReadLine();
                            //continue;
                        }
                        else
                        {
                            accountDict[numberAccount] -= sum;
                            Console.WriteLine($"Account {numberAccount} has new balance: {accountDict[numberAccount]:f2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                    }
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Invalid account!");
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
