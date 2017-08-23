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
        KeyValuePair<Generes, List<IBook>> BookCategory { get; } 
        List<IBook> Books { get;}
        IRegister IssueRegister { get; }
        List<IBook> IssueList { get; }

        List<IBook> GetIssuedBook();
        void CategoriseBook();
        void AddBookToLib(IBook book);
        void AddToIssueList(IBook book);
    }
}
