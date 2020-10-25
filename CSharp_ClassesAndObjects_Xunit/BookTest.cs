using System;
using Xunit;

namespace CSharp_ClassesAndObjects.Tests
{
    // DIT IS UNIT TESTEN MET XUNIT
    // open terminal
    // juiste folder
    // dotnet test => en resultaat

    public class BookTest
    {
        [Fact]
        public void BookaCalculatesAnAverageGrade()
        {
            // arrange section: setup the test
            //var x = 5;
            //var y = 2;
            //var expected = 7;

            var book = new Book("");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // actual section
            //var actual = x + y;
            var stats = book.GetStatistics();


            // assert section
            // let bij double op de precisie => op 1 decimal bv
            Assert.Equal(85.6, stats.Average,1);
            Assert.Equal(90.5, stats.High,1);
            Assert.Equal(77.3, stats.Low,1);
        }
    }
}
