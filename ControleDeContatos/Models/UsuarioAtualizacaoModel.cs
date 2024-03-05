using ControleDeContatos.Enums;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class UsuarioAtualizacaoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, digite o nome do usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, digite o login do usuário")]
        public string Login{ get; set;}

        [Required(ErrorMessage = "Por favor, digite o e-mail do usuário")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido")]
        public string Email { get; set;}

        [Required(ErrorMessage = "Por favor, informe o perfil do usuário")]
        public PerfilEnum? Perfil { get; set;}
    }
}
