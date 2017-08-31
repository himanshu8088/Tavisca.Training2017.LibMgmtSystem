using System;
using LibraryIssueSystem.Entities;
using LibraryIssueSystem.Core.Contracts;
using LibraryIssueSystem.Core.Manager;
using LibraryIssueSystem.Core.Repository;
using LibraryIssueSystem.Core.Provider;

namespace LibraryIssueSystem.Core
{
    public class LibrarySystem : IBookIssueSystem
    {
        private GenereProvider _genereProvider;
        private BookManager _bookManager;

        public LibrarySystem()
        {
            GenereRepository genereRepo = new GenereRepository();
            BookRepository bookRepo = new BookRepository();

            GenereManager genereManager = new GenereManager(genereRepo);
            _genereProvider = new GenereProvider(genereRepo);
            _bookManager = new BookManager(genereManager,bookRepo);
        }

        public IssueResponse Issue(IssueRequest request)
        {           
            if (request.Books.Count > 1)
            {
                _bookManager.Remove(request.Books);
            }
            return new IssueResponse(101,request.MemberId);
        }

        public Genere GetGenere(int bookId)
        {            
            return _genereProvider.Get(bookId);
        }        
    }
}
