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

            Console.WriteLine($"Welcome, {userName}.  Where would you like to travel?  (1) Mexico or (2) Jamaica?");
            Console.Write("Country: ");
            int destination = int.Parse(Console.ReadLine());
            int daysStayed;
            double amountBrought;
            switch (destination)
            {
                case 1:

                    Console.WriteLine("Great, Mexico sounds like an amazing trip!");
                    Console.WriteLine("**************");
                    Console.WriteLine("How many days are you planning to stay in Mexico?");
                    daysStayed = int.Parse(Console.ReadLine());
                    Console.WriteLine("How much money are you bringing with you?");
                    amountBrought = double.Parse(Console.ReadLine());
                    double usdAmountPerDay = amountBrought / daysStayed;
                    double convertedMoneyPerDay = usdAmountPerDay * 20.24;
                    Console.WriteLine($"You can spend {convertedMoneyPerDay} pesos which is {usdAmountPerDay} USD per day.");
                    Console.WriteLine("Enjoy your trip!");

      
                    break;

                case 2:

                    Console.WriteLine("Great, Jamaica sounds like an amazing trip!");
                    Console.WriteLine("**************");
                    Console.WriteLine("How many days are you planning to stay in Jamaica?");
                    daysStayed = int.Parse(Console.ReadLine());
                    Console.WriteLine("How much money are you bringing with you?");
                    amountBrought = double.Parse(Console.ReadLine());
                    double usdAmountPerDay2 = amountBrought / daysStayed;
                    double convertedMoneyPerDay2 = usdAmountPerDay2 * 152.402;
                    Console.WriteLine($"You can spend {convertedMoneyPerDay2} Jamaican Dollars which is {usdAmountPerDay2} USD per day");
                    Console.WriteLine("Enjoy your trip!");
                    break;

                default:

                    Console.WriteLine("Select a valid location");
                    break;

            }

            Console.WriteLine("Press ENTER to Exit");
            Console.ReadLine();


            //Console.WriteLine($"You have chosen to go to {destination}");


            //Console.WriteLine("How many days would you like to stay?");
            //int daysStayed = int.Parse(Console.ReadLine());

            //Console.WriteLine("How much money would you like to bring?");
            //double moneyBrought = double.Parse(Console.ReadLine());

            //double moneyPerDay = moneyBrought / daysStayed;


            //Console.WriteLine($"You can spend {moneyPerDay} each day.");
            


        


        }
    }
}
