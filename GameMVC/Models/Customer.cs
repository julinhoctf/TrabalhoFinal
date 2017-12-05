using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name= "Nome")]
        public string Name { get; set; }

        [Display(Name = "VIP")]
        public bool isPremium { get; set; }

        [Display(Name = "Tipo de Assinatura")]
        public SignatureCustomer SignatureCustomer { get; set; }

        [Display(Name= "Data de Nascimento")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
        
        [Display(Name=" Tipo de Assinatura")]
        public byte SignatureCustomerId { get; set; }

    }
}