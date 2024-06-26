﻿using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Por favor, digite o seu login.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Por favor, digite o seu e-mail.")]
        public string Email { get; set; }
    }
}
