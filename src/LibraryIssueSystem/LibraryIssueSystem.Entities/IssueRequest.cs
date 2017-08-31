using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIssueSystem.Entities
{
    public class IssueRequest
    {
        public IssueRequest(List<Book> books, int memberId)
        {
            Books = books;
            MemberId = memberId;
        }

        public List<Book> Books { get;}
        public int MemberId { get; }
    }
}
