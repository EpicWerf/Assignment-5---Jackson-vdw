using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_5___Jackson_vdw.Models;


//A view component is a small, reusable application logic of some sort
// take some logic and build it in the view component, then drop it into the html at some point
namespace Assignment_5___Jackson_vdw.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;
        public NavigationMenuViewComponent (IBookRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            //will dynamically build a viewbag entry. In this case it will do it based on the category 
            //this is based on the route (endpoints) in the startup.cs file
            ViewBag.SelectedType = RouteData?.Values["category"];

            //figures out how to order it and orders it that way
            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
