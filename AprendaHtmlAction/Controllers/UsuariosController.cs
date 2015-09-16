using AprendaHtmlAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AprendaHtmlAction.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Inicio()
        {
            Professor pro = new Professor
            {
                Codigo=1,
                Nome="Professor"
            };
            return View(pro);
        }
        public ActionResult _Aluno(int codigo,string nome)
        {
            Aluno aluno = new Aluno{
                Codigo=codigo,
                Nome=nome
            };
            return View(aluno);

        }
        public ActionResult _Heroi()
        {
            Heroi heroi = new Heroi
            {
                Codigo=1,
                Nome="Otavio",
                SuperPoder="Desenvolvedor"
            };
            return View(heroi);
        }
    }
}