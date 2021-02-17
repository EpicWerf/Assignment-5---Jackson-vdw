using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//setup Repository file as good practice when creating database. 

namespace Assignment_5___Jackson_vdw.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
