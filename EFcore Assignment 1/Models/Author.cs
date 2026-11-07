using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore_Assignment_1.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public DateTime DOB { get; set; }

    }
}
