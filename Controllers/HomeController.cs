using System;
using System.Collections.Generic;


using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //var personas = new List<Persona>()
            //{
            //    new Persona()
            //    {
            //        Id = 1,
            //        Name = "Marcela",
            //        Email = "mcela@gmail.com",
            //        Phone = "12345"
            //    },
            //    new Persona()
            //    {
            //        Id=2,
            //        Name = "Henry",
            //        Email="henry@gmail.com",
            //        Phone = "67890"
            //    }
            //};

            //ViewBag.Milistado = personas;
            
            //HttpContext.Session["Lista"] = personas;
            //_encuestado.LenguajePrimario = (List<string>)HttpContext.Session["Programas"];

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

            List<Persona> lista = new List<Persona>();
            lista = (List<Persona>)HttpContext.Session["Lista"];
            lista.Add(persona);

            HttpContext.Session["Lista"] = lista;
            
            
            return View(lista);

         }

    }
}