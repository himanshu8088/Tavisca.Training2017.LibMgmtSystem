using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryIssueSystem.Entities;
using LibraryIssueSystem.Core.Repository;
using LibraryIssueSystem.Core.Contracts;

namespace LibraryIssueSystem.Core.Manager
{
    public class BookManager:ILibraryManager
    {
        private BookRepository _repo;
        private GenereManager _manager;

        public BookManager(GenereManager manager, BookRepository repo)
        {
            _repo = repo;
            _manager = manager;
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Add(List<Book> books)
        {
            throw new NotImplementedException(); 
        }
        
        public void Remove(List<Book> books)
        {
            throw new NotImplementedException();
        }

        public void Remove(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
