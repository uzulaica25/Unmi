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
    public static class MintegiaDB
    {
        public static List<Mintegiak> MintegiakListaratu()
        {
            string select, Izena, Tel;
            List<Mintegiak> LisMin = new List<Mintegiak>();

            select = @"SELECT * FROM Inbentarioa.Mintegiak";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Izena = reader.GetString("Izena");
                        Mintegiak kon = new Mintegiak(Izena);

                        LisMin.Add(kon);
                    }
                }
            }
            return LisMin;
        }
        public static int MintegiakAldatu(string m, string berria)
        {
            string update;

            update = @"UPDATE inbentarioa.Mintegiak SET izena = '" + berria + "' WHERE izena = '" + m + "';";
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
        public static int MintegiakGehitu(Mintegiak m)
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
        public static int MintegiakEzabatu(Mintegiak m)
        {
            string delete;

            delete = @"DELETE FROM Inbentarioa.Mintegiak WHERE izena = '" + m.Izena + "';";

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
    }
}
