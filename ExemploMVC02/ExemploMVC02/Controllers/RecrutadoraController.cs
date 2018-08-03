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

        public ActionResult Editar(int id)
        {
            Recrutadora recrutadora = new RecrutadoraRepository().ObterPeloId(id);
            ViewBag.Recrutadora = recrutadora;
            return View();
        }

        public ActionResult Excluir(int id)
        {
            bool apagado = new RecrutadoraRepository().Excluir(id);
            return null;
        }

        public ActionResult Store(Recrutadora recrutadora)
        {
            int identificador = new RecrutadoraRepository().Cadastrar(recrutadora);
            return RedirectToAction("Editar", new { id = identificador });
        }

        public ActionResult Update(Recrutadora recrutadora)
        {
            bool alterado = new RecrutadoraRepository().Alterar(recrutadora);
            return null;
        }
    }
}