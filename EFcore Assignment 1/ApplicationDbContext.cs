using EFcore_Assignment_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFcore_Assignment_1
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
               optionsBuilder.UseSqlServer("Server=.;Database=BOOKSTORE;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
