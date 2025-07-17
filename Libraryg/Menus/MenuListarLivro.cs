using Libraryg.Bibl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryg.Menus
{
    internal class MenuListarLivro : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<string, Usuario> usuarios)
        {
            base.Executar(livros, usuarios);

            ExibirTituloDaOpcao("EXIBIR LIVROS");
            Console.WriteLine("Livros disponíveis na biblioteca: ");
            foreach (var kvp in livros)
            {
                Livro livro = kvp.Value;
                Console.WriteLine($"\nTítulo: {livro.Titulo}, Autor: {livro.Autor}, Editora: {livro.Editora}, Ano de Lançamento: {livro.AnoLancamento} - Status: {(livro.Disponivel ? "Disponível" : "Emprestado")}");
            }
            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
