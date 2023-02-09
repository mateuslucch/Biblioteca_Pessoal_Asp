using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca_Pessoal_Asp.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_Pessoal_Asp.Context
{
    // Classe representa nosso DB
    public class BibliotecaApiContext : DbContext
    {
        public BibliotecaApiContext(DbContextOptions<BibliotecaApiContext> options) : base(options)
        {
        }

        // Tabelas no DB
        public DbSet<Livro> Livros { get; set; }
    }
}