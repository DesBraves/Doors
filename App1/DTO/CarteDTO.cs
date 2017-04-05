// /******************************************************
// Projet :               CTEW_DOOR
// Auteur(e)(s) :         Philippe Jolicoeur     
// Nom du fichier :       CarteDTO.cs
// Date crée :            2017-03-29
// Date dern. modif. :    2017-04-05
// *******************************************************
//  Historique des modifications
// *******************************************************
//   2017-03-29	Philippe Jolicoeur      Version initiale.
//   2017-04-05   Philippe Jolicoeur      Modification des propriétées.
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
   class CarteDTO
   {
      /// <summary>
      /// Propriété permettant d'accéder au booléen d'activation de la Carte DTO.
      /// </summary>
      public bool Actif { get; set; }


      /// <summary>
      /// Propriété permettant d'accéder au code de la Carte DTO.
      /// </summary>
      public string NFCCode { get; set; }
      /// <summary>
      /// Propriété permettant d'accéder au type de Carte DTO.
      /// </summary>
      public string TypeCarte { get; set; }

      public DateTime DateCreation { get; set; }

      /// <summary>
      /// Constructeur de la classe porteDTO
      /// </summary>
      public CarteDTO(Carte uneCarte)
      {
         this.Actif = uneCarte.Actif;
         this.TypeCarte = uneCarte.Type;
         this.NFCCode = uneCarte.Code;
         this.DateCreation = uneCarte.DateCreation;
      }
   }
}