// /******************************************************
// Projet :               CTEW_DOOR
// Auteur(e)(s) :         Charles Vaillancourt     
// Nom du fichier :       PorteDTO.cs
// Date crée :            2017-03-29
// Date dern. modif. :    2017-04-05
// *******************************************************
//  Historique des modifications
// *******************************************************
//   2017-03-29	Charles Vaillancourt          Version initial.
// *******************************************************/
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
    public class PorteDTO
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

        /// <summary>
        /// Constructeur de la classe porteDTO
        /// </summary>
        public PorteDTO(Porte unePorte)
        {
            this.actif = unePorte.Actif;
            this.description = unePorte.Description;
            this.location = unePorte.Location;
            this.nom = unePorte.Nom;
        }
    }
}