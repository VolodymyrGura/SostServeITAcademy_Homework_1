namespace SostServeITAcademy_Homework_1
{
    using System;

    public class ConsoleInputValidator : IValidatable
    {
        public int GetIntegerInput(string inputQuery, int min, int max)
        {
            Console.WriteLine(inputQuery);

            int inputValue;

            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out inputValue))
                {
                    Console.Write("Enter valid integer value: ");
                }
                else if (inputValue < min || inputValue > max)
                {
                    Console.Write($"Enter integer in range from {min} to {max}: ");
                }
                else
                {
                    break;
                }
            }

            return inputValue;
        }

        public double GetDoubleInput(string inputQuery, double min, double max)
        {
            Console.WriteLine(inputQuery);

            double inputValue;

            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out inputValue))
                {
                    Console.Write("Enter valid double value: ");
                }
                else if (inputValue < min || inputValue > max)
                {
                    Console.Write($"Enter double in range from {min} to {max}: ");
                }
                else
                {
                    break;
                }
            }

            return inputValue;
        }

        public string GetStringInput(string inputQuery)
        {
            Console.WriteLine(inputQuery);

            string inputString;

            while (true)
            {
                if ((inputString = Console.ReadLine()).IsNullOrEmpty())
                {
                    Console.Write("Enter non-empty string: ");
                }
                else
                {
                    break;
                }
            }

            return inputString;
        }
    }
}
