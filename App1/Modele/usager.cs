// /******************************************************
// Projet :               CTEW_DOOR
// Auteur(e)(s) :         Gabriel Marmen     
// Nom du fichier :       Usager.cs
// Date crée :            2017-03-29
// Date dern. modif. :    2017-04-05
// *******************************************************
//  Historique des modifications
// *******************************************************
//   2017-03-29	Gabriel Marmen          Version non complete.
//   2017-04-05   Philippe Jolicoeur      Complétion version initial, Modifications des propriétées.
//   2017-04-05	Gabriel Marmen          Mise a jour des override et des propriété pour la compatibilité avec la base de données
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

namespace App1.Modele
{
   class Usager
   {
      /// <summary>
      /// Id de l'usager
      /// </summary>
      private int id;
      public int Id { get; set; }
   
      /// <summary>
      /// nom de l'usager
      /// </summary>
      private string nom;
      public string Nom { get; set; }
      
      /// <summary>
      /// prénom de l'usager
      /// </summary>
      private string prenom;
      public string Prenom { get; set; }
      /// <summary>
      /// Liste des cartes de l'usager
      /// </summary>
      private List<Carte> listeCarte;
      public List<Carte> ListeCarte { get; set; }
      /// <summary>
      /// Montre si l'usager est actif
      /// </summary>
      private bool actif;
      public bool Actif { get; set; }
      /// <summary>
      /// Adresse postale de l'usager
      /// </summary>
      private string adresse;
      public string Adresse { get; set; }
      /// <summary>
      /// Adresse courriel de l'usager
      /// </summary>
      private string courriel;
      public string Courriel { get; set; }
      /// <summary>
      /// Numero de téléphone de l'usager
      /// </summary>
      private string telephone;
      public string Telephone { get; set; }

      /// <summary>
      /// Le code keypad de l'utilisateur
      /// </summary>
      private string keyPadCode;
      public string KeyPadCode { get; set; }


      /// <summary>
      /// Le nom d'utilisateur de l'usager
      /// </summary>
      private string nomUsager;
      public string NomUsager { get; set; }

      /// <summary>
      /// Mot de passe de l'utilisateur
      /// </summary>
      private string motDePasse;
      public string MotDePasse { get; set; }
        

      /// <summary>
      /// L'id du departement de l'usager
      /// </summary>
      private int idDepartement;
      public int IdDepartement { get; set; }








        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="listeCarte"></param>
        /// <param name="actif"></param>
        public Usager(string nom, string prenom, string nomUsager,/* List<Carte> listeCarte*/ bool actif, string motDePasse, string keyPadCode, int id, int idDepartement)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Actif = actif;
            this.IdDepartement = idDepartement;
            this.MotDePasse = motDePasse;
            this.KeyPadCode = keyPadCode;
            this.Id = id;
            this.NomUsager = nomUsager;
        }
        /// <summary>
        /// Permet d'activer ou de désactiver un usager. Si l'usager est actif, l'execution de
        /// cette methode le desactiveras et dans le cas contraire elle l'activeras
        /// </summary>
        public void ActiverDesactiver()
        {
            if (this.actif)
            {
                this.actif = false;
            }
            else this.actif = true;
        }

        public string IsActif()
        {
            if (actif)

            {
                return "est actif";
            }
            else
            {
                return "n'est pas actif";
            }
        }
        /// <summary>
        /// Override la fonction equals de l'objet usager
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
         Usager monUsager = obj as Usager;
         if ((this.Nom.Equals(monUsager.Nom))
             &&
             (this.Prenom.Equals(monUsager.Prenom))
             &&
             (this.Actif.Equals(monUsager.Actif))
             &&
             (this.Adresse.Equals(monUsager.Adresse))
              &&
             (this.Courriel.Equals(monUsager.Courriel))
              &&
             (this.Telephone.Equals(monUsager.Telephone))
             )
            return true;
         return false;
      }
      public override int GetHashCode()
      {
         return (1 * this.Nom.Length) + (2 * this.Prenom.Length) + (3 * this.Adresse.Length) + (4 * this.Courriel.Length) + (5 * this.Telephone.Length);
      }




        /// <summary>
        /// Permet d'activer ou de désactiver un usager. Si l'usager est actif, l'execution de
        /// cette methode le desactiveras et dans le cas contraire elle l'activeras
        /// </summary>
        public override string ToString()
        {
            return "L'utlisateur" + this.Prenom + " " + this.Nom + IsActif() + ". Il fait partie du département" + this.IdDepartement + "et a le nom d'usager" + this.nomUsager;
        }

    }
}