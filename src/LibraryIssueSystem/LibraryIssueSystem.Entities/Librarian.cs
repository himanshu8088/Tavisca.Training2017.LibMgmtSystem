using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIssueSystem.Entities
{
    public class Librarian
    {
        public int Id { get; set; }
        private LibraryManager _libraryManager;

        public Librarian(LibraryManager libraryManager)
        {
            _libraryManager = libraryManager;
        }

        public IssueResponse Issue(IssueRequest request)
        {
            return new IssueResponse(100,600);
            
        }

    }
}
