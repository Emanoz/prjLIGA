using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tarefas.business.Models.Payloads
{
    public class LoginPayload
    {
        [Required(ErrorMessage = "É necessário informar o usuário.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "É necessário informar a senha.")]
        public string Password { get; set; }
    }
}
