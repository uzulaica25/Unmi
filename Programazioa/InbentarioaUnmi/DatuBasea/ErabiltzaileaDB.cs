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
        public static int KontaktuaGehitu(Kontaktua k)
        {
            string insert;
            insert = @"INSERT INTO Agenda(kontaktua, telefonoa) VALUES(@izena, @telefonoa)";

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand komandua = new MySqlCommand(insert, conn))
            {
                komandua.Parameters.AddWithValue("@izena", k.Izena);
                komandua.Parameters.AddWithValue("@telefonoa", k.Telefonoa);
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
        public static int KontaktuaAldatu(string i, string t)
        {
            string update;

            List<Kontaktua> LisKon = new List<Kontaktua>();
            update = @"UPDATE Agenda SET telefonoa = '" + t + "' WHERE kontaktua = '" + i + "';";
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
        public static int KontaktuaEzabatu(string i)
        {
            string delete;

            List<Kontaktua> LisKon = new List<Kontaktua>();
            delete = @"DELETE FROM Agenda WHERE kontaktua = '" + i + "';";

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
        public static List<Kontaktua> KontaktuaZerrendatu()
        {
            string select, Izena, Tel;
            List<Kontaktua> LisKon = new List<Kontaktua>();

            select = @"SELECT * FROM Agenda";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Izena = reader.GetString("kontaktua");
                        Tel = reader.GetString("telefonoa");
                        Kontaktua kon = new Kontaktua(Izena, Tel);

                        LisKon.Add(kon);
                    }
                }
            }
            return LisKon;
        }
        public static Kontaktua KontaktuaAurkitu(string ize)
        {
            string select, Izena, Tel;

            List<Kontaktua> LisKon = new List<Kontaktua>();
            select = @"SELECT * FROM Agenda WHERE kontaktua = '" + ize + "';";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Izena = reader.GetString("kontaktua");
                        Tel = reader.GetString("telefonoa");
                        Kontaktua kon = new Kontaktua(Izena, Tel);
                        return kon;
                    }
                }
            }
            return null;
        }
    }
}
