using Libraryg.Bibl;
using Libraryg.Menus;

Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();
Dictionary<string, Livro> livros = new Dictionary<string, Livro>();
Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", "HarperCollins", 1954);
Livro livro2 = new Livro("1984", "George Orwell", "Secker & Warburg", 1949);
Livro livro3 = new Livro("Dom Quixote", "Miguel de Cervantes", "Francisco de Robles", 1605);
livros.Add(livro1.Titulo, livro1 );
livros.Add(livro2.Titulo, livro2);
livros.Add(livro3.Titulo, livro3);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCadastrarUsuario());
opcoes.Add(2, new MenuRegistrarLivro());
opcoes.Add(3, new MenuListarLivro());
opcoes.Add(4, new MenuEmprestarLivro());
opcoes.Add(5, new MenuDevolverLivro());
opcoes.Add(0, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine("BIBLIOTECA GARCIA");
    Console.WriteLine("\nBoas vindas à Biblioteca Garcia!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n--- MENU BIBLIOTECA ---\n");
    Console.WriteLine("1. Cadastrar Usuário");
    Console.WriteLine("2. Registrar Livro");
    Console.WriteLine("3. Exibir Livros da Biblioteca");
    Console.WriteLine("4. Emprestar Livro");
    Console.WriteLine("5. Devolver Livro");
    Console.WriteLine("0. Sair");
    Console.Write("\nEscolha uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(livros, usuarios);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
  else
    {
        Console.WriteLine("Opção inválida");
    }
}


ExibirOpcoesDoMenu();