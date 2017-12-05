using MusicMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicMVC.ViewModels
{
    public class MusicsFormViewModel
    {
        public Music Music { get; set; }
        public string Title
        {
            get
            {
                if (Music != null && Music.Id != 0)
                    return "Editar Musica";

                return "Nova Musica";
            }
        }
    }
}