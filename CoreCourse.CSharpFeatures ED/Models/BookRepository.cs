using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.CSharpFeatures_ED.Models
{
    public class BookRepository : IEnumerable<Book>
    {
        public IEnumerable<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return this.Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
