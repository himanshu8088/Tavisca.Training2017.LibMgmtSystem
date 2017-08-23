using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    public class Library : ILibrary
    {
        private List<Book> _books = new List<Book>();
        private List<Book> _issueList = new List<Book>();
        private IRegister _register;
        private IIssueSystem _issueSystem;
        private KeyValuePair<Genere, Book> _bookCategory;        

        public Library(IIssueSystem issueSystem, IRegister register)
        {
            _issueSystem = issueSystem;
            _register = register;
        }
        public KeyValuePair<Genere, Book> BookCategory => _bookCategory;

        public List<Book> Books => _books;

        public IRegister IssueRegister => _register;

        public void AddBookToLib(Book book)
        {
            _books.Add(book);
        }

        public void AddToIssueList(Book book)
        {
            _issueList.Add(book);
        }

        public void CategoriseBook(Book book)
        {   
                
        }

        public void IssueBook()
        {
            _issueSystem.Issue(_issueList,_register);
        }
        
    }
}
