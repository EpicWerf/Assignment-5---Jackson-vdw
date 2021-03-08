using Microsoft.AspNetCore.Mvc;
using Assignment_5___Jackson_vdw.Models;

namespace Assignment_5___Jackson_vdw.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        //passes on the Cart to the View method to generate the fragment of HTML that will be included in the layout
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
