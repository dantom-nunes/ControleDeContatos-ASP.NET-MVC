using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Por favor, digite o login.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Por favor, digite a senha.")]
        public string Senha { get; set; }
    }
}
