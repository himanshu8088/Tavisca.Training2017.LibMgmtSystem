using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryIssueSystem.Entities;
using LibraryIssueSystem.Core.Repository;

namespace LibraryIssueSystem.Core.Manager
{
    public class GenereManager
    {
        private GenereRepository _repo;

        public GenereManager(GenereRepository repo)
        {
            _repo = repo;
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
       
        public void Remove(Book book)
        {
            throw new NotImplementedException();
        }        
    }
}
