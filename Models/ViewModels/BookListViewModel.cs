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
        // The IEnumberable is only pulled in the index page with the following statement
        // "@foreach (var x in Model.Projects)"
        public IEnumerable<Book> Books { get; set; }

        //this one is used to set how many pages there are
        public PagingInfo PagingInfo { get; set; }
        //next line will let you access the category from the controller
        public string Category { get; set; }
    }
}
