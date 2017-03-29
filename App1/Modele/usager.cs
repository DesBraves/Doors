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
        private string nom;
        public string Nom { get; set; }

        private string prenom;
        public string Prenom { get; set; }

        private List<Carte> listeCarte;
        public int NombreCartes { get; set; }

        private bool actif;
        public bool Actif { get; set; }




        public Usager(string nom, string prenom, int nombreCartes, bool actif)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.nombreCartes = nombreCartes;
            this.actif = actif;
        }

        public void ActiverDesactiver()
        {
            if (this.actif)
            {
                this.actif = false;
            }
            else this.actif = true;
        }
    }
}