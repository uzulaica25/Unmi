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

            if(e.MinBurua)
            {
                insert = @"INSERT INTO Inbentarioa.MintegiBurua(ID, izena, pasahitza, IDMintegia) VALUES(@ID, @izena, @pasahitza, @Mintegia)";

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
            }else if (e.IktArduraduna)
            {
                insert = @"INSERT INTO Inbentarioa.IKTArduraduna(ID, izena, pasahitza, IDMintegia) VALUES(@ID, @izena, @pasahitza, @Mintegia)";

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
                insert = @"INSERT INTO Inbentarioa.Irakaslea(ID, izena, pasahitza, IDMintegia) VALUES(@ID, @izena, @pasahitza, @Mintegia)";

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
        public static int ErabiltzaileaAldatu(string e, string p)
        {
            string update;

            update = @"UPDATE Inbentarioa.Erabiltzailea SET pasahitza = '" + p + "' WHERE izena = '" + e + "';";
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
        public static int ErabiltzaileaEzabatu(string i)
        {
            string delete;

            delete = @"DELETE FROM Inbentarioa.Erabiltzailea WHERE ID = '" + i + "';";

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
        public static List<Erabiltzaileak> KontaktuaZerrendatu()
        {
            string select, Izena, Pas, minte;
            Mintegiak min;
            List<Erabiltzaileak> LisEr = new List<Erabiltzaileak>();

            // Irakasle motako erabiltzaileak 
            select = @"SELECT * FROM Inbentarioa.Irakaslea";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Izena = reader.GetString("izena");
                        Pas = reader.GetString("pasahitza");
                        minte = reader.GetString("IDMintegia");
                        min = new Mintegiak(minte);
                        Erabiltzaileak era = new Erabiltzaileak(Izena, Pas, min, false, false);

                        LisEr.Add(era);
                    }
                }
            }

            // Mintegi burua motako erabiltzaileak
            select = @"SELECT * FROM Inbentarioa.MintegiBurua";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Izena = reader.GetString("izena");
                        Pas = reader.GetString("pasahitza");
                        minte = reader.GetString("IDMintegia");
                        min = new Mintegiak(minte);
                        Erabiltzaileak era = new Erabiltzaileak(Izena, Pas, min, true, false);

                        LisEr.Add(era);
                    }
                }
            }

            // IKT arduraduna motako erabiltzaileak
            select = @"SELECT * FROM Inbentarioa.IKTArduraduna";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Izena = reader.GetString("izena");
                        Pas = reader.GetString("pasahitza");
                        minte = reader.GetString("IDMintegia");
                        min = new Mintegiak(minte);
                        Erabiltzaileak era = new Erabiltzaileak(Izena, Pas, min, false, true);

                        LisEr.Add(era);
                    }
                }
            }
            return LisEr;
        }
    }
}
