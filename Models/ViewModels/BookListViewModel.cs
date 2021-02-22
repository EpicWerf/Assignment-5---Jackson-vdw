using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5___Jackson_vdw.Models;


//set up view model to help with pagination
namespace Assignment_5___Jackson_vdw.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
