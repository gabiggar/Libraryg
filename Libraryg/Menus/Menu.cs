using Libraryg.Bibl;

namespace Libraryg.Menus
{
    internal class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
        public virtual void Executar (Dictionary<string, Livro> livros, Dictionary<string, Usuario> usuarios)
        {
            Console.Clear();
        }
    }
}
