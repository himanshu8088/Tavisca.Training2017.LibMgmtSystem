﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    public class IssuedBookData : IIssuedBookData
    {
        
        public IssuedBookData(DateTime dateOfIssue, System.Guid to, List<IBook> books)
        {
            DateOfIssue = dateOfIssue;
            To = to;
            Books = books;
        }

        public DateTime DateOfIssue { get; private set; }

        public System.Guid To { get; private set; };

        public List<IBook> Books { get; private set; }

        Guid IIssuedBookData.To => throw new NotImplementedException();
    }
}
