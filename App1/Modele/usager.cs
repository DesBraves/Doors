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

      public string KeyPadCode { get; set; }

      /// <summary>
      /// Constructeur par défaut
      /// </summary>
      /// <param name="nom"></param>
      /// <param name="prenom"></param>
      /// <param name="listeCarte"></param>
      /// <param name="actif"></param>
      public Usager(string nom, string prenom, List<Carte> listeCarte, bool actif)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.ListeCarte = listeCarte;
            this.Actif = actif;
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

   }
}