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
        /// L'activit� utilisant l'adapteur.
        /// </summary>
		private Activity context;
        /// <summary>
        /// La structure de donn�es source.
        /// </summary>
		private List<PorteDTO> portes;

        /// <summary>
        /// Contructeur de la classe.
        /// </summary>
        /// <param name="context">L'activit�.</param>
        /// <param name="portes">La source de donn�es.</param>
		public PorteListeAdapteur(Activity context, List<PorteDTO> portes)
        {
            this.context = context;
            this.portes = portes;
        }

        /// <summary>
        /// M�thode permettant d'obtenir un �l�ment de la source de donn�es.
        /// </summary>
        /// <param name="index">Index de l'�l�ment � retourner.</param>
        /// <returns>Retourne l'objet PorteDTO � l'index d�sir�.</returns>
		public override PorteDTO this[int index]
        {
            get { return portes[index]; }
        }

        /// <summary>
        /// M�thode permettant d'obtenir le Id d'un �l�ment selon sa position dans la source de donn�es.
        /// </summary>
        /// <param name="position">La position.</param>
        /// <returns>Retourn le ID.</returns>
		public override long GetItemId(int position)
        {
            return position;
        }

        /// <summary>
        /// M�thode permettant d'obtenir le nombre d'�l�ment dans la source de donn�es.
        /// </summary>
        /// <returns>Le nombre d'�l�ments dans la source de donn�es.</returns>
		public override int Count
        {
            get { return portes.Count; }
        }

        /// <summary>
        /// M�thode permettant de construire une vue pour chacun des �l�ments de la source de donn�es.
        /// </summary>
        /// <param name="position">La position.</param>
        /// <param name="convertView">La vue.</param>
        /// <param name="parent">La vue parente.</param>
        /// <returns>Retourne la vue pour un �l�ment de la source de donn�es.</returns>
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