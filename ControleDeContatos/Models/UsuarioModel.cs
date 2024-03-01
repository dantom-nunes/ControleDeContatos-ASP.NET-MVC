using ControleDeContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, digite o nome do usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, digite o login do usuário")]
        public string Login{ get; set;}

        [Required(ErrorMessage = "Por favor, digite o e-mail do contato")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido")]
        public string Email { get; set;}

        [Required(ErrorMessage = "Por favor, digite a senha do usuário")]
        public string Senha { get; set; }
        public PerfilEnum Perfil { get; set;}
        public DateTime DataCadastro { get; set;}
        public DateTime? DataAtualizacao { get; set; }
    }
}
