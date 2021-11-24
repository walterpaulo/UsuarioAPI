using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agendac;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UsuarioAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
      
        [HttpGet]
        public dynamic Get()
        {
            var ss = this.Request.Headers["User-agent"];
           Console.WriteLine($"===============[ {ss} ]=============");
           return new
           {
               Mensagem = "Bem vindo a API do desafio 21 dias multiplas",
               Documentacao = $"https://{this.Request.Host}/swagger/index.html"

           };
        }
    }
}
