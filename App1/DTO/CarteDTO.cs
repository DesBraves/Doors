// /******************************************************
// Projet :               CTEW_DOOR
// Auteur(e)(s) :         Philippe Jolicoeur     
// Nom du fichier :       CarteDTO.cs
// Date cr�e :            2017-03-29
// Date dern. modif. :    2017-04-05
// *******************************************************
//  Historique des modifications
// *******************************************************
//   2017-03-29	Philippe Jolicoeur      Version initiale.
//   2017-04-05   Philippe Jolicoeur      Modification des propri�t�es.
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
      /// Propri�t� permettant d'acc�der au bool�en d'activation de la Carte DTO.
      /// </summary>
      public bool Actif { get; set; }


      /// <summary>
      /// Propri�t� permettant d'acc�der au code de la Carte DTO.
      /// </summary>
      public string NFCCode { get; set; }
      /// <summary>
      /// Propri�t� permettant d'acc�der au type de Carte DTO.
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