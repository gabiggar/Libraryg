using Libraryg.Bibl;

namespace Libraryg.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<int, Usuario> usuarios)
        {
            Console.WriteLine("Tchau, tchau :)");
        }
    }
}
