// /******************************************************
// Projet :               CTEW_DOOR
// Auteur(e)(s) :         Philippe Jolicoeur     
// Nom du fichier :       Carte.cs
// Date crée :            2017-03-29
// Date dern. modif. :    2017-04-05
// *******************************************************
//  Historique des modifications
// *******************************************************
//   2017-03-29	Philippe Jolicoeur      Version initiale.
//   2017-04-05   Philippe Jolicoeur      Modification des propriétées.
//   2017-04-05     Charles Vaillancourt    Modification de la propriété DateCreation pour obtenir la date système automatiquement.

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
   class Carte
   {
      /// <summary>
      /// Attribut actif : carte active ou inactive
      /// Propriété permettant d'accéder à la description de l'attribut actif et à la modifier.
      /// </summary>
      public bool Actif { get; set; }
      /// <summary>
      /// Attribut code : code de la carte (nfc)
      /// Propriété permettant d'accéder à la description de l'attribut code et à la modifier.
      /// </summary>
      public string Code { get; set; }
        /// <summary>
        /// Attribut description : description de la carte
        /// </summary>
        protected DateTime dateCreation;
        /// <summary>
        /// Propriété permettant d'obtenir la date système au moment de la transaction.
        /// </summary>
        public DateTime DateCreation
        {
            get { return this.dateCreation; }
            set { this.dateCreation = DateTime.Now; }
        }

        /// <summary>
        /// Attribut type : Connaitre le type de carte (nfc, autre)
        /// Propriété permettant d'accéder à la description de l'attribut type et à la modifier.
        /// </summary>
        public string Type { get; set; }

      /// <summary>
      /// Constructeur carte
      /// </summary>
      Carte()
      {
         Actif = false;
         Code = "";
         Type = "";
         DateCreation = "";
      }
      /// <summary>
      /// Constructeur carte
      /// </summary>
      /// <param name="actif"></param>
      /// <param name="code"></param>
      /// <param name="description"></param>
      /// <param name="type"></param>
      Carte(bool actif, string code, string description, string type)
      {
         Actif = actif;
         Code = code;
         Description = description;
         Type = type;
      }


      public override string ToString()
      {
         return "Le type de carte est " + Type + " sa description est " + Description + " sont code est " + Code + "son état est " + Actif + ".";
      }
      /// <summary>
      /// Méthode permettant de déterminer si deux portes sont identiques.
      /// </summary>
      /// <param name="obj">objet de comparaison</param>
      /// <returns>true si identique...false si non.</returns>
      public override bool Equals(object obj)
      {
         Porte maPorte = obj as Porte;
         if ((this.Type.Equals(maPorte.Nom))
             &&
             (this.Description.Equals(maPorte.Description))
             &&
             (this.Code.Equals(maPorte.Location))
             &&
             (this.Actif.Equals(maPorte.Actif))
             )
            return true;
         return false;
      }

      /// <summary>
      /// Méthode permettant d'obtenir le Hashcode d'une porte.
      /// </summary>
      /// <returns>Le Hashcode de la dépense.</returns>
      public override int GetHashCode()
      {
         return (1 * this.Type.Length) + (2 * this.Description.Length) + (3 * this.Code.Length);
      }
   }
}