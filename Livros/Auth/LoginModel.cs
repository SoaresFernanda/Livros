﻿using System.ComponentModel.DataAnnotations;

namespace Livros.Auth
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Nome de usuário é um campo obrigatório.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password é um campo obrigatório.")]
        public string? Password { get; set; }

    }
}
