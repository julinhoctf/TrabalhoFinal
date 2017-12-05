using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicMVC.Models;

namespace MusicMVC.ViewModels
{
    public class RandoMusicViewModel
    {
        public Music Music { get; set; }
        public List<Customer> Customers { get; set; }
    }
}