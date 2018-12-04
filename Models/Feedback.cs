using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PiesShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int Id { get; set; }
        [Required]
        [StringLength(100,ErrorMessage="Campo Obligatorio")]
        public string Name { get; set; }

        [Required]
        [StringLength(100,ErrorMessage="Email Obligatorio")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(200,ErrorMessage="Exediste el numero de palabras")]
        public string Message { get; set; }
        public bool ContactMe { get; set; }
    }
}