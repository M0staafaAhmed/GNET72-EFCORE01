using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore_Assignment_1.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
