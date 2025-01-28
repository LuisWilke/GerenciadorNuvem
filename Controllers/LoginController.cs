using Microsoft.AspNetCore.Mvc;

namespace GerenciadorCobrancas.Controllers
{
    public class LoginController : Controller
    {
        // Exibe a página de login
        public IActionResult Index()
        {
            return View();
        }

        // Processa o login (a lógica de autenticação viria aqui)
        [HttpPost]
        public IActionResult Index(string cnpj, string email, string senha)
        {
            if (email == "admin@gmail.com" && senha == "1234" && cnpj == "12345678")
            {
                return RedirectToAction("Index", "Cobranca");
            }

            ViewBag.Erro = "E-mail ou senha inválidos!";
            return View();
        }

        // Exibe a página de recuperação de senha
        public IActionResult RecuperarSenha()
        {
            return View();
        }

        // Processa a recuperação de senha
        [HttpPost]
        public IActionResult RecuperarSenha(string email)
        {
            // Simulação de envio de e-mail de recuperação
            ViewBag.Mensagem = "As instruções foram enviadas para o seu e-mail.";
            return View();
        }
    }
}