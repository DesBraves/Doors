// /******************************************************
// Projet :               CTEW_DOOR
// Auteur(e)(s) :         Kéven Thériault     
// Nom du fichier :       Repository.cs
// Date crée :            2017-03-29
// Date dern. modif. :    2017-04-05
// *******************************************************
//  Historique des modifications
// *******************************************************
//   2017-03-29	Kéven Thériault         Version initiale.
// *******************************************************/
using System.Data.SqlClient;

namespace Door_DAO.DAO
{
    /// <summary>
    /// Classe représentant un repository.
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// La connexion.
        /// </summary>
        protected SqlConnection connexion;

        /// <summary>
        /// Constructeur de la classe.
        /// </summary>
        public Repository()
        {
            connexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Door;Data Source=localhost");
        }

        /// <summary>
        /// Méthode permettant d'ouvrir la connexion.
        /// </summary>
        protected void OuvrirConnexion()
        {
            connexion.Open();
        }

        /// <summary>
        /// Méthode permettant de fermer la connexion.
        /// </summary>
        protected void FermerCloseConnexion()
        {
            connexion.Close();
        }
    }
}
