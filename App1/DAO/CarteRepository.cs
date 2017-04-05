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
using App1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Door_DAO.DAO
{
   /// <summary>
   /// Classe représentant le répository d'une carte.
   /// </summary>
   class CarteRepository : Repository
    {
        #region Constructeurs

        /// <summary>
        /// Instance unique du repository.
        /// </summary>
        private static CarteRepository instance;

        /// <summary>
        /// Constructeur privée du repository.
        /// </summary>
        private CarteRepository() { }

        /// <summary>
        /// Méthode permettant d'obtenir l'instance unique du repository.
        /// </summary>
        /// <returns>Retourne l'instance unique.</returns>
        public static CarteRepository Instance()
        {
            if (instance == null)
                instance = new CarteRepository();
            return instance;
        }

        #endregion

        #region MethodesService

        /// <summary>
        /// Méthode permettant d'ajouter une carte.
        /// </summary>
        /// <param name="carteDTO">Le DTO de la carte.</param>
        /// <param name="nomOrganisation">Nom de l'organisation.</param>
        public void AjouterCarte(CarteDTO carteDTO, string nomOrganisation="")
        {
            SqlCommand command = new SqlCommand(null, connexion);

            command.CommandText = "INSERT INTO Cartes (NFCCode, TypeCarte, Actif, DateCreation, idOrganisation) " +
                                    "VALUES (@codeNFC, @typeCarte, @actif, @dateCreation, @idOrganisation)";

            SqlParameter codeNFCParam = new SqlParameter("@codeNFC", SqlDbType.VarChar, 8);
            SqlParameter typeCarteParam = new SqlParameter("@typeCarte", SqlDbType.VarChar, 50);
            SqlParameter actifParam = new SqlParameter("@actif", SqlDbType.Bit);
            SqlParameter dateCreationParam = new SqlParameter("@dateCreation", SqlDbType.DateTime);
            SqlParameter idOrganisationParam = new SqlParameter("@idOrganisation", SqlDbType.Int);

            codeNFCParam.Value = carteDTO.NFCCode;
            typeCarteParam.Value = carteDTO.TypeCarte;
            actifParam.Value = carteDTO.Actif;
            dateCreationParam.Value = carteDTO.DateCreation;
            idOrganisationParam.Value = 1; //Par défaut, il y a seulement une organisation pour l'instant !!!

            command.Parameters.Add(codeNFCParam);
            command.Parameters.Add(typeCarteParam);
            command.Parameters.Add(actifParam);
            command.Parameters.Add(dateCreationParam);
            command.Parameters.Add(idOrganisationParam);

            try
            {
                OuvrirConnexion();
                command.Prepare();
                command.ExecuteNonQuery();
                FermerCloseConnexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur lors de l'ajout de la carte...");
                FermerCloseConnexion();
            }
        }

        /// <summary>
        /// Méthode permettant d'obtenir le ID d'une carte selon ses informatiques uniques.
        /// </summary>
        /// <param name="NFCCode">Le code NFC de la carte.</param>
        /// <param name="nomOrganisation">Le nom de l'organisation.</param>
        /// <returns>Le ID de la carte.</returns>
        public int ObtenirIdCarte(string NFCCode, string nomOrganisation="")
        {
            SqlCommand command = new SqlCommand("SELECT idCarte FROM Cartes WHERE NFCCode = @codeNFC AND idOrganisation = @idOrganisation", connexion);

            SqlParameter codeNFCParam = new SqlParameter("@codeNFC", SqlDbType.VarChar, 50);
            SqlParameter idOrganisationParam = new SqlParameter("@idOrganisation", SqlDbType.Int);

            codeNFCParam.Value = NFCCode;
            idOrganisationParam.Value = 1; //Par défaut, il y a seulement une organisation pour l'instant !!!

            command.Parameters.Add(codeNFCParam);
            command.Parameters.Add(idOrganisationParam);

            int Id;

            try
            {
                OuvrirConnexion();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Id = reader.GetInt32(0);
                reader.Close();
                FermerCloseConnexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur lors de l'obtention d'un id de la carte par son CodeNFC et son organisation...");
                FermerCloseConnexion();
                return -1;
            }

            return Id;
        }

        /// <summary>
        /// Méthode permettant d'obtenir une carte selon ses informations uniques.
        /// </summary>
        /// <param name="NFCCode">Code NFC de la carte.</param>
        /// <param name="nomOrganisation">Nom de l'organisation.</param>
        /// <returns>Le DTO de la carte.</returns>
        public CarteDTO ObtenirCarte(string NFCCode, string nomOrganisation="")
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cartes WHERE NFCCode = @codeNFC AND idOrganisation = @idOrganisation", connexion);

            SqlParameter codeNFCParam = new SqlParameter("@codeNFC", SqlDbType.VarChar, 50);
            SqlParameter idOrganisationParam = new SqlParameter("@idOrganisation", SqlDbType.Int);

            codeNFCParam.Value = NFCCode;
            idOrganisationParam.Value = 1; //Par défaut, il y a seulement une organisation pour l'instant !!!

            command.Parameters.Add(codeNFCParam);
            command.Parameters.Add(idOrganisationParam);

            CarteDTO uneCarte;

            try
            {
                OuvrirConnexion();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                uneCarte = new CarteDTO();
                uneCarte.NFCCode = reader.GetString(1);
                uneCarte.TypeCarte = reader.GetString(2);
                uneCarte.Actif = reader.GetBoolean(3);
                uneCarte.DateCreation = reader.GetDateTime(4);
                reader.Close();
                FermerCloseConnexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur lors de l'obtention d'une carte par son NFCCode et son organisation...");
                FermerCloseConnexion();
                return null;
            }

            return uneCarte;
        }

        /// <summary>
        /// Méthode permettant d'obtenir la liste de toutes les cartes.
        /// </summary>
        /// <param name="nomOrganisation">Nom de l'organisation.</param>
        /// <returns>Retourne la liste des DTO des cartes.</returns>
        public List<CarteDTO> ObternirListeCartes(string nomOrganisation="")
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cartes", connexion);

            List<CarteDTO> liste = new List<CarteDTO>();

            try
            {
                OuvrirConnexion();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CarteDTO uneCarte = new CarteDTO();
                    uneCarte.NFCCode = reader.GetString(1);
                    uneCarte.TypeCarte = reader.GetString(2);
                    uneCarte.Actif = reader.GetBoolean(3);
                    uneCarte.DateCreation = reader.GetDateTime(4);
                    liste.Add(uneCarte);
                }
                reader.Close();
                FermerCloseConnexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur lors de l'obtention de la liste des cartes...");
                FermerCloseConnexion();
                return null;
            }
            return liste;
        }

        #endregion
    }
}
