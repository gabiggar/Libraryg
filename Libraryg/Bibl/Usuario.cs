namespace Libraryg.Bibl
{
    internal class Usuario
    {
        private static int _usuarioID = 1;
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int UsuarioId { get; }

        public List<Livro> LivrosEmprestados { get; set; } = new List<Livro>();

        public Usuario(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            UsuarioId = _usuarioID++;
        }
    }
}
