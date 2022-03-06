﻿using System;
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


        public static void addRecord(string Name, Int64 ID, Int64 Neto)
        {
            if (!Name.Equals("") && !ID.Equals("") && !Neto.Equals("") )
            {
                string pathToDB = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");

                using (SqliteConnection con = new SqliteConnection($"Filename={pathToDB}"))
                {
                    con.Open();
                    SqliteCommand CMD_Insert = new SqliteCommand();
                    CMD_Insert.Connection = con;

                    CMD_Insert.CommandText = "INSERT INTO Tablica VALUES(@userName,@userID, @userNeto);";
                    //CMD_Insert.CommandText = "DROP TABLE Tablica";
                    CMD_Insert.Parameters.AddWithValue("@userName", Name);
                    CMD_Insert.Parameters.AddWithValue("@userID", ID);
                    CMD_Insert.Parameters.AddWithValue("@userNeto", Neto);

                    CMD_Insert.ExecuteReader();

                    con.Close();


                }
            }
        }

        public class userDetails
        {
            private string v1;
            private string v2;

            public String Name { get; set; }
            public int ID { get; set; }
            public int Neto { get; set; }
            public userDetails(string userName, int userID, int userNeto)
            {
                Name = userName;
                ID = userID;
                Neto = userNeto;
            }

            public userDetails(string v1, string v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }
        }
        public static List<userDetails> GetRecords()
        {
            List<userDetails> userList = new List<userDetails>();
            string pathToDB = Path.Combine(ApplicationData.Current.LocalFolder.Path, "userData.db");

            using (SqliteConnection con = new SqliteConnection($"Filename={pathToDB}"))
            {
                con.Open();

                string selectCmd = "SELECT * FROM Tablica";
                SqliteCommand cmd_getRec = new SqliteCommand(selectCmd, con);

                SqliteDataReader reader = cmd_getRec.ExecuteReader();

                while (reader.Read())
                {
                    userList.Add(new userDetails(reader.GetString(0), reader.GetString(1)));
                }

                con.Close();
            }
            return userList;
        }
        public static void izbrisi()
        {
            String baza = "userData.db";
            String pathToDB = Path.Combine(ApplicationData.Current.LocalFolder.Path, baza);

            using (SqliteConnection con = new SqliteConnection($"Filename={pathToDB}"))
            {
                con.Open();
                String delete = "DELETE FROM Tablica";
                SqliteCommand cmd_getAllRec = new SqliteCommand(delete, con);
                SqliteDataReader reader = cmd_getAllRec.ExecuteReader();
                con.Close();
            }
        }
    }
}
