using Parmajiat.Shopping.Data;
using Parmajiat.Shopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parmajiat.Shopping.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index(Cart cart)
        {
            return View(cart);
        }

        [HttpPost]
        [Route("Cart/AddToCart")]
        public ActionResult AddToCart(Cart cart, int id, int quantity)
        {
            CartLine cartLine = cart.FirstOrDefault(x => x.Product.Id == id);

            if (cartLine == null)
            {
                var product = DataRepository.products.FirstOrDefault(x => x.Id == id);
                cartLine = new CartLine(product, quantity);
                cart.Add(cartLine);
            }
            else
            {
                cartLine.Quantity += quantity;
            }
            
            if (cartLine.Quantity == 0)
            {
                cart.Remove(cartLine);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [Route("Cart/RemoveFromCart")]
        public ActionResult RemoveFromCart(Cart cart, int id)
        {
            CartLine cartLine = cart.FirstOrDefault(x => x.Product.Id == id);

            if (cartLine != null)
            {
                cart.Remove(cartLine);             
            }            
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Checkout(Cart cart)
        {
            return View(cart);
        }
    }
}