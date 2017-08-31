using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryIssueSystem.Entities;


namespace LibraryIssueSystem.Core.Contracts
{
    public interface ILibraryRepository<T>:ICollection<T>
    {
        
    }
}
