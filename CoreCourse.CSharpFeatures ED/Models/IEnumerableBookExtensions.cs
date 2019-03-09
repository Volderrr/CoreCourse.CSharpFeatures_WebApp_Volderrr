﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.CSharpFeatures_ED.Models
{
    public static class IEnumerableBookExtensions
    {
        public static int TotalPages(this IEnumerable<Book> bookCollection)
        {
            int totalPages = 0;
            foreach (Book book in bookCollection)
                totalPages += book?.Pages ?? 0;

            return totalPages;
        }
    }
}
