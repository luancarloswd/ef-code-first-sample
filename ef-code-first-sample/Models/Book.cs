﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_code_first_sample.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public Category Category { get; set; }
        public Author Author { get; set; }
    }
}
