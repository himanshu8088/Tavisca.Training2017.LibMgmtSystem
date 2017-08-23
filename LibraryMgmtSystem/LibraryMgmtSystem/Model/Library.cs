﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    public class Library : ILibrary
    {
        private List<IBook> _books = new List<IBook>();
        private List<IBook> _issueList = new List<IBook>();
        private IRegister _register;
        private IIssueSystem _issueSystem;
        private KeyValuePair<Generes, IBook> _bookCategory;

        public Library(IIssueSystem issueSystem, IRegister register)
        {
            _issueSystem = issueSystem;
            _register = register;
        }
        public KeyValuePair<Generes, IBook> BookCategory => _bookCategory;

        public List<IBook> Books => _books;

        public IRegister IssueRegister => _register;

        public void AddBookToLib(IBook book)
        {
            _books.Add(book);
        }

        public void AddToIssueList(IBook book)
        {
            _issueList.Add(book);
        }

        public void CategoriseBook(IBook book)
        {   
                
        }

        public List<IBook> GetIssuedBooks()
        {
            List<IIssuedBookData> dataList = _register.IssuedBooks;
            List<IBook> issuedBooks = new List<IBook>();
            foreach (IIssuedBookData data in dataList)
            {
                foreach (IBook book in data.Books)
                {
                    issuedBooks.Add(book); 
                }
            }
            return issuedBooks;
        }
    }
}
