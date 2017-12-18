using System;
using System.Collections.Generic;

namespace Tiqri.Training.TDD.NumberManager
{
    public class SortManager : ISortManager
    {
        public List<int> Sort(string fileName)
        {
            IFileManager fileManager = new FileManager();

            try
            {
                if(string.IsNullOrEmpty(fileName))
                    throw new ArgumentOutOfRangeException(nameof(fileName),"number list is empty.");

                var numbers = fileManager.ReadCsvFile(fileName);

                return InnerSort(GetNumberList(numbers));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private List<int> GetNumberList(List<string> numbers)
        {
            var numberList = new List<int>();

            foreach (var numberString in numbers)
            {
                int numberValue;
                bool success = int.TryParse(numberString, out numberValue);
                if (!success) continue;

                numberList.Add(numberValue);
            }

            return numberList;
        }

        public List<int> InnerSort(List<int> numberList)
        {
            numberList.Sort();

            return numberList;
        }
    }
}
