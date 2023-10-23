using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lb2.Controllers
{
    public class MyController : Controller
    {

        [HttpGet]
        public ViewResult GetFilm(Models.FilmData filmData)
        {
            ViewBag.Title = "Film";

            return View("Film", filmData);
        }


    }
}