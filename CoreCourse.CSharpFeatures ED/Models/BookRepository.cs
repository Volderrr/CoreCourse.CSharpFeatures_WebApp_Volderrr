﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.CSharpFeatures_ED.Models
{
    public class BookRepository
    {
        public IEnumerable<Book> Books { get; set; }
    }
}