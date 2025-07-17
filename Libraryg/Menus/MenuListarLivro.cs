using Libraryg.Bibl;

namespace Libraryg.Menus
{
    internal class MenuListarLivro : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<int, Usuario> usuarios)
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
