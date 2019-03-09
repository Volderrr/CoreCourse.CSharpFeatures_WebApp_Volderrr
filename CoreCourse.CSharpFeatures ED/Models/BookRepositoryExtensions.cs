using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.CSharpFeatures_ED.Models
{
    public static class BookRepositoryExtensions
    {
        public static int TotalPages(this BookRepository bookRepository)
        {
            int totalPages = 0;
            foreach (Book book in bookRepository.Books)
                totalPages += book?.Pages ?? 0;

            return totalPages;
        }
    }
}
