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
        [HttpGet]
        public ActionResult Index()
        {
            List<Recrutadora> recrutadoras = new RecrutadoraRepository().ObterTodos();
            ViewBag.Recrutadoras = recrutadoras;
            ViewBag.TituloPagina = "Recrutadoras";
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Recrutadoras Cadastro";
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Recrutadora recrutadora = new RecrutadoraRepository().ObterPeloId(id);
            ViewBag.Recrutadora = recrutadora;
            ViewBag.TituloPagina = "Recrutadoras Editar";
            return View();
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool apagado = new RecrutadoraRepository().Excluir(id);
            return null;
        }

        [HttpPost]
        public ActionResult Store(Recrutadora recrutadora)
        {
            if (ModelState.IsValid)
            {
                int identificador = new RecrutadoraRepository().Cadastrar(recrutadora);
                return RedirectToAction("Editar", new { id = identificador });
            }

            ViewBag.Recrutadora = recrutadora;
            return View("Cadastro");

        }

        [HttpPost]
        public ActionResult Update(Recrutadora recrutadora)
        {
            bool alterado = new RecrutadoraRepository().Alterar(recrutadora);
            return null;
        }
    }
}