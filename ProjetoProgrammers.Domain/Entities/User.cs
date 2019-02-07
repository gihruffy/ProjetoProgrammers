using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjetoProgrammers.Domain.Entities
{
    public class User
    {

        public User()
        {

        }
        public User(string name, string email, string phone)
        {    
            Name = name;
            Email = email;
            Phone = phone;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo Nome é Obrigatório")]
        [MaxLength(255, ErrorMessage = "O Campo Nome não pode ter mais que 255 caracteres")]
        public string Name { get; private set; }

        [Required(ErrorMessage = "O Campo Email é Obrigatório")]
        [MaxLength(255, ErrorMessage = "O Campo Email não pode ter mais que 255 caracteres")]
        public string Email { get; private set; }

        [Required(ErrorMessage = "O Campo Telefone é Obrigatório")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "O Campo telefone precisa ser numerico")]
        [MaxLength(255, ErrorMessage = "O Campo Telefone não pode ter mais que 12 caracteres")]
        public string Phone { get; private set; }
    }
}
