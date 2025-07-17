using Libraryg.Bibl;


namespace Libraryg.Menus
{
    internal class MenuRegistrarLivro : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<string, Usuario> usuarios)
        {
            base.Executar(livros, usuarios);
            ExibirTituloDaOpcao("REGISTRAR LIVRO");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine()!;
            Console.Write($"Digite o autor do livro {titulo}: ");
            string autor = Console.ReadLine()!;
            Console.Write($"Digite a editora do livro {titulo}: ");
            string editora = Console.ReadLine()!;
            Console.Write($"Digite o ano de lançamento do livro {titulo}: ");
            string anoLancamento = Console.ReadLine()!;
            int anoLancamentoNumerico = int.Parse(anoLancamento);
            Livro novoLivro = new Livro(titulo, autor, editora, anoLancamentoNumerico);
            livros.Add(titulo, novoLivro);
            Console.WriteLine($"\nLivro: {titulo}, Autor: {autor}, Editora: {editora}, Lançado em {anoLancamento} - cadastrado com sucesso!");
            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
