using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Misak.Models
{public enum WishList
    { Desodorante,
        Dulces,
        Dalmata
    }
    public class Fairy
    {
        [Key]
        public int FairyID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength = 2)]
        public string NickName { get; set; }
        public WishList Wishes { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Direccion de correo no valida")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Cumpleaños")]
        public DateTime Birthdate { get; set; }


    }
}