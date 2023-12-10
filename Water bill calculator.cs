using System;

class Program
{
    static void Main()
    {
        bool running = true;
        do
        {
            Console.WriteLine("\tWelcome to the water billing system");
            Console.WriteLine("Below are the types of usage with their respective codes");
            Console.WriteLine("\n1 Residential");
            Console.WriteLine("2 Commercial");
            Console.WriteLine("3 Industrial");

            int typeOfUsage;
            decimal monthlyConsumption;

            while (true)
            {
                Console.WriteLine("Enter your code:");
                string userInputTypeOfUsage = Console.ReadLine();

                if (int.TryParse(userInputTypeOfUsage, out typeOfUsage) && typeOfUsage > 0 && typeOfUsage <= 3)
                {
                    break; // Valid input, exit the loop
                }
                else
                {
                    Console.WriteLine("Enter a valid code!!");
                }
            }

            while (true)
            {
                Console.WriteLine("Enter your monthly consumption");
                string userInputAmountOfUsage = Console.ReadLine();

                if (decimal.TryParse(userInputAmountOfUsage, out monthlyConsumption) && monthlyConsumption > 0)
                {
                    break; // Valid input, exit the loop
                }
                else
                {
                    Console.WriteLine("Enter a valid Monthly consumption input!!");
                }
            }


            static decimal ResidentialBillingAlgorithm(decimal monthlyConsumption)
            {
                decimal monthlyWaterBill = monthlyConsumption * 25.00m;
                Console.WriteLine($"Your monthly water bill is :{monthlyConsumption}/cm^3 * 25.00 = {monthlyWaterBill}kes");
                return monthlyWaterBill;
            }

            static decimal CommercialBillingAlgorithm(decimal monthlyConsumption)
            {
                decimal monthlyWaterBill = monthlyConsumption * 30.50m;
                Console.WriteLine($"Your monthly water bill is :{monthlyConsumption}/cm^3 * 30.50 = {monthlyWaterBill}kes");
                return monthlyWaterBill;
            }

            static decimal IndustrialBillingAlgorithm(decimal monthlyConsumption)
            {
                decimal monthlyWaterBill = monthlyConsumption * 35.75m;
                Console.WriteLine($"Your monthly water bill is :{monthlyConsumption}/cm^3 * 35.75 = {monthlyWaterBill}kes");
                return monthlyWaterBill;
            }

            if (typeOfUsage == 1)
            {
                ResidentialBillingAlgorithm(monthlyConsumption);
            }
            else if (typeOfUsage == 2)
            {
                CommercialBillingAlgorithm(monthlyConsumption);
            }
            else if (typeOfUsage == 3)
            {
                IndustrialBillingAlgorithm(monthlyConsumption);
            }

            bool proceed = true;
            while (proceed)
            {
                Console.Write("\nRerun water bill calculator? (Y/N)");
                string run = Console.ReadLine();
                switch (run.ToUpper())
                {
                    case "YES":
                        proceed = false;
                        Console.Clear();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case "Y":
                        proceed = false;
                        Console.Clear();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        break;
                    case "NO":
                        running = false;
                        proceed = false;
                        Console.WriteLine("Press enter to Exit");
                        Console.ReadLine();
                        break;
                    case "N":
                        running = false;
                        proceed = false;
                        Console.WriteLine("Press enter to Exit");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Wrong input made!");
                        Console.WriteLine("Press enter to Retry");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        } while (running);
    }
}
