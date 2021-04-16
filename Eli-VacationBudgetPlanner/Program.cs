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
            string userName;
            userName = Console.ReadLine();

            Console.WriteLine($"Welcome, {userName}.  Where would you like to travel?  Mexico or Jamaica?");
            Console.Write("Country: ");
            string destination;
            destination = Console.ReadLine();

            Console.WriteLine($"You have chosen to go to {destination}");
        }
    }
}
