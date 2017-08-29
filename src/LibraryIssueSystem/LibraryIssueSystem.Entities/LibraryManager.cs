using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryIssueSystem.Entities;

namespace LibraryIssueSystem.Entities
{
    public class LibraryManager
    {
        private Shelf _shelf;                

        public LibraryManager(Shelf shelf)
        {
            _shelf = shelf;
        }

        public void Add(Book book)
        {
            if (book.Discription == "Technical")
            {                
                _shelf.Books.Add(book);
            }            
        }

        public void Remove(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
