using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_5___Jackson_vdw.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDbContext _context;

        //constuctor
        public EFBookRepository (BookDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
