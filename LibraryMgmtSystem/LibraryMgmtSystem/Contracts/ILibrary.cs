using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    public enum Generes { Technical, Fiction,Horror}

    public interface ILibrary
    {
        KeyValuePair<Generes, IBook> BookCategory { get; } 
        List<IBook> Books { get;}
        IRegister IssueRegister { get; }                
        void CategoriseBook(IBook book);
        void AddBookToLib(IBook book);
        void AddToIssueList(IBook book);
        void IssueBook(List<IBook> _issueList);
    }
}
