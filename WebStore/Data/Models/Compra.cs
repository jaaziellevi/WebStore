using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebStore.Data.Models
{
    public class Compra
    {
        [BindNever]
        public int CompraId { get; set; }

        public List<DetalhesCompra> Compras { get; set; }

        [Display(Name = "Primeiro Nome")]
        [StringLength(50)]
        [Required(ErrorMessage = "Por favor digite o seu primeiro nome")]
        public string PrimeiroNome { get; set; }

        [Required(ErrorMessage = "Por favor digite o seu sobrenome")]
        [Display(Name = "Sobrenome")]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Por favor digite o seu endereço")]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Por favor digite o seu CEP")]
        [Display(Name = "CEP")]
        [StringLength(10, MinimumLength = 9)]
        public string CEP { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Por favor digite a sua cidade")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Por favor digite o seu estado")]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Por favor digite o seu número de telefone")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Por favor digite o seu email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "O email não foi digitado da forma correcta")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal TotalCompra { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime DataCompra { get; set; }
    }
}
