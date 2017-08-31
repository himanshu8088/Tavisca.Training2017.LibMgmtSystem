using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryIssueSystem.Entities;
using LibraryIssueSystem.Core.Repository;

namespace LibraryIssueSystem.Core.Provider
{
    public class GenereProvider
    {
        private GenereRepository _repo;

        public GenereProvider(GenereRepository repo)
        {
            _repo = repo;
        }

        public Genere Get(int Bookid)
        {
            throw new NotImplementedException();
        }
    }
}
