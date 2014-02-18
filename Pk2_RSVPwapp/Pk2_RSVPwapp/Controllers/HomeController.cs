using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pk2_RSVPwapp.Models;

namespace Pk2_RSVPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ?
                "Buenos Dias !!!" : "Buenas Tardes";
            return View();
        }
        //Get : /Home/RsvpForm
        //Redenderea el Link de la forma del RSVP
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        //Responde a un Post: /Home/RsvpForm
        [HttpPost]
        public ViewResult RsvpForm(GuestReponse guestResponse)
        {
            //Todo: Enviar respuesta al correo de organizador
            return View("Agradecimientos", guestResponse);
        }
    }
}
