using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIssueSystem.Entities
{
    public class IssueResponse
    {
        public IssueResponse(int issueId, int borrowerId)
        {
            IssueId = issueId;
            BorrowerId = borrowerId;
            IssueDate = System.DateTime.Now;
        }

        public int IssueId { get; }
        public DateTime IssueDate { get; }
        public int BorrowerId { get; }        
    }
}
