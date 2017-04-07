using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using App1.DTO;

/// <summary>
/// Namespace contenant les adapteurs.
/// </summary>
namespace BibliothequeFilms2017Complet.Adapteurs
{
    /// <summary>
    /// Adapteur pour une liste d'objets de type PorteAdapteurDTO.
    /// </summary>
	public class PorteListeAdapteur : BaseAdapter<PorteDTO>
    {
        /// <summary>
        /// L'activité utilisant l'adapteur.
        /// </summary>
		private Activity context;
        /// <summary>
        /// La structure de données source.
        /// </summary>
		private List<PorteDTO> portes;

        /// <summary>
        /// Contructeur de la classe.
        /// </summary>
        /// <param name="context">L'activité.</param>
        /// <param name="portes">La source de données.</param>
		public PorteListeAdapteur(Activity context, List<PorteDTO> portes)
        {
            this.context = context;
            this.portes = portes;
        }

        /// <summary>
        /// Méthode permettant d'obtenir un élément de la source de données.
        /// </summary>
        /// <param name="index">Index de l'élément à retourner.</param>
        /// <returns>Retourne l'objet PorteDTO à l'index désiré.</returns>
		public override PorteDTO this[int index]
        {
            get { return portes[index]; }
        }

        /// <summary>
        /// Méthode permettant d'obtenir le Id d'un élément selon sa position dans la source de données.
        /// </summary>
        /// <param name="position">La position.</param>
        /// <returns>Retourn le ID.</returns>
		public override long GetItemId(int position)
        {
            return position;
        }

        /// <summary>
        /// Méthode permettant d'obtenir le nombre d'élément dans la source de données.
        /// </summary>
        /// <returns>Le nombre d'éléments dans la source de données.</returns>
		public override int Count
        {
            get { return portes.Count; }
        }

        /// <summary>
        /// Méthode permettant de construire une vue pour chacun des éléments de la source de données.
        /// </summary>
        /// <param name="position">La position.</param>
        /// <param name="convertView">La vue.</param>
        /// <param name="parent">La vue parente.</param>
        /// <returns>Retourne la vue pour un élément de la source de données.</returns>
		public override View GetView(int position, View convertView, ViewGroup parent)
        {
            PorteDTO item = portes[position];

            View view =
                (convertView ??
                    context.LayoutInflater.Inflate(
                        Resource.Layout.ListePorteItem,
                        parent,
                        false)) as LinearLayout;

            TextView txtNom = view.FindViewById<TextView>(Resource.Id.ContenuNomActeur);
            txtNom.SetText(item.Nom + ", " + item.Prenom, TextView.BufferType.Normal);

            TextView txtAnneeNaissance = view.FindViewById<TextView>(Resource.Id.ContenuAnneeNaissance);
            txtAnneeNaissance.SetText(item.AnneeNaissance.ToString(), TextView.BufferType.Normal);

            TextView txtAnneeDebut = view.FindViewById<TextView>(Resource.Id.ContenuAnneeDebutCinema);
            txtAnneeDebut.SetText(item.AnneeDebutCinema.ToString(), TextView.BufferType.Normal);

            return view;
        }
    }
}