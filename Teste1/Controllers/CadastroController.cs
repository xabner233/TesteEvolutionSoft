using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Teste1.Context;
using Teste1.Entities;

namespace Teste1.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class CadastroController : ControllerBase
    {

        private readonly CadastroContext __context;

        public CadastroController(CadastroContext context)
        {
            __context = context;
        }

        [HttpPost("AdicionarPessoa")]
        public IActionResult AdicionarPessoa(Pessoa pessoa)
        {
            __context.Add(pessoa);
            __context.SaveChanges();
            return Ok(pessoa);

        }

        [HttpPost("CriarContato")]
        public IActionResult CreateContato(Contato contato)
        {
            __context.Add(contato);
            __context.SaveChanges();
            return Ok(contato);

        }

        
        [HttpGet("BuscarContato/{pessoalId}")]
        public IActionResult PessoalIdObter(int pessoalId)
        {
            var contato = __context.Contatos.Find(pessoalId);
            return Ok(contato);

            if (contato == null)
                return NotFound();
            
            return Ok();            
        }

        [HttpGet("BuscarPessoa/{id}")]
        public IActionResult ObterPorId(int id)
        {
            var pessoa = __context.Pessoas.Find(id);
            return Ok(pessoa);

            if (pessoa == null)
                return NotFound();
            
            return Ok();            
        }

        [HttpGet("ObterPessoaPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var pessoas = __context.Pessoas.Where(x => x.Nome.Contains(nome));
            return Ok(pessoas);

        }

        [HttpGet("ObterContatoPorNome")]
        public IActionResult ObterPorNome2(string nome)
        {
            var contatos = __context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);

        }
        
         [HttpPut("AtualizarPessoa/{id}")]
        public IActionResult Atualizar(int id, Pessoa pessoa)
        {

            var contatoBanco = __context.Pessoas.Find(id);

            if (contatoBanco == null)
                return NotFound();

            contatoBanco.Cpf = contatoBanco.Cpf;
            contatoBanco.Nome =pessoa.Nome;
            contatoBanco.Email = pessoa.Email;
            contatoBanco.Cep = pessoa.Cep;
            contatoBanco.Logadouro = pessoa.Logadouro;
            contatoBanco.Complemento = pessoa.Complemento;
            contatoBanco.Bairro = pessoa.Bairro;
            contatoBanco.Uf = pessoa.Uf;


            __context.Pessoas.Update(contatoBanco);
            __context.SaveChanges();

            return Ok(contatoBanco);
        }

        [HttpPut("AtualizarContato/{pessoalId}")]
        public IActionResult Atualizar(int pessoalId, Contato contato)
        {

            var contatoBanco = __context.Contatos.Find(pessoalId);

            if (contatoBanco == null)
                return NotFound();

            contatoBanco.Nome =contato.Nome;
            contatoBanco.Celular = contato.Celular;

            __context.Contatos.Update(contatoBanco);
            __context.SaveChanges();

            return Ok(contatoBanco);
        }
       
       [HttpDelete("DeletarPessoa/{pessoalId}")]
        public IActionResult DeletarPessoa(int id)
        {
            var contatoBanco = __context.Pessoas.Find(id);

             if (contatoBanco == null)
                return NotFound();

            __context.Pessoas.Remove(contatoBanco);
            return NoContent();

        }

       [HttpDelete("DeletarContato/{pessoalId}")]
        public IActionResult DeletarContato(int pessoalId)
        {
            var contatoBanco = __context.Contatos.Find(pessoalId);

             if (contatoBanco == null)
                return NotFound();

            __context.Contatos.Remove(contatoBanco);
            return NoContent();

        }
    }
}