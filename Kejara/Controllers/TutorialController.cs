using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kejara.Models;

namespace Kejara.Controllers
{
    public class TutorialController : Controller
    {
        // URL d'accès
        // GET: /Tutorial/
        /// <summary>
        /// Action Index. Conduit à la vu Index chargée d'afficher la liste des tutos
        /// </summary>
        /// <returns>vue courante</returns>

        public ActionResult Index()
        {
            var service = new TutorialService();

            // modèle
            var tutorial = service.Select();

            // la vue doit rendre le modèle Tutorial
            return View(tutorial);
        }

        // URL d'accès
        // GET: /Tutorial/Selection/3
        /// <summary>
        /// Action Selection. Conduit à la vu Selection chargée d'afficher le détail d'un tuto
        /// </summary>
        /// <param name="id">Clé primaire</param>
        /// <returns>vue courante</returns>
        public ActionResult Selection(int? id)
        {
            var service = new TutorialService();

            // modèle
            var tutorial = service.Select(id.HasValue ? id.Value : 1);

            // la vue doit rendre le modèle Tutorial
            return View(tutorial);
        }
    }
}
