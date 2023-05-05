using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class MapaController : Controller
    {
        [HttpGet]
        public ActionResult MostrarMapa()
        {
            ML.Localizacion localizacion = new ML.Localizacion();
            ML.Result result = BL.Localizacion.GetAll();

            if (result.Correct)
            {
                localizacion.Localizaciones = result.Objects;
                return View(localizacion);
            }

            return View(localizacion);
        }
    }
}