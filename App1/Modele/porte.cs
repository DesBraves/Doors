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
    /// <summary>
    /// Classe de la porte
    /// </summary>
    class Porte
    {
        
        /// <summary>
        /// Attribut présentant la porte
        /// </summary>
        protected string nom;
        /// <summary>
        /// Propriété permettant d'accéder à la porte et à la modifier.
        /// </summary>
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        /// <summary>
        /// Attribut présentant la description
        /// </summary>
        protected string description;
        /// <summary>
        /// Propriété permettant d'accéder à la description et à la modifier.
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Attribut présentant la location
        /// </summary>
        protected string location;
        /// <summary>
        /// Propriété permettant d'accéder à la location et à la modifier.
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        /// <summary>
        /// Attribut présentant l'activité d'une porte
        /// </summary>
        protected bool actif;
        /// <summary>
        /// Propriété permettant d'accéder à l'activité d'une porte et à la modifier.
        /// </summary>
        public bool Actif
        {
            get { return this.actif; }
            set { this.actif = value; }
        }

        /// <summary>
        /// Constructeur par défaut de la classe Porte
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="description"></param>
        /// <param name="location"></param>
        /// <param name="actif"></param>
        public Porte(string nom = "", string description = "", string location = "", bool actif = false)
        {
            Nom = nom;
            Description = description;
            Location = location;
            Actif = actif;
        }


        /// <summary>
        /// Méthode permettant d'obtenir les informations d'une porte sous forme textuelle.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Le nom de la porte est " + nom + " sa description est " + description + " il est situé au local " + location + "son état est " + actif + ".";
        }
        /// <summary>
        /// Méthode permettant de déterminer si deux portes sont identiques.
        /// </summary>
        /// <param name="obj">objet de comparaison</param>
        /// <returns>true si identique...false si non.</returns>
        public override bool Equals(object obj)
        {
            Porte maPorte = obj as Porte;
            if ((this.Nom.Equals(maPorte.Nom))
                &&
                (this.Description.Equals(maPorte.Description))
                &&
                (this.Location.Equals(maPorte.Location))
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
            return (1 * this.Nom.Length) + (2 * this.Description.Length) + (3 * this.Location.Length);
        }


    }
}