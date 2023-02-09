using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Pessoal_Asp.Models
{
    // Classe espelho da tabela BibliotecaPessoal
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string Editora { get; set; }
        public string Serie { get; set; }
        public string Edicao { get; set; }
    }
}