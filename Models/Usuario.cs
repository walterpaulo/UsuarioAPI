using System;

namespace UsuarioAPI.Models
{
    public class UsuarioAPI{
        public int id {get;set;}
        public string nome {get;set;}
        public string email {get;set;}
        public string senha {get;set;}
        public int? idEmpresa {get;set;}
        public DateTime Datacricao {get;set;}
        public DateTime DataAtualizacao {get;set;}
    }
}