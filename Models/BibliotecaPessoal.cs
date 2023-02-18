using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca_Pessoal_Asp.Models
{
    // Classe espelho da tabela BibliotecaPessoal
    public class Livro
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Nome do autor é obrigatório")]
        public string Autor { get; set; }

        [Range(1, 9999, ErrorMessage = "Ano deve ser entre 1 e 9999")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "Editora é obrigatório")]
        public string Editora { get; set; }

        public string Serie { get; set; }

        public string Edicao { get; set; }
    }
}