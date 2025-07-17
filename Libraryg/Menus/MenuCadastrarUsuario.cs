using Libraryg.Bibl;


namespace Libraryg.Menus
{
    internal class MenuCadastrarUsuario : Menu
    {
        public override void Executar(Dictionary<string, Livro> livros, Dictionary<string, Usuario> usuarios)
        {
            base.Executar(livros, usuarios);

            ExibirTituloDaOpcao("CADASTRAR USUÁRIO");
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine()!;
            Console.Write("Digite o email do usuário: ");
            string email = Console.ReadLine()!;
            Console.Write("Digite o telefone do usuário: ");
            string telefone = Console.ReadLine()!;
            Usuario novoUsuario = new Usuario(nome, email, telefone);
            usuarios[email]= (novoUsuario);
            Console.WriteLine("Usuário cadastrado com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
