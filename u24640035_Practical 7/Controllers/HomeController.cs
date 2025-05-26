using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u24640035_Practical_7.Models;

namespace u24640035_Practical_7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repository = new PublicationRespository();
            var publications = repository.GetPublications();
            return View(publications);
        }
    }
}