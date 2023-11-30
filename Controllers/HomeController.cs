using System;
using System.Collections.Generic;


using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaPartialView.Controllers
{
    public class HomeController : Controller
    {
        private static List<Persona> personaList = new List<Persona>();

        public ActionResult Index()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Index(Persona _persona)
        {
            var persona = new Persona();

            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Debe Completar Todos los Campos";
                return View();
            }
            
            persona.Id = _persona.Id;
            persona.Name = _persona.Name.ToString().ToUpper();
            persona.Email = _persona.Email;
            persona.Phone = _persona.Phone;

            personaList.Add(persona);           

            return View(personaList);

         }

    }
}