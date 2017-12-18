using System;

namespace Tiqri.Training.TDD.NumberManager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SortManager sortManager = new SortManager();

                var sortedNumbers = sortManager.Sort("inputNumbers.csv");

                Console.WriteLine("Sorted Numbers are ......");
                foreach (var number in sortedNumbers)
                {
                    Console.WriteLine(number);
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured,Failed to sort numbers");
                Console.WriteLine(e);
            }
        }
    }
}
