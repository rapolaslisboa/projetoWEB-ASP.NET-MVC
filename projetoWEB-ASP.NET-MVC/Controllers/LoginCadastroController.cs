using ProjetoWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;


namespace ProjetoWEB.Controllers
{
    
    public class LoginCadastroController : Controller
    {
        LoginEntities contextEntities = new LoginEntities();

        // GET: LoginCadastro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Colaborador usuarioColaborador)
        {
            var senhaCriptografada = FormsAuthentication.HashPasswordForStoringInConfigFile(usuarioColaborador.Senha, "MD5");

            var consultaUsuario = contextEntities.Colaborador.Where(u => u.Email == usuarioColaborador.Email && u.Senha == senhaCriptografada).FirstOrDefault();

            if (consultaUsuario != null)
            {
                Session.Add("Usuario", consultaUsuario);
                return Redirect("/Escala/Index");
            }
            else
            {
                ViewBag.Erro = "E-mail e/ou senha inválido (os)";
                return View("Index");
            }

        }

        [HttpPost]
        public ActionResult Cadastrar(Colaborador novoUsuario)
        {
            var senhaCriptografada = FormsAuthentication.HashPasswordForStoringInConfigFile(novoUsuario.Senha, "MD5");
            novoUsuario.Disponibilidade = true;
            novoUsuario.Senha = senhaCriptografada;
            contextEntities.Colaborador.Add(novoUsuario);
            contextEntities.SaveChanges();
            ViewBag.StatusCadastro = "Colaborador cadastrado com sucesso!";
            return View("Cadastro");

        }

        [HttpPost]
        public ActionResult Sair()
        {
            HttpContext.Session.Clear();
            return View("Index");

        }


    }
}