using System;
using System.ComponentModel.DataAnnotations;

namespace LT_TCS_CRUD.Models
{
    public class Contato
    {
        public Contato()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        [Required(ErrorMessage = "O Campo nome é obrigatório!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo e-mail é obrigatório!")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Campo telefone é obrigatório!")]
        [RegularExpression(@"(\(?\d{2}\)?\s)?(\d{4,5}\-\d{4})", //Expressão Regular para telefones válidos
                   ErrorMessage = "O número de telefone informado não é valido.")]
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        [Required(ErrorMessage = "O Campo cidade é obrigatório!")]
        public string Cidade { get; set; }
    }
}
