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
        /// Propri�t� permettant d'acc�der au nom de la porte DTO.
        /// </summary>
        public string nom { get; set; }

        /// <summary>
        /// Propri�t� permettant d'acc�der � la description de la porte DTO.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Propri�t� permettant d'acc�der � la location de la porte DTO.
        /// </summary>
        public string location { get; set; }
        /// <summary>
        /// Propri�t� permettant d'acc�der � l'�tat de la porte DTO.
        /// </summary>

        public bool actif { get; set; }
    }
}