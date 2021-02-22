using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5___Jackson_vdw.Models.ViewModels;

//set up Paging info to help with pagination
namespace Assignment_5___Jackson_vdw.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
