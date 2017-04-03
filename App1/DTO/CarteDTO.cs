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
      /// Propriété permettant d'accéder à la description de la Carte DTO.
      /// </summary>
      public string Description { get; set; }

      /// <summary>
      /// Propriété permettant d'accéder au code de la Carte DTO.
      /// </summary>
      public string Code { get; set; }
      /// <summary>
      /// Propriété permettant d'accéder au type de Carte DTO.
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