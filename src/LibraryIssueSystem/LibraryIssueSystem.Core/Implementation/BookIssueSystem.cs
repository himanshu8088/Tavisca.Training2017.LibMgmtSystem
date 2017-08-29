using System;
using LibraryIssueSystem.Entities;

namespace LibraryIssueSystem.Core.Implementation
{
    public class BookIssueSystem
    {
        public Librarian Librarian { get; }     
        public BookIssueSystem(Librarian librarian)
        {
            Librarian = librarian;
        }
    }
}
