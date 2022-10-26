using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Teste1.Entities
{     
    public class Contato
    {
        [Key]
        [Required]
        public int PessoalId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Celular { get; set; }
    }
}