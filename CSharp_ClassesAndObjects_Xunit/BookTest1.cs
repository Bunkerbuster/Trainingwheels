using Microsoft.VisualStudio.TestPlatform.ObjectModel;
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
        public void CSharpIsPassByRef()
        {
            var book1 = GetBook("Book 1");

            GetBookSetName(ref book1, "new Name");

            Assert.Equal("new Name", book1.Name);

        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }



        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");

            GetBookSetName(book1, "new Name");

            Assert.Equal("Book 1", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CabSetNameFromReference() 
        {
            var book1 = GetBook("Book 1");

            SetName(book1, "new Name");

            Assert.Equal("new Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {

            var book1 = GetBook("Book 1");

            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);

            Assert.Equal("Book 2", book2.Name);

            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {

            var book1 = GetBook("Book 1");

            var book2 = book1;


            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
