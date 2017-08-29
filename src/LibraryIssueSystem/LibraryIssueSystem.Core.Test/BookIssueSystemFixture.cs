using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LibraryIssueSystem.Core.Implementation;
using LibraryIssueSystem.Entities;

namespace LibraryIssueSystem.Test
{
    class BookIssueSystemFixture
    {     

        [Fact]
        public void Book_issue_test()
        {
            Shelf shelf = new Shelf(Genere.Technical);
            shelf.Books = GetBookList();

            Library lib = new Library();
            lib.BookShelves.Add(shelf);                        
            
            LibraryManager libManager = new LibraryManager(shelf);

            Librarian librarian = new Librarian(libManager);
            librarian.Id = 100;

            IssueRequest issueRequest = new IssueRequest(shelf.Books,501);
            
            BookIssueSystem libSystem = new BookIssueSystem(librarian);
            IssueResponse response = libSystem.Librarian.Issue(issueRequest);

            Assert.NotNull(response);
        }
        
        public List<Book> GetBookList()
        {
            Book book = new Book();
            book.Id = 101;
            book.Authors = new List<string>() { "Eric Lippert" };
            book.Discription = "Technical";
            book.Title = "Microsoft C# Essential";
            book.PublishingDate = DateTime.Now;
            return new List<Book>() { book};
        }

    }
}
