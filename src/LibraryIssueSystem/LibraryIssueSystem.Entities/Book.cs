using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryIssueSystem.Entities
{
    public class Book
    {        
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }        
        public string Discription { get; set; }
        public DateTime PublishingDate { get; set; }
        
        public override string ToString()
        {                      
            StringBuilder authors = new StringBuilder();
            foreach(string author in Authors)
            {
                authors.Append(author+"\n");
            }
            return $"Book Id:{Id}\nBook Title:{this.Title}\nAuthors:{authors}\nDiscription:{Discription}\nPublishing Date:{PublishingDate}";
        }
    }
}
