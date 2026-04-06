using System;

namespace UnitConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n---------------------------------");
                Console.WriteLine("     Simple Unit Converter       ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Meters to Kilometers");
                Console.WriteLine("2. Kilometers to Meters");
                Console.WriteLine("3. Celsius to Fahrenheit");
                Console.WriteLine("4. Fahrenheit to Celsius"); // New Option
                Console.WriteLine("5. Exit"); // Moved Exit to 5
                Console.Write("\nSelect an option: ");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    running = false;
                    Console.WriteLine("Exiting application...");
                    break; 
                }

                Console.Write("Enter the value to convert: ");
                string inputRaw = Console.ReadLine();
                
                if (double.TryParse(inputRaw, out double input))
                {
                    switch (choice)
                    {
                        case "1":
                            double km = input / 1000;
                            Console.WriteLine($"{input} Meters = {km} Kilometers");
                            break;
                        case "2":
                            double meters = input * 1000;
                            Console.WriteLine($"{input} Kilometers = {meters} Meters");
                            break;
                        case "3":
                            double fahrenheit = (input * 9 / 5) + 32;
                            Console.WriteLine($"{input}°C = {fahrenheit}°F");
                            break;
                        case "4":
                            double celsius = (input - 32) * 5 / 9;
                            Console.WriteLine($"{input}°F = {celsius}°C");
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please choose 1, 2, 3, 4, or 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid numerical value.");
                }

                Console.WriteLine("\n--- Task Complete ---");
            }
        }
    }
}