using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Teste1.Entities
{
    public class Pessoa
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logadouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
       // public List<Contato> Contatos { get; set; }
    }
}