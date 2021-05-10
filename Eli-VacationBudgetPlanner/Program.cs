using System;

namespace Eli_VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool passwordCheck = true;
            Console.WriteLine("Welcome to your vacation budget app!");
            Console.WriteLine("Tell me your name");
            Console.Write("Name: ");
            string userName = Console.ReadLine();

            bool keepGoing = true;

           
                
                Console.WriteLine($"Welcome, {userName}. Please enter the correct password to continue");
                string password = Console.ReadLine().ToLower();
                if (password != "abc123") { Console.WriteLine("The password is incorrect");
                    Console.WriteLine("Press ENTER to exit");
                    Console.ReadLine();
                    keepGoing = false;
                }
                if (password == "abc123") { Console.WriteLine("User validation successful"); }
                while (keepGoing)
                {
                    Console.Write("Country: ");
                const int hourInDay = 24;
                const int hourToMinuteVal = 60;
                const double pesoConvVal = 20.24;
                const double jamaicanDollarsVal = 152.402;
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
                        
                        int hoursStayed = daysStayed * hourInDay;
                        
                        int minutesStayed = hoursStayed * hourToMinuteVal;
                        Console.WriteLine($"You'll be staying for {daysStayed} days which is {hoursStayed} hours or {minutesStayed} minutes");
                        Console.WriteLine("How much money are you bringing with you?");
                        amountBrought = double.Parse(Console.ReadLine());
                        double usdAmountPerDay = amountBrought / daysStayed;
                       
                        double convertedMoneyPerDay = usdAmountPerDay * pesoConvVal;
                        Console.WriteLine($"You can spend {convertedMoneyPerDay} pesos which is {usdAmountPerDay} USD per day.");
                        Console.WriteLine("Enjoy your trip!");


                        break;

                    case 2:

                        Console.WriteLine("Great, Jamaica sounds like an amazing trip!");
                        Console.WriteLine("**************");
                        Console.WriteLine("How many days are you planning to stay in Jamaica?");
                        daysStayed = int.Parse(Console.ReadLine());
                        int hoursStayed2 = daysStayed * hourInDay;
                        int minutesStayed2 = hoursStayed2 * hourToMinuteVal;
                        Console.WriteLine($"You'll be staying for {daysStayed} days which is {hoursStayed2} hours or {minutesStayed2} minutes");
                        Console.WriteLine("How much money are you bringing with you?");
                        amountBrought = double.Parse(Console.ReadLine());
                        double usdAmountPerDay2 = amountBrought / daysStayed;
                        
                        double convertedMoneyPerDay2 = usdAmountPerDay2 * jamaicanDollarsVal;
                        Console.WriteLine($"You can spend {convertedMoneyPerDay2} Jamaican Dollars which is {usdAmountPerDay2} USD per day");
                        Console.WriteLine("Enjoy your trip!");
                        break;

                    default:

                        Console.WriteLine("Select a valid location");
                        break;

                }

                //Console.WriteLine("Press ENTER to Exit");
                //Console.ReadLine();


                string runAgain;

                Console.WriteLine("Would you like to run this application again? Y / N");
                runAgain = Console.ReadLine().ToLower();
                if (runAgain == "y") { keepGoing = true; }
                if (runAgain == "n")
                {
                    Console.WriteLine($"Thanks for using this vacation budget app, {userName}");
                    Console.WriteLine("Press ENTER to exit");
                    Console.ReadLine();
                    keepGoing = false;
                }
            }





        }
    }
}
