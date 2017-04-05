// /******************************************************
// Projet :               CTEW_DOOR
// Auteur(e)(s) :         Gabriel Marmen     
// Nom du fichier :       UsagerDTO.cs
// Date crée :            2017-03-29
// Date dern. modif. :    2017-04-05
// *******************************************************
//  Historique des modifications
// *******************************************************
//   2017-03-29	Gabriel Marmen          Version non complete.
//   2017-04-05   Philippe Jolicoeur      Modifications des propriétées.
// *******************************************************/
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
using App1.Modele;

namespace App1.DTO
{
    class UsagerDTO
    {
        /// <summary>
        /// nom de l'usager
        /// 
        /// </summary>

        public string Nom { get; set; }
        /// <summary>
        /// prénom de l'usager
        /// </summary>

        public string Prenom { get; set; }
        /// <summary>
        /// Liste des cartes de l'usager
        /// </summary>

        public List<Carte> ListeCarte { get; set; }
        /// <summary>
        /// Montre si l'usager est actif
        /// </summary>

        public bool Actif { get; set; }
        /// <summary>
        /// Adresse postale de l'usager
        /// </summary>

        public string Adresse { get; set; }
        /// <summary>
        /// Adresse courriel de l'usager
        /// </summary>

        public string Courriel { get; set; }
        /// <summary>
        /// Numero de téléphone de l'usager
        /// </summary>
        public string Telephone { get; set; }


        public UsagerDTO(Usager unUsager)
        {
            this.Prenom = unUsager.Prenom;
            this.Nom = unUsager.Nom;
            this.Telephone = unUsager.telephone;
            this.ListeCarte = unUsager.ListeCarte;
            this.Courriel = unUsager.Courriel;
            this.Actif = unUsager.Actif;
            this.Adresse = unUsager.Adresse;
        }
    }
}