using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LibraryIssueSystem.Core;
using LibraryIssueSystem.Entities;

namespace LibraryIssueSystem.Test
{
    class LibrarySystemFixture
    {     
        [Fact]
        public void Book_issue_test()
        {            
            IssueRequest issueRequest = new IssueRequest(new List<Book>() ,0);            
            LibrarySystem libSystem = new LibrarySystem();
            IssueResponse response = libSystem.Issue(issueRequest);
            Genere genere=libSystem.GetGenere(100);

            Assert.NotNull(response);
            Assert.NotNull(genere);
        }
        
    }
}
