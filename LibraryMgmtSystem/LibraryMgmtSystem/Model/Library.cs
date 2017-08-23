using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    public class Library : ILibrary
    {
        private List<IBook> _books = new List<IBook>();
        private List<IBook> _issueList = new List<IBook>();
        private IRegister _register;
        private IIssueSystem _issueSystem;
        private KeyValuePair<Generes, IBook> _bookCategory;        

        public Library(IIssueSystem issueSystem, IRegister register)
        {
            _issueSystem = issueSystem;
            _register = register;
        }
        public KeyValuePair<Generes, IBook> BookCategory => _bookCategory;

        public List<IBook> Books => _books;

        public IRegister IssueRegister => _register;

        public void AddBookToLib(IBook book)
        {
            _books.Add(book);
        }

        public void AddToIssueList(IBook book)
        {
            _issueList.Add(book);
        }

        public void CategoriseBook(IBook book)
        {   
                
        }

        public void IssueBook(List<IBook> _issueList)
        {
            _issueSystem.Issue(_issueList,_register);
        }
        
    }
}
