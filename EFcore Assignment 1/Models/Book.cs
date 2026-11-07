using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore_Assignment_1.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublishYear { get; set; }
        public int Stock { get; set; }
    }
}
