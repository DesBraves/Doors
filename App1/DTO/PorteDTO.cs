using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        /// Propriété permettant d'accéder au nom de la porte DTO.
        /// </summary>
        public string nom { get; set; }

        /// <summary>
        /// Propriété permettant d'accéder à la description de la porte DTO.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Propriété permettant d'accéder à la location de la porte DTO.
        /// </summary>
        public string location { get; set; }
        /// <summary>
        /// Propriété permettant d'accéder à l'état de la porte DTO.
        /// </summary>

        public bool actif { get; set; }
    }
}