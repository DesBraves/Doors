using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.Modele;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1.DTO
{
    class PorteDTO
    {
        /// <summary>
        /// Attribut présentant le DTO du nom d'une porte
        /// </summary>
        public String Nom { get; set; }
        /// <summary>
        /// Attribut présentant le DTO d'une description d'une porte
        /// </summary>
        public String Description { get; set; }
        /// <summary>
        /// Attribut présentant le DTO d'une location d'une porte
        /// </summary>
        public String Location { get; set; }
        /// <summary>
        /// Attribut présentant le DTO de l'état d'une porte
        /// </summary>
        public bool Actif { get; set; }

        /// <summary>
        /// Constructeur par défaut de la classe PorteDTO.
        /// </summary>
        /// <param name="uneporte"></param>
        public PorteDTO(Porte uneporte)
        {
            this.Nom = uneporte.Nom;
            this.Description = uneporte.Description;
            this.Location = uneporte.Location;
            this.Actif = uneporte.Actif;
        }
    }
}