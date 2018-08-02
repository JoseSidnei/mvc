using ExemploMVC02.Models;
using ExemploMVC02.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC02.Controllers
{
    public class RecrutadoraController : Controller
    {
        // GET: Recrutadora
        public ActionResult Index()
        {
            List<Recrutadora> recrutadoras = new RecrutadoraRepository().ObterTodos();
            ViewBag.Recrutadoras = recrutadoras;
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Editar()
        {
            return View();
        }
    }
}