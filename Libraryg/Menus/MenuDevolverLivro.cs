using Libraryg.Bibl;


namespace Libraryg.Menus
{
    internal class MenuDevolverLivro : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<string, Usuario> usuarios)
        {
            base.Executar(livros, usuarios);

            ExibirTituloDaOpcao("DEVOLUÇÃO DE LIVRO");
            List<Livro> livrosEmprestados = new List<Livro>();
            foreach (var livro in livros.Values)
            {
                if (!livro.Disponivel)
                {
                    livrosEmprestados.Add(livro);
                }
            }

            if (livrosEmprestados.Count == 0)
            {
                Console.WriteLine("Nenhum livro está emprestado no momento.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine("Livros emprestados: ");
            for (int i = 0; i < livrosEmprestados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {livrosEmprestados[i].Titulo} - Autor: {livrosEmprestados[i].Autor}");
            }

            Console.Write("\nDigite o número do livro que deseja devolver: ");
            string escolha = Console.ReadLine()!;
            //int indiceDevolvido = int.Parse(livroDevolvido);
            bool valido = int.TryParse(escolha, out int indiceDevolvido);

            if (!valido || indiceDevolvido < 1 || indiceDevolvido > livrosEmprestados.Count)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
            else
            {
                Livro livroSelecionado = livrosEmprestados[indiceDevolvido - 1];
                livroSelecionado.Disponivel = true;
                Console.WriteLine($"Livro '{livroSelecionado.Titulo}' devolvido com sucesso.");
            }

            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
