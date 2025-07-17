using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraryg.Bibl
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int UsuarioId { get; set; }


        public Usuario(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
