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
    /// Classe représentant le répository d'un usager.
    /// </summary>
    class UsagerRepository : Repository
    {
        #region Constructeurs

        /// <summary>
        /// Instance unique du repository.
        /// </summary>
        private static UsagerRepository instance;

        /// <summary>
        /// Constructeur privée du repository.
        /// </summary>
        private UsagerRepository() { }

        /// <summary>
        /// Méthode permettant d'obtenir l'instance unique du repository.
        /// </summary>
        /// <returns>Retourne l'instance unique.</returns>
        public static UsagerRepository Instance()
        {
            if (instance == null)
                instance = new UsagerRepository();
            return instance;
        }

        #endregion

        #region MethodesService

        /// <summary>
        /// Méthode permettant d'ajouter un usager.
        /// </summary>
        /// <param name="usagerDTO">Le DTO de l'usager.</param>
        /// <param name="nomDepartement">Nom du département.</param>
        public void AjouterUsager(UsagerDTO usagerDTO, string nomDepartement="")
        {
            SqlCommand command = new SqlCommand(null, connexion);

            command.CommandText = "INSERT INTO Usagers (Nom, Prenom, Usager, MotDePasse, KeyPadCode, Actif, idDepartement) " +
                                    "VALUES (@nom, @prenom, @usager, @motDePasse, @keyPadCode, @actif, @idDepartement)";

            SqlParameter nomParam = new SqlParameter("@nom", SqlDbType.VarChar, 50);
            SqlParameter prenomParam = new SqlParameter("@prenom", SqlDbType.VarChar, 50);
            SqlParameter usagerParam = new SqlParameter("@usager", SqlDbType.VarChar, 50);
            SqlParameter motDePasseParam = new SqlParameter("@motDePasse", SqlDbType.VarChar, 50);
            SqlParameter keyPadCodeParam = new SqlParameter("@keyPadCode", SqlDbType.VarChar, 8);
            SqlParameter actifParam = new SqlParameter("@actif", SqlDbType.Bit);
            SqlParameter idDepartementParam = new SqlParameter("@idDepartement", SqlDbType.Int);

            nomParam.Value = usagerDTO.Nom;
            prenomParam.Value = usagerDTO.Prenom;
            usagerParam.Value = usagerDTO.NomUsager;
            motDePasseParam.Value = usagerDTO.MotDePasse;
            keyPadCodeParam.Value = usagerDTO.KeyPadCode;
            actifParam.Value = usagerDTO.Actif;
            idDepartementParam.Value = 1; //Par défaut, il y a seulement un département pour l'instant !!!

            command.Parameters.Add(nomParam);
            command.Parameters.Add(prenomParam);
            command.Parameters.Add(usagerParam);
            command.Parameters.Add(motDePasseParam);
            command.Parameters.Add(keyPadCodeParam);
            command.Parameters.Add(actifParam);
            command.Parameters.Add(idDepartementParam);

            try
            {
                OuvrirConnexion();
                command.Prepare();
                command.ExecuteNonQuery();
                FermerCloseConnexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur lors de l'ajout de l'usager...");
                FermerCloseConnexion();
            }
        }

        /// <summary>
        /// Méthode permettant d'obtenir le ID d'un usager selon ses informatiques uniques.
        /// </summary>
        /// <param name="Nom">Le nom de l'usager.</param>
        /// <param name="Prenom">Le prénom de l'usager.</param>
        /// <param name="nomDepartement">Nom du département.</param>
        /// <returns>Le ID de l'usager.</returns>
        public int ObtenirIdUsager(string nom, string prenom, string nomDepartement="")
        {
            SqlCommand command = new SqlCommand("SELECT idUsager FROM Usagers WHERE Nom = @nom and Prenom = @prenom and idDepartement = @idDepartement", connexion);

            SqlParameter nomParam = new SqlParameter("@nom", SqlDbType.VarChar, 50);
            SqlParameter prenomParam = new SqlParameter("@prenom", SqlDbType.VarChar, 50);
            SqlParameter idDepartementParam = new SqlParameter("@idDepartement", SqlDbType.Int);

            nomParam.Value = nom;
            prenomParam.Value = prenom;
            idDepartementParam.Value = 1; //Par défaut, il y a seulement un département pour l'instant !!!

            command.Parameters.Add(nomParam);
            command.Parameters.Add(prenomParam);
            command.Parameters.Add(idDepartementParam);

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
                Console.WriteLine("Erreur lors de l'obtention d'un id de l'usager par son nom, son prénom et son département...");
                FermerCloseConnexion();
                return -1;
            }

            return Id;
        }

        /// <summary>
        /// Méthode permettant d'obtenir un usager selon ses informations uniques.
        /// </summary>
        /// <param name="nom">Nom de l'usager.</param>
        /// <param name="prenom">Prénom de l'usager.</param>
        /// <param name="nomDepartement">Nom du département.</param>
        /// <returns>Le DTO de l'usager.</returns>
        public UsagerDTO ObtenirUsager(string nom, string prenom, string nomDepartement="")
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Usagers WHERE Nom = @nom AND Prenom = @prenom AND idDepartement = @idDepartement", connexion);

            SqlParameter nomParam = new SqlParameter("@nom", SqlDbType.VarChar, 50);
            SqlParameter prenomParam = new SqlParameter("@prenom", SqlDbType.VarChar, 50);
            SqlParameter idDepartementParam = new SqlParameter("@idDepartement", SqlDbType.Int);

            nomParam.Value = nom;
            prenomParam.Value = prenom;
            idDepartementParam.Value = 1; //Par défaut, il y a seulement un département pour l'instant !!!

            command.Parameters.Add(nomParam);
            command.Parameters.Add(prenomParam);
            command.Parameters.Add(idDepartementParam);

            UsagerDTO unUsager;

            try
            {
                OuvrirConnexion();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                unUsager = new UsagerDTO();
                unUsager.Nom = reader.GetString(1);
                unUsager.Prenom = reader.GetString(2);
                unUsager.NomUsager = reader.GetString(3);
                unUsager.MotDePasse = reader.GetString(4);
                unUsager.KeyPadCode = reader.GetString(5);
                unUsager.Actif = reader.GetBoolean(6);
                reader.Close();
                FermerCloseConnexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur lors de l'obtention d'un usager par son nom, son présnom et son département...");
                FermerCloseConnexion();
                return null;
            }

            return unUsager;
        }

        /// <summary>
        /// Méthode permettant d'obtenir la liste de tous les usagers.
        /// </summary>
        /// <param name="nomDepartement">Nom du département.</param>
        /// <returns>Retourne la liste des DTO des usagers.</returns>
        public List<UsagerDTO> ObternirListeUsagers(string nomDepartement="")
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Usagers", connexion);

            List<UsagerDTO> liste = new List<UsagerDTO>();

            try
            {
                OuvrirConnexion();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UsagerDTO unUsager = new UsagerDTO();
                    unUsager.Nom = reader.GetString(1);
                    unUsager.Prenom = reader.GetString(2);
                    unUsager.NomUsager = reader.GetString(3);
                    unUsager.MotDePasse = reader.GetString(4);
                    unUsager.KeyPadCode = reader.GetString(5);
                    unUsager.Actif = reader.GetBoolean(6);
                    liste.Add(unUsager);
                }
                reader.Close();
                FermerCloseConnexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur lors de l'obtention de la liste des usagers...");
                FermerCloseConnexion();
                return null;
            }
            return liste;
        }

        /// <summary>
        /// Méthode permettant d'associer un usager à une carte.
        /// </summary>
        /// <param name="usagerDTO">Le DTO de l'usager.</param>
        /// <param name="carteDTO">Le DTO de la carte.</param>
        /// <param name="nomDepartementUsager">Le nom du département de l'usager.</param>
        /// <param name="nomOrganisationCarte">Le nom de l'organisation de la carte.</param>
        public void AssocierCarteUsager(UsagerDTO usagerDTO, CarteDTO carteDTO, string nomDepartementUsager = "", string nomOrganisationCarte = "")
        {
            SqlCommand command = new SqlCommand(null, connexion);

            command.CommandText = "INSERT INTO UsagersCartes (idUsager, idCarte, DateCreation) " +
                                    "VALUES (@idUsager, @idCarte, @dateCreation)";

            SqlParameter idUsagerParam = new SqlParameter("@idUsager", SqlDbType.Int);
            SqlParameter idCarteParam = new SqlParameter("@idCarte", SqlDbType.Int);
            SqlParameter dateCreationParam = new SqlParameter("@dateCreation", SqlDbType.DateTime);

            idUsagerParam.Value = Instance().ObtenirIdUsager(usagerDTO.Nom, usagerDTO.Prenom);
            idCarteParam.Value = CarteRepository.Instance().ObtenirIdCarte(carteDTO.NFCCode);
            dateCreationParam.Value = DateTime.Now;

            command.Parameters.Add(idUsagerParam);
            command.Parameters.Add(idCarteParam);
            command.Parameters.Add(dateCreationParam);

            try
            {
                OuvrirConnexion();
                command.Prepare();
                command.ExecuteNonQuery();
                FermerCloseConnexion();
            }
            catch (Exception)
            {
                Console.WriteLine("Erreur lors de l'ajout de l'association entre l'usager et la carte...");
                FermerCloseConnexion();
            }
        }

        #endregion
    }
}
