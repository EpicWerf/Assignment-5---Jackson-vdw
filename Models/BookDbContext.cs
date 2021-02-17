using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//setup context file as good practice when creating database. 

namespace Assignment_5___Jackson_vdw.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
