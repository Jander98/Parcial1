using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1.Models
{
    public class Romero
    {   public enum TypeList
        {
            Iglesia,
            Barrio,
            Parque,
            Escuela,
            Fiesta
        }
        [Key]
        public int RomeroID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength =2)]
        public string FriendofRomero { get; set; }
        [Required]
        public TypeList Place { get; set; }
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Display(Name = "Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        public string Birthdate { get; set; }



    }
}