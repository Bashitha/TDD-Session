using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tiqri.Training.TDD.NumberManager.Tests
{
    [TestFixture]
    public class SortManagerTests
    {
        private ISortManager _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new SortManager();
        }

        
        [Test]
        public void OnSort_WithOnlyNegativeNumberList_ShouldReturnAccendinlySortedNumberList()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void OnSort_WithEmptyString_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void OnSort_WithBothNegativeAndPositiveNumberList_ShouldReturnAccendinlySortedNumberList()
        {
            Assert.Inconclusive();
        }
    }
}
