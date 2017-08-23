using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    public class LibraryIssueSystem : IIssueSystem
    {
        public void Issue(List<IBook> books, IRegister register)
        {
            IssuedBookData data = new IssuedBookData(DateTime.Now, Guid.NewGuid(), books);
            register.AddEntry(data);
        }
    }
}
