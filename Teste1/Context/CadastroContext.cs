using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Teste1.Entities;

namespace Teste1.Context
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos {get; set;}

        public DbSet<Pessoa> Pessoas {get; set;} 
        
    }
}