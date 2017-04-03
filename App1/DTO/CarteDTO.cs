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
      /// Propri�t� permettant d'acc�der � la description de la Carte DTO.
      /// </summary>
      public string Description { get; set; }

      /// <summary>
      /// Propri�t� permettant d'acc�der au code de la Carte DTO.
      /// </summary>
      public string Code { get; set; }
      /// <summary>
      /// Propri�t� permettant d'acc�der au type de Carte DTO.
      /// </summary>
      public string Type { get; set; }

      /// <summary>
      /// Constructeur de la classe porteDTO
      /// </summary>
      public CarteDTO(Carte uneCarte)
      {
         this.Actif = uneCarte.Actif;
         this.Description = uneCarte.Description;
         this.Type = uneCarte.Type;
         this.Code = uneCarte.Code;
      }
   }
}