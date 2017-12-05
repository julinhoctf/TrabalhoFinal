using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicMVC.Models
{
    public class MusicPlayer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

    }
}