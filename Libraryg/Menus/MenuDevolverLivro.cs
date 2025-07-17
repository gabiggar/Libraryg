using Libraryg.Bibl;


namespace Libraryg.Menus
{
    internal class MenuDevolverLivro : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<int, Usuario> usuarios)
        {
            base.Executar(livros, usuarios);

            ExibirTituloDaOpcao("DEVOLUÇÃO DE LIVRO");

            Console.Write("Digite o ID do usuário que está devolvendo o livro: ");
            string entrada = Console.ReadLine()!;
            int idUsuario = int.Parse(entrada);

            if (!usuarios.ContainsKey(idUsuario))
            {
                Console.WriteLine("Usuário não encontrado");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Usuario usuario = usuarios[idUsuario];

            if (usuario.LivrosEmprestados.Count == 0)
            {
                Console.WriteLine("Esse usuário não tem livros emprestados.");
                Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine($"Livros emprestados para o usuário ID: {usuario.UsuarioId} - {usuario.Nome}: ");

            for (int i = 0; i < usuario.LivrosEmprestados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {usuario.LivrosEmprestados[i].Titulo} - Autor: {usuario.LivrosEmprestados[i].Autor}");
            }

            Console.Write("\nDigite o número do livro que deseja devolver: ");
            string escolha = Console.ReadLine()!;
            //int indiceDevolvido = int.Parse(livroDevolvido);
            bool valido = int.TryParse(escolha, out int indiceDevolvido);

            if (!valido || indiceDevolvido < 1 || indiceDevolvido > usuario.LivrosEmprestados.Count)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
            else
            {
                Livro livroSelecionado = usuario.LivrosEmprestados[indiceDevolvido - 1];
                livroSelecionado.Disponivel = true;
                usuario.LivrosEmprestados.Remove(livroSelecionado);

                Console.WriteLine($"Livro '{livroSelecionado.Titulo}' devolvido com sucesso.");
            }

            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
