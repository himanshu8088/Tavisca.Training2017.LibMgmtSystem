using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem.Model
{
    public class Book : IBook
    {
        public Book(string title,string publisher,string edition, DiscriptionTag tag)
        {
            Title = title;
            Publisher = publisher;
            Edition = edition;
            Discription = tag;
        }

        public string Title { get; private set; }

        public string Publisher { get; private set; }

        public string Edition { get; private set; }

        public DiscriptionTag Discription { get; private set; }
    }
}
