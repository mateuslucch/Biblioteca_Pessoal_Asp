
using Biblioteca_Pessoal_Asp.Context;
using Biblioteca_Pessoal_Asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_Pessoal_Asp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BibliotecaPessoalController : ControllerBase
    {
        private readonly BibliotecaApiContext _context;

        public BibliotecaPessoalController(BibliotecaApiContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarLivro(Livro livro)
        {

            var livroBanco = livro;

            _context.Add(livro);
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet("BuscaPorId")]
        public IActionResult BuscarId(int id)
        {
            var livro = _context.Livros.Find(id);

            if (livro == null)
                return NotFound();

            return Ok(livro);
        }

        [HttpPut("{id}")]
        public IActionResult EditarLivro(int id, Livro livro)
        {
            var livroBanco = _context.Livros.Find(id);
            if (livroBanco == null)
                return NotFound();

            livroBanco.Titulo = livro.Titulo;
            livroBanco.Autor = livro.Autor;
            livroBanco.Ano = livro.Ano;
            livroBanco.Editora = livro.Editora;
            livroBanco.Serie = livro.Serie;
            livroBanco.Edicao = livro.Edicao;

            _context.SaveChanges();

            return Ok(livro);
        }
    }
}