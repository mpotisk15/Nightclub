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
            //----------------------------------------------------------------KLIJENTI----------------------------------------------------------------
            String nazivBaze = "skladiste.db";
            await ApplicationData.Current.LocalFolder.CreateFileAsync(nazivBaze, CreationCollisionOption.OpenIfExists); //naziv baze, i funkcija koja ju otvara ako postoji
            String putDoBaze = Path.Combine(ApplicationData.Current.LocalFolder.Path, nazivBaze); //funkcija koja trazi put do baze koja je drugi 
            using (SqliteConnection con = new SqliteConnection($"Filename={putDoBaze}"))
            {
                con.Open();
                String pice = "CREATE TABLE IF NOT EXISTS " +
                                         "Tablica (" +
                                         "userName VARCHAR(25) PRIMARY KEY NOT NULL," +
                                         "userID INT(10) NOT NULL," +
                                         "userNeto INT(10) NOT NULL)";

                SqliteCommand naredbaZaKreiranjePica = new SqliteCommand(pice, con);

                naredbaZaKreiranjePica.ExecuteReader();
                con.Close();

            }
        }

        public static void dodavanjeKlijenta(String userName, Int64 userID, Int64 userNeto)
        {
            String nazivBaze = "skladiste.db";
            if (!userID.Equals("") && !userName.Equals("") && !userNeto.Equals(""))
            {
                string putDoBaze = Path.Combine(ApplicationData.Current.LocalFolder.Path, nazivBaze);
                using (SqliteConnection con = new SqliteConnection($"Filename={putDoBaze}"))
                {
                    con.Open();
                    SqliteCommand naredba_insert = new SqliteCommand();
                    naredba_insert.Connection = con; //konekcija naredbe se nalazi u varijabli con

                    naredba_insert.CommandText = "INSERT INTO Tablica(userName, userID, userNeto) VALUES(@userName, @userID, @userNeto);";
                    naredba_insert.Parameters.AddWithValue("@userName", userName);
                    naredba_insert.Parameters.AddWithValue("@userID", userID);
                    naredba_insert.Parameters.AddWithValue("@userNeto", userNeto);


                    naredba_insert.ExecuteReader();
                    con.Close();
                }
            }
        }

        public static void izbrisi()
        {
            String nazivBaze = "skladiste.db";
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


        public class detaljiPica
        {
            public String userName { get; set; }
            public Int64 userID { get; set; }
            public Int64 userNeto { get; set; }

            public detaljiPica(String userName, Int64 userID, Int64 userNeto)
            {
                this.userName = userName;
                this.userID = userID;
                this.userNeto = userNeto;
            }

        }

        public static List<detaljiPica> DohvatSvihPodataka()
        {
            String nazivBaze = "skladiste.db";

            List<detaljiPica> lista = new List<detaljiPica>();
            String pathToDB = Path.Combine(ApplicationData.Current.LocalFolder.Path, nazivBaze);
            using (SqliteConnection con = new SqliteConnection($"Filename={pathToDB}"))
            {
                con.Open();
                String naredba_select = "SELECT * FROM Tablica";
                SqliteCommand cmd_getAllRec = new SqliteCommand(naredba_select, con);

                SqliteDataReader reader = cmd_getAllRec.ExecuteReader();

                while (reader.Read()) //dok je moguce citati iz baze cita
                {
                    lista.Add(new detaljiPica(reader.GetString(0), reader.GetInt64(1), reader.GetInt64(2)));
                }

                con.Close();
            }
            return lista;
        }


    }
}