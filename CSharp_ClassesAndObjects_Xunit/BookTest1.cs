using System;
using Xunit;

namespace CSharp_ClassesAndObjects.Tests
{

    // open terminal
    // juiste folder
    // dotnet test => en resultaat

    public class TypeTest
    {
        [Fact]
        public void BookaCalculatesAnAverageGrade()
        {

            var book1 = GetBook("Book 1");

            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.name);

            Assert.Equal("Book 2", book2.name);



        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
