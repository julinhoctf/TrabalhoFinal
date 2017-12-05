using MusicMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicMVC.ViewModels
{
    public class PlataformssFormViewModel
    {
        public Plataform Plataform { get; set; }
        public string Title
        {
            get
            {
                if (Plataform != null && Plataform.Id != 0)
                    return "Editar Plataforma";

                return "Novo Plataforma";
            }
        }
    }
}