using InbentarioaUnmi.DatuModeloak;
using InterAgenda;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuBasea
{
    public static class ErabiltzaileaDB
    {
        public static int ErabiltzaileaGehitu(Erabiltzaileak e)
        {
            string insert;

            if (e.Rola == "MintegiBurua")
            {
                insert = @"INSERT INTO Inbentarioa.MintegiBurua(ID, izena, pasahitza, IDMintegia) VALUES(CONCAT('E', LPAD(IFNULL(MAX(CAST(SUBSTRING(ID,2) AS UNSIGNED)),0) + 1, 2, '0')),, @izena, @pasahitza, @Mintegia)";

                using (MySqlConnection conn = DBKonexioa.Konektatu())
                using (MySqlCommand komandua = new MySqlCommand(insert, conn))
                {
                    komandua.Parameters.AddWithValue("@izena", e.Izena);
                    komandua.Parameters.AddWithValue("@pasahitza", e.Pasahitza);
                    komandua.Parameters.AddWithValue("@Mintegia", e.Mintegia);
                    try
                    {
                        komandua.ExecuteNonQuery();
                        return 1;
                    }
                    catch (MySqlException ex)
                    {
                        return ex.Number;
                    }
                }
            }
            else if (e.Rola == "IKTArduraduna")
            {
                insert = @"INSERT INTO Inbentarioa.IKTArduraduna(ID, izena, pasahitza, IDMintegia) VALUES(CONCAT('E', LPAD(IFNULL(MAX(CAST(SUBSTRING(ID,2) AS UNSIGNED)),0) + 1, 2, '0')),, @izena, @pasahitza, @Mintegia)";

                using (MySqlConnection conn = DBKonexioa.Konektatu())
                using (MySqlCommand komandua = new MySqlCommand(insert, conn))
                {
                    komandua.Parameters.AddWithValue("@izena", e.Izena);
                    komandua.Parameters.AddWithValue("@pasahitza", e.Pasahitza);
                    komandua.Parameters.AddWithValue("@Mintegia", e.Mintegia);
                    try
                    {
                        komandua.ExecuteNonQuery();
                        return 1;
                    }
                    catch (MySqlException ex)
                    {
                        return ex.Number;
                    }

                }
            }
            else
            {
                insert = @"INSERT INTO Inbentarioa.Irakaslea(ID, izena, pasahitza, IDMintegia) VALUES(CONCAT('E', LPAD(IFNULL(MAX(CAST(SUBSTRING(ID,2) AS UNSIGNED)),0) + 1, 2, '0')),, @izena, @pasahitza, @Mintegia)";

                using (MySqlConnection conn = DBKonexioa.Konektatu())
                using (MySqlCommand komandua = new MySqlCommand(insert, conn))
                {
                    komandua.Parameters.AddWithValue("@izena", e.Izena);
                    komandua.Parameters.AddWithValue("@pasahitza", e.Pasahitza);
                    komandua.Parameters.AddWithValue("@Mintegia", e.Mintegia);
                    try
                    {
                        komandua.ExecuteNonQuery();
                        return 1;
                    }
                    catch (MySqlException ex)
                    {
                        return ex.Number;
                    }

                }
            }
        }
        public static int ErabiltzaileaAldatu(Erabiltzaileak e, string p)
        {
            string update;

            update = @"UPDATE Inbentarioa.Erabiltzailea SET pasahitza = '" + p + "' WHERE ID = '" + e.Izena + "';";
            try
            {
                using (MySqlCommand komandua = new MySqlCommand(update, DBKonexioa.Konektatu()))
                {
                    using (MySqlDataReader reader = komandua.ExecuteReader()) ;
                }
                return 1;
            }
            catch (MySqlException ex)
            {
                return ex.Number;
            }

        }
        public static int ErabiltzaileaEzabatu(Erabiltzaileak e)
        {
            string delete;

            delete = @"DELETE FROM Inbentarioa.Erabiltzailea WHERE ID = '" + e.Id + "';";

            try
            {
                using (MySqlCommand komandua = new MySqlCommand(delete, DBKonexioa.Konektatu()))
                {
                    using (MySqlDataReader reader = komandua.ExecuteReader()) ;
                }
                return 1;
            }
            catch (MySqlException ex)
            {
                return ex.Number;

            }
        }
        public static List<Erabiltzaileak> ErabiltzaileaZerrendatu()
        {
            string id, select, Izena, Pas, minte, IDmin;
            Mintegiak min;
            List<Erabiltzaileak> LisEr = new List<Erabiltzaileak>();

            // Irakasle motako erabiltzaileak 
            select = @"SELECT i.ID, i.izena as erabil, i.pasahitza, i.IDMintegia, m.izena as mintegia FROM Inbentarioa.Irakaslea i JOIN Inbentarioa.Mintegiak m ON i.IDMintegia = m.ID";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        IDmin = reader.GetString("IDMintegia");
                        minte = reader.GetString("mintegia");
                        min = new Mintegiak(IDmin, minte);
                        Erabiltzaileak era = new Erabiltzaileak(id, Izena, Pas, min, " ");

                        LisEr.Add(era);
                    }
                }
            }

            // Mintegi burua motako erabiltzaileak
            select = @"SELECT i.ID, i.izena as erabil, i.pasahitza, i.IDMintegia, m.izena as mintegia FROM Inbentarioa.MintegiBurua i JOIN Inbentarioa.Mintegiak m ON i.IDMintegia = m.ID";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        IDmin = reader.GetString("IDMintegia");
                        minte = reader.GetString("mintegia");
                        min = new Mintegiak(IDmin, minte);
                        Erabiltzaileak era = new Erabiltzaileak(id, Izena, Pas, min, "MintegiBurua");

                        LisEr.Add(era);
                    }
                }
            }

            // IKT arduraduna motako erabiltzaileak
            select = @"SELECT i.ID, i.izena as erabil, i.pasahitza, i.IDMintegia, m.izena as mintegia FROM Inbentarioa.IKTArduraduna i JOIN Inbentarioa.Mintegiak m ON i.IDMintegia = m.ID";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        IDmin = reader.GetString("IDMintegia");
                        minte = reader.GetString("mintegia");
                        min = new Mintegiak(IDmin, minte);
                        Erabiltzaileak era = new Erabiltzaileak(id, Izena, Pas, min, "IKTArduraduna");

                        LisEr.Add(era);
                    }
                }
            }
            return LisEr;
        }
        public static Erabiltzaileak ErabiltzaileaBilatu(string i, string p)
        {
            string id, select, Izena, Pas, minte, mizena;
            Mintegiak min;
            // Irakasle motako erabiltzaileak 
            select = @"SELECT i.ID, i.izena as erabil, i.pasahitza, i.IDMintegia, m.izena as mintegia FROM Inbentarioa.Irakaslea i JOIN Inbentarioa.Mintegiak m ON i.IDMintegia = m.ID WHERE i.izena = '" + i + "' AND i.pasahitza = '" + p + "';";
            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        minte = reader.GetString("IDMintegia");
                        mizena = reader.GetString("mintegia");
                        min = new Mintegiak(minte, mizena);
                        Erabiltzaileak era = new Erabiltzaileak(id, Izena, Pas, min, " " );
                        return era;
                    }
                }
            }
            // Mintegi burua motako erabiltzaileak
            select = @"SELECT mb.ID, mb.izena as erabil, mb.pasahitza, mb.IDMintegia, m.izena as mintegia FROM Inbentarioa.MintegiBurua mb JOIN Inbentarioa.Mintegiak m ON mb.IDMintegia = m.ID WHERE mb.izena = '" + i + "' AND mb.pasahitza = '" + p + "';";
            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        minte = reader.GetString("IDMintegia");
                        mizena = reader.GetString("mintegia");
                        min = new Mintegiak(minte, mizena);
                        Erabiltzaileak era = new Erabiltzaileak(id, Izena, Pas, min, "MintegiBurua");
                        return era;
                    }
                }
            }
            // IKT arduraduna motako erabiltzaileak
            select = @"SELECT i.ID, i.izena as erabil, i.pasahitza, i.IDMintegia, m.izena as mintegia FROM Inbentarioa.IKTArduraduna i JOIN Inbentarioa.Mintegiak m ON i.IDMintegia = m.ID WHERE i.izena = '" + i + "'  AND i.pasahitza = '" + p + "';";
            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        minte = reader.GetString("IDMintegia");
                        mizena = reader.GetString("mintegia");
                        min = new Mintegiak(minte, mizena);
                        Erabiltzaileak era = new Erabiltzaileak(id, Izena, Pas, min, "IKTArduraduna");
                        return era;
                    }
                }
            }
            return null;
        }
    }
}
