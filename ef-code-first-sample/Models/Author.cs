using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_code_first_sample.Models
{
    public class Author
    {
        public Author()
        {
              this.Books = new HashSet<Book>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
