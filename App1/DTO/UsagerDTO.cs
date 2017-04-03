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
        /// fuck off m8
        /// </summary>

        public string nom { get; set; }
        /// <summary>
        /// prénom de l'usager
        /// </summary>

        public string prenom { get; set; }
        /// <summary>
        /// Liste des cartes de l'usager
        /// </summary>

        public List<Carte> listeCarte { get; set; }
        /// <summary>
        /// Montre si l'usager est actif
        /// </summary>

        public bool actif { get; set; }
        /// <summary>
        /// Adresse postale de l'usager
        /// </summary>

        public string adresse { get; set; }
        /// <summary>
        /// Adresse courriel de l'usager
        /// </summary>

        public string courriel{ get; set; }
    /// <summary>
    /// Numero de téléphone de l'usager
    /// </summary>
    public string telephone { get; set; }


        public UsagerDTO(Usager unUsager)
        {
            this.prenom = unUsager.Prenom;
            this.nom = unUsager.Nom;
            this.telephone = unUsager.telephone;
            this.listeCarte = unUsager.ListeCarte;
            this.courriel = unUsager.Courriel;
            this.actif = unUsager.Actif;
            this.adresse = unUsager.Adresse;
        }
    }
}