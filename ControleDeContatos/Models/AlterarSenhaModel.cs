using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class AlterarSenhaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite a senha atual")]
        public string SenhaAtual { get; set; }
        [Required(ErrorMessage = "Digite a nova senha")]
        public string NovaSenha { get; set; }
        [Required(ErrorMessage = "Digite a confirmação da nova senha")]
        [Compare("NovaSenha", ErrorMessage = "As senhas não correspondem, por favor tente novamente.")]
        public string ConfirmarNovaSenha { get; set; }
    }
}
