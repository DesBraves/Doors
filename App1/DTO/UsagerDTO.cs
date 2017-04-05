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
//   2017-04-05   Gabriel Marmen      Modifications des propriétés et ajout d'un constructeur par défaut
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
        /// Id de l'usager
        /// </summary>
        public int Id { get; set; }

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

        /// <summary>
        /// Code keypad de l'utilisateur
        /// </summary>
        public string KeyPadCode { get; set; }

        /// <summary>
        /// Nom d'utilisateur de l'usager
        /// </summary>
        public string NomUsager { get; set; }

        /// <summary>
        /// Id du departement de l'usager
        /// </summary>
        public int IdDepartement { get; set; }


        /// <summary>
        /// Mot de passe utilisateur
        /// </summary>
        public string MotDePasse { get; set; }

        public UsagerDTO(Usager unUsager)
        {
            this.Prenom = unUsager.Prenom;
            this.Nom = unUsager.Nom;
            //this.Telephone = unUsager.Telephone;
            //this.ListeCarte = unUsager.ListeCarte;
            //this.Courriel = unUsager.Courriel;
            this.Actif = unUsager.Actif;
            //this.Adresse = unUsager.Adresse;
            this.IdDepartement = unUsager.IdDepartement;
            this.NomUsager = unUsager.NomUsager;
            this.KeyPadCode = unUsager.KeyPadCode;
            this.Id = unUsager.Id;
            this.MotDePasse = unUsager.MotDePasse;
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public UsagerDTO()
        {
            this.Prenom = "";
            this.Nom = "";
            //this.Telephone = unUsager.Telephone;
            //this.ListeCarte = unUsager.ListeCarte;
            //this.Courriel = unUsager.Courriel;
            this.Actif = false;
            //this.Adresse = unUsager.Adresse;
            this.IdDepartement = 1;
            this.NomUsager = "";
            this.KeyPadCode = "";
            this.Id = 0;
            this.MotDePasse = "";
        }
    }
}