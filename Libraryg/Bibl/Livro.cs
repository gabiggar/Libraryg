using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryg.Bibl
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoLancamento { get; set; }
        public bool Disponivel { get; set; } = true; // Indica se o livro está disponível para empréstimo

        public Livro(string titulo, string autor, string editora, int anoLancamento)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            AnoLancamento = anoLancamento;
        }
    }
}
