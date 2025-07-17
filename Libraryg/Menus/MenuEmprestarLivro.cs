using Libraryg.Bibl;

namespace Libraryg.Menus
{
    internal class MenuEmprestarLivro : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<int, Usuario> usuarios)
        {
            base.Executar(livros, usuarios);

            ExibirTituloDaOpcao("EMPRÉSTIMO DE LIVRO");

            Console.Write("Digite o ID do usuário: ");
            string idUsuario = Console.ReadLine()!;
            int idDoUsuario = int.Parse(idUsuario);

            if (!usuarios.ContainsKey(idDoUsuario))
            {
                Console.WriteLine("Usuário não encontrado.");
                Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Usuario usuario = usuarios[idDoUsuario];

            List<Livro> livrosDisponiveis = new List<Livro>();
            foreach (var kvp in livros)
            {
                Livro livro = kvp.Value;
                if (livro.Disponivel)
                {
                    livrosDisponiveis.Add(livro);
                }
            }

            if (livrosDisponiveis.Count == 0)
            {
                Console.WriteLine("Nenhum livro disponível para empréstimo no momento.");
                Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine("Livros disponíveis:");
            for (int i = 0; i < livrosDisponiveis.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {livrosDisponiveis[i].Titulo} - Autor: {livrosDisponiveis[i].Autor}");
            }

            Console.Write("\nDigite o número do livro que deseja emprestar: ");
            string escolha = Console.ReadLine()!;
            //int indiceEscolhido = int.Parse(escolha);
            bool valido = int.TryParse(escolha, out int indiceEscolhido);

            if (!valido || indiceEscolhido < 1 || indiceEscolhido > livrosDisponiveis.Count)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            else
            {
                Livro livroEmprestado = livrosDisponiveis[indiceEscolhido - 1];
                livroEmprestado.Disponivel = false;

                usuario.LivrosEmprestados.Add(livroEmprestado);
                Console.WriteLine($"\nO livro: {livroEmprestado.Titulo} foi emprestado para o usuário {usuario.Nome}, ID: {usuario.UsuarioId}");
                Console.WriteLine("Obrigado por utilizar nosso serviço de empréstimo!");
                Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
