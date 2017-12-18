using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tiqri.Training.TDD.NumberManager.Tests
{
    [TestFixture]
    public class NumberToWordManagerTests
    {
        private INumberToWordManager _sut;
        [SetUp]
        public void Init()
        {
            _sut = new NumberToWordManager();
        }
        [Test]
        public void OnConvert_WhenInputIntegersFromOneToNineteen_ShouldPrintCorrespondingWordOfEachNumber()
        {
            //arrange
            IList<string> expected = new List<string> { "One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
            //act
            var words = _sut.Convert(numbers);
            //assert
            Assert.AreEqual(numbers.Count, words.Count, "1. Number of items in input and output are equal.");
            Assert.AreEqual(expected, words,"2. Numbers are converted to words.");

        }
        [Test]
        public void OnConvert_WhenInputUnsortedIntegersFromOneToNineteen_ShouldPrintSortedWordsFromOneToTen()
        {
            //arrange
            IList<string> expected = new List<string> { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            List<int> numbers = new List<int> { 19,18,17,16,15,14,13,12,11,10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //act
            var words = _sut.Convert(numbers);
            //assert
            Assert.AreEqual(numbers.Count, words.Count, "1. Number of items in input and output are equal.");
            Assert.AreEqual(expected, words, "2. Numbers are converted to words.");
        }
        [Test]
        public void OnConvert_WhenInputMultiplesOfTenIntegersFromTenToHundred_ShouldPrintSortedWordsFromTenToHundred()
        {
            //arrange
            IList<string> expected = new List<string> { "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "One Hundred"};
            List<int> numbers = new List<int> { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };

            //act
            var words = _sut.Convert(numbers);
            //assert
            Assert.AreEqual(numbers.Count, words.Count, "1. Number of items in input and output are equal.");
            Assert.AreEqual(expected, words, "2. Numbers are converted to words.");
        }
        [Test]
        public void OnConvert_WhenInputMixedIntegersWithMultiplesOfTenUnsorted_ShouldPrintSortedWordsOfSortedNumbers()
        {
            //arrange
            IList<string> expected = new List<string> { "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Thirty", "Fifty", "Ninety", "Ninety" };
            List<int> numbers = new List<int> { 90, 15, 14, 30, 50, 16, 17, 90 };

            //act
            var words = _sut.Convert(numbers);
            //assert
            Assert.AreEqual(numbers.Count, words.Count, "1. Number of items in input and output are equal.");
            Assert.AreEqual(expected, words, "2. Numbers are converted to words.");
        }
        [Test]
        public void OnConvert_WhenInputIntegersFromOneToHundredUnsorted_ShouldPrintSortedWordsFromOneToHundered()
        {
            //arrange
            IList<string> expected = new List<string> { "Five", "Ten", "Seventeen", "Nineteen", "Twenty Five", "Fifty Five", "Eighty Seven", "Ninety Nine" };
            List<int> numbers = new List<int> { 99, 87, 55, 25, 19, 17, 10, 5 };

            //act
            var words = _sut.Convert(numbers);
            //assert
            Assert.AreEqual(numbers.Count, words.Count, "1. Number of items in input and output are equal.");
            Assert.AreEqual(expected, words, "2. Numbers are converted to words.");
        }

        [Test]
        public void OnConvert_WhenInputIntegersFromOneToThousandUnsorted_ShouldPrintSortedWordsFromOneToThousand()
        {
            //arrange
            IList<string> expected = new List<string> { "Zero", "Ten", "Twenty", "Thirty Three", "Fifty One", "One Hundred", "Five Hundred and Fourteen", "Nine Hundred and Ninety Nine" };
            List<int> numbers = new List<int> { 999, 0, 10, 20, 33, 100, 51, 514 };

            //act
            var words = _sut.Convert(numbers);
            //assert
            Assert.AreEqual(numbers.Count, words.Count, "1. Number of items in input and output are equal.");
            Assert.AreEqual(expected, words, "2. Numbers are converted to words.");
        }
    }

    
}
