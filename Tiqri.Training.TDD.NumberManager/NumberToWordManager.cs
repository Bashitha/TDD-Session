using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiqri.Training.TDD.NumberManager
{
    public class NumberToWordManager : INumberToWordManager
    {
        private IDictionary<int, string> _wordsOneToNineteen = new Dictionary<int, string>()
        {
            { 1, "One"},
            { 2, "Two"},
            { 3, "Three"},
            { 4, "Four"},
            { 5, "Five"},
            { 6, "Six"},
            { 7, "Seven"},
            { 8, "Eight"},
            { 9, "Nine" },
            { 10, "Ten"},
            { 11, "Eleven"},
            { 12, "Twelve"},
            { 13, "Thirteen"},
            { 14, "Fourteen"},
            { 15, "Fifteen"},
            { 16, "Sixteen"},
            { 17, "Seventeen"},
            { 18, "Eighteen"},
            { 19, "Nineteen" },
            
        };
        private IDictionary<int, string> _wordsMultiplesOfTenFromTwentyToHundred = new Dictionary<int, string>()
        {
            
            { 2, "Twenty"},
            { 3, "Thirty"},
            { 4, "Forty"},
            { 5, "Fifty"},
            { 6, "Sixty"},
            { 7, "Seventy"},
            { 8, "Eighty"},
            { 9, "Ninety" },
            
            
        };
        public IList<string> Convert(List<int> numbers)
        {
            //sorting the number list
            SortManager _sortManager = new SortManager();
            numbers = _sortManager.InnerSort(numbers);

            var words = new List<string>();
            
            foreach (var number in numbers)
            {
                string word;
                int remainder;
                if (number/100 != 0)
                {
                    if (_wordsOneToNineteen.TryGetValue(number / 100, out word))
                    {                        
                        remainder = number % 100;
                        word = word + " Hundred";
                        string word2;
                        if (remainder != 0)
                        { 
                            if (_wordsOneToNineteen.TryGetValue(remainder, out word2))
                            {
                                word = word + " and " + word2; 
                            }
                            else if (_wordsMultiplesOfTenFromTwentyToHundred.TryGetValue(remainder / 10, out word2))
                            {
                                string word3;
                                word = word + " and " + word2;
                                remainder = remainder % 10;
                                if(remainder != 0)
                                {
                                    if (_wordsOneToNineteen.TryGetValue(remainder, out word3))
                                    {
                                        word = word +" "+ word3;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    remainder = number % 100;
                    if (_wordsOneToNineteen.TryGetValue(remainder, out word))
                    {
                        

                    }
                    else if(_wordsMultiplesOfTenFromTwentyToHundred.TryGetValue(remainder / 10, out word))
                    {
                        remainder = remainder % 10;
                        string word2;
                        if (_wordsOneToNineteen.TryGetValue(remainder, out word2))
                        {
                            word = word + " " + word2;
                        }
                    }
                    else
                    {
                        word = "Zero";
                    }
                    
                }
                words.Add(word);
                
            }
            return words;
        }
    }
}

