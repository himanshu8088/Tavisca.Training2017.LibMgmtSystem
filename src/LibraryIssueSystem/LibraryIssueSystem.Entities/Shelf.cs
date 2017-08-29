using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIssueSystem.Entities
{
    public class Shelf
    {
        public Shelf(Genere type)
        {
            Type = type;            
        }
        public Genere Type { get;  }
        public List<Book> Books { get; set; }
    }
}
