using Libraryg.Bibl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryg.Menus
{
    internal class MenuEmprestarLivro : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<string, Usuario> usuarios)
        {
            base.Executar(livros, usuarios);

            ExibirTituloDaOpcao("EMPRÉSTIMO DE LIVRO");
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
                Console.WriteLine($"\nVocê emprestou o livro: {livroEmprestado.Titulo}");
                Console.WriteLine("Obrigado por utilizar nosso serviço de empréstimo!");
                Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
