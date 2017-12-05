using MusicMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicMVC.ViewModels
{
    public class MusicPlayersFormViewModel
    {
        public MusicPlayer MusicPlayers { get; set; }
        public string Title
        {
            get
            {
                if (MusicPlayers != null && MusicPlayers.Id != 0)
                    return "Editar Player de Musica";

                return "Novo Player de Musica";
            }
        }
    }
}