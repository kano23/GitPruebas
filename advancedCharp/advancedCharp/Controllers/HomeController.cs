using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using advancedCharp.Models;

namespace advancedCharp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public String Index()
        {
            return "nevagar a una URL para mostrar un ejemplo";
        }
        public ViewResult AutoProperty()
        {
            //crea un nuevo objeto
            //de la clase producto
            Product myProduct = new Product
            {
            //establece el valor de la propiedad
            ProductID = 12,
            Name = "Kayak",
            Descripction = "Kiosteca Blue",
            category = "SPORTS",
            price = 12.5f
        };
            string salida =
                String.Format("{0}-{1}-{2}-{3}-{4:C0}",
                myProduct.ProductID,
                myProduct.Name,
                myProduct.Descripction,
                myProduct.category,
                myProduct.price);
            //genera la vista
            return View("Results",
                (object)salida);

            //obtiene la propiedad
            string productName = myProduct.Name;

            //genera la vista
            return View("Results",
                (object)String.Format("Nombre del producto: {0}", productName));
        }

    }
}
