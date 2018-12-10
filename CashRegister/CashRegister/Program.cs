using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take in Cost & Payment
            Console.WriteLine("What was the Cost?");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What was the Payment?");
            double payment = Convert.ToDouble(Console.ReadLine());

            //Calculate Change Amount
            double change = payment - cost;
            if (payment > cost)
            {
                Console.WriteLine($"Change is {change}");
                int twenties = 0;
                while (change >= 20)
                {
                    twenties++;
                    change -= 20;
                }

                int tens = 0;
                while (change >= 10)
                {
                    tens++;
                    change -= 10;
                }

                int fives = 0;
                while (change >= 5)
                {
                    fives++;
                    change -= 5;
                }

                int ones = 0;
                while (change >= 1)
                {
                    ones++;
                    change -= 1;
                }

                int quarters = 0;
                while (change >= 0.25)
                {
                    quarters++;
                    change -= 0.25;
                }

                int dimes = 0;
                while (change >= 0.10)
                {
                    dimes++;
                    change -= 0.10;
                }

                int nickels = 0;
                while (change >= 0.05)
                {
                    nickels++;
                    change -= 0.05;
                }

                int pennies = 0;
                while (change > 0.01)
                {
                    pennies++;
                    change -= 0.01;                    
                }
                Console.WriteLine("Broken Down: ");
                if (twenties > 0)
                {
                    if (twenties > 1)
                    {
                        Console.WriteLine($"{twenties} 20 dollar bills");
                    }
                    else
                    {
                        Console.WriteLine("1 20 dollar bill");
                    }
                }
                if (tens > 0)
                {
                    if (tens > 1)
                    {
                        Console.WriteLine($"{tens} 10 dollar bills");
                    }
                    else
                    {
                        Console.WriteLine("1 10 Dollar bill");
                    }
                }
                if (fives > 0)
                {
                    if (fives > 1)
                    {
                        Console.WriteLine($"{fives} 5 dollar bills");
                    }
                    else
                    {
                        Console.WriteLine("1 5 dollar bill");
                    }
                }
                if (ones > 0)
                {
                    if (ones > 1)
                    {
                        Console.WriteLine($"{ones} 1 dollar bills");
                    }
                    else
                    {
                        Console.WriteLine("1 1 dollar bill");
                    }
                }
                if (quarters > 0)
                {
                    if (quarters > 1)
                    {
                        Console.WriteLine($"{quarters} quarters");
                    }
                    else
                    {
                        Console.WriteLine("1 quarter");
                    }
                }
                if (dimes > 0)
                {
                    if (dimes > 1)
                    {
                        Console.WriteLine($"{dimes} dimes");
                    }
                    else
                    {
                        Console.WriteLine("1 dime");
                    }
                }
                if (nickels > 0)
                {
                    if (nickels > 1)
                    {
                        Console.WriteLine($"{nickels} nickels");
                    }
                    else
                    {
                        Console.WriteLine("1 nickel");
                    }
                }
                if (pennies > 0)
                {
                    if (pennies > 1)
                    {
                        Console.WriteLine($"{pennies} pennies");
                    }
                    else
                    {
                        Console.WriteLine("1 penny");
                    }
                }
            }
            else if (payment == cost)
            {
                Console.WriteLine("No Change");
            }
            else
            {
                Console.WriteLine("Error: Cost was greater than payment");
            }
            Console.ReadLine();
        }
    }
}
