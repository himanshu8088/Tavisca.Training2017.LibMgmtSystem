using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    public enum Genere { Technical, Fiction,Horror}

    public interface ILibrary
    {
        KeyValuePair<Genere, Book> BookCategory { get; } 
        List<Book> Books { get;}
        IRegister IssueRegister { get; }                
        void CategoriseBook(Book book);
        void AddBookToLib(Book book);
        void AddToIssueList(Book book);
        void IssueBook(List<Book> _issueList);
    }
}
