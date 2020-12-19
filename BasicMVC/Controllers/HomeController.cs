using System.Collections.Generic;
using System.Web.Mvc;
using BasicMVC.Models;

namespace BasicMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var coches = new List<Coche>
            {
                new Coche {Marca="BMW",Modelo="X6",Color="Gris"},
                new Coche {Marca="Mercedes",Modelo="A200",Color="Blanco"},
                new Coche {Marca="Porsche",Modelo="Cayanne",Color="Azul"},
                new Coche {Marca="Ford",Modelo="Mustang",Color="Rojo"}
            };
            
            return View(coches);
        }
    }
}
