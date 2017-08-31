using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryIssueSystem.Entities;
using LibraryIssueSystem.Core.Contracts;

namespace LibraryIssueSystem.Core.Repository
{
    public class BookRepository:ILibraryRepository<Book>
    {
        private List<Book> _books;

        public BookRepository()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Remove(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetById(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
