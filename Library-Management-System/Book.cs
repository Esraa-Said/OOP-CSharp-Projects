﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        
        public bool IsBorrowed { get; set; } = false;

        public Book(string title, string author) { 
            this.Title = title;
            this.Author = author;
           
        }
    }
}
