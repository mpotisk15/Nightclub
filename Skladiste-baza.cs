using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Windows.Storage;

namespace Nightclub
{
    class Skladiste_baza
    {
        public Skladiste_baza()
        {
            InitializeDB();
        }

        public async static void InitializeDB()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("userData.db", CreationCollisionOption.OpenIfExists);
            string pathToDB = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");

            using (SqliteConnection con = new SqliteConnection($"Filename={pathToDB}"))
            {
                con.Open();
                String initCMD = "CREATE TABLE IF NOT EXISTS " +
                                        "Tablica (" +
                                        "userName VARCHAR(50) PRIMARY KEY NOT NULL," +
                                        "userID INT (50) NOT NULL," +
                                        "userNeto INT (10) NOT NULL)";
                SqliteCommand CMDcreateTable = new SqliteCommand(initCMD, con);
                CMDcreateTable.ExecuteReader();
                con.Close();
            }
        }

        public static void dodavanjePica(String userName, Int64 userID, Int64 userNeto)
        {
            String nazivBaze = "userData.db";
            if (!userName.Equals("") && !userID.Equals("") && !userNeto.Equals(""))
            {
                String putDoBaze = Path.Combine(ApplicationData.Current.LocalFolder.Path, nazivBaze);
                using (SqliteConnection con = new SqliteConnection($"Filename={putDoBaze}"))
                {
                    con.Open();
                    SqliteCommand naredba_insert = new SqliteCommand();
                    naredba_insert.Connection = con; //konekcija naredbe se nalazi u varijabli con

                    naredba_insert.CommandText = "INSERT INTO Tablica(userName, userID, userNeto) VALUES(@userName, @userID, @userNeto);";
                    naredba_insert.Parameters.AddWithValue("@userName", userName);
                    naredba_insert.Parameters.AddWithValue("@userID", userID);
                    naredba_insert.Parameters.AddWithValue("@userNeto", userNeto);

                    con.Close();
                }
            }
        }

        public class detaljiSkladista
        {
            public String userName { get; set; }
            public Int64 userID { get; set; }
            public Int64 userNeto { get; set; }


            public detaljiSkladista(String userName, Int64 userID, Int64 userNeto)
            {
                this.userName = userName;
                this.userID = userID;
                this.userNeto = userNeto;
            }

        }

        public static void izbrisi()
        {
            String nazivBaze = "userData.db";
            String pathToDB = Path.Combine(ApplicationData.Current.LocalFolder.Path, nazivBaze);

            using (SqliteConnection con = new SqliteConnection($"Filename={pathToDB}"))
            {
                con.Open();
                String naredba_delete = "DELETE FROM Tablica";
                SqliteCommand cmd_getAllRec = new SqliteCommand(naredba_delete, con);
                SqliteDataReader reader = cmd_getAllRec.ExecuteReader();
                con.Close();
            }
        }

        public static List<detaljiSkladista> DohvatSvihPodataka()
        {
            String nazivBaze = "userData.db";

            List<detaljiSkladista> skladisteList = new List<detaljiSkladista>();
            String pathToDB = Path.Combine(ApplicationData.Current.LocalFolder.Path, nazivBaze);
            using (SqliteConnection con = new SqliteConnection($"Filename={pathToDB}"))
            {
                con.Open();
                String naredba_select = "SELECT * FROM Tablica";
                SqliteCommand cmd_getAllRec = new SqliteCommand(naredba_select, con);

                SqliteDataReader reader = cmd_getAllRec.ExecuteReader();

                while (reader.Read()) //dok je moguce citati iz baze cita
                {
                    skladisteList.Add(new detaljiSkladista(reader.GetString(0), reader.GetInt64(1), reader.GetInt64(2)));
                }

                con.Close();
            }
            return skladisteList;
        }


    }
}