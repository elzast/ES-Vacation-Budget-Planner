using System;

namespace Eli_VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your vacation budget app!");
            Console.WriteLine("Tell me your name");
            Console.Write("Name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Welcome, {userName}.  Where would you like to travel?  Mexico or Jamaica?");
            Console.Write("Country: ");
            string destination = Console.ReadLine();

            Console.WriteLine($"You have chosen to go to {destination}");


            Console.WriteLine("How many days would you like to stay?");
            int daysStayed = int.Parse(Console.ReadLine());

            Console.WriteLine("How much money would you like to bring?");
            double moneyBrought = double.Parse(Console.ReadLine());

            double moneyPerDay = moneyBrought / daysStayed;


            Console.WriteLine($"You can spend {moneyPerDay} each day.");
            


        


        }
    }
}
