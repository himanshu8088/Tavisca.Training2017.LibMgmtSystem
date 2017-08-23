using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    public interface IIssueSystem
    {
        void Issue(List<IBook> books,IRegister register);
    }
}
