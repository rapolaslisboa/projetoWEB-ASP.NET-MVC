using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoWEB.Controllers
{
    public class MontagemController : Controller
    {
        // GET: Montagem
        public ActionResult Index()
        {
            //var usuarioLogado = HttpContext.Session["Usuario"];
            //if (usuarioLogado == null)
            //{
            //    return Redirect("/LoginCadastro/Index");
            //}

            return View();
        }
    }
}