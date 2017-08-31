using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryIssueSystem.Entities;
using LibraryIssueSystem.Core.Contracts;

namespace LibraryIssueSystem.Core.Repository
{
    public class GenereRepository : ILibraryRepository<BookGenere>
    {
        private List<BookGenere> _bookGenereList;

        public GenereRepository()
        {
            _bookGenereList=new List<BookGenere>();
        }
     
        public void Add(BookGenere item)
        {
            throw new NotImplementedException();
        }
     
        public void Remove(BookGenere item)
        {
            throw new NotImplementedException();
        }       
    }
}
