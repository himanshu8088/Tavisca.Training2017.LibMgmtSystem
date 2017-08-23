using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmtSystem
{
    public class Book
    {
        public Book(string title,string publisher,string edition, Genere tag)
        {
            Title = title;
            Publisher = publisher;
            Edition = edition;
            Discription = tag;
        }

        public string Title { get; private set; }

        public string Publisher { get; private set; }

        public string Edition { get; private set; }

        public Genere Discription { get; private set; }

        public override string ToString()
        {
            return $"Book Title:{Title} Publisher:{Publisher} Edition:{Edition}";
        }
    }
}
