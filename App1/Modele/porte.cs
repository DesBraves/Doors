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
        /// Méthode permettant d'obtenir les informations sur une transaction sous forme textuelle.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Vous avez fait une dépense en date du " + date + "le montant était de "
            + depense + "$ la description de votre achat est " + description;
        }
        /// <summary>
        /// Méthode permettant de déterminer si deux dépenses sont identiques.
        /// </summary>
        /// <param name="obj">objet de comparaison</param>
        /// <returns>true si identique...false si non.</returns>
        public override bool Equals(object obj)
        {
            InfoDepense monInfoDepense = obj as InfoDepense;
            if ((this.Date.Equals(monInfoDepense.Date))
                &&
                (this.Depense.Equals(monInfoDepense.Depense))
                )
                return true;
            return false;
        }

        /// <summary>
        /// Méthode permettant d'obtenir le Hashcode d'une dépense.
        /// </summary>
        /// <returns>Le Hashcode de la dépense.</returns>
        public override int GetHashCode()
        {
            return (1 * this.Date.Length) + (Convert.ToInt32(2 * Depense)) + (3 * this.Description.Length);
        }
    }
}