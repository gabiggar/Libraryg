using Libraryg.Bibl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryg.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<string, Usuario> usuarios)
        {
            Console.WriteLine("Tchau, tchau :)");
        }
    }
}
