using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    class LibraryRegister : IRegister
    {
        private List<IIssuedBookData> _issuedBooks=new List<IIssuedBookData>();

        public List<IIssuedBookData> IssuedBooks => _issuedBooks;

        public void AddEntry(IIssuedBookData data)
        {
            _issuedBooks.Add(data);
        }
    }
}
