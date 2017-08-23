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

        public KeyValuePair<Generes, List<IBook>> BookCategory => throw new NotImplementedException();

        public List<IBook> Books => _books;

        public IRegister IssueRegister => throw new NotImplementedException();

        public List<IBook> IssueList => throw new NotImplementedException();

        public void AddBookToLib(IBook book)
        {
            _books.Add(book);
        }

        public void AddToIssueList(IBook book)
        {
            throw new NotImplementedException();
        }

        public void CategoriseBook()
        {
            throw new NotImplementedException();
        }

        public List<IBook> GetIssuedBook()
        {
            throw new NotImplementedException();
        }
    }
}
