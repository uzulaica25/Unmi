using InbentarioaUnmi.DatuModeloak;
using InterAgenda;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
            string select, Izena, Id;
            List<Mintegiak> LisMin = new List<Mintegiak>();

            select = @"SELECT * FROM Inbentarioa.Mintegiak";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Izena = reader.GetString("izena");
                        Id = reader.GetString("ID");
                        Mintegiak min = new Mintegiak(Id, Izena);

                        LisMin.Add(min);
                    }
                }
            }
            return LisMin;
        }
        public static int MintegiakAldatu(string i, string berria)
        {
            string update;

            update = @"UPDATE Inbentarioa.Mintegiak SET izena = '" + berria + "' WHERE ID = '" + i + "';";
            try
            {
                using (MySqlCommand komandua = new MySqlCommand(update, DBKonexioa.Konektatu()))
                {
                    using (MySqlDataReader reader = komandua.ExecuteReader());
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

            insert = @"INSERT INTO Mintegiak (ID, izena) SELECT CONCAT('M', LPAD(IFNULL(MAX(CAST(SUBSTRING(ID,2) AS UNSIGNED)),0) + 1, 2, '0')), @izena FROM Mintegiak;";

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand komandua = new MySqlCommand(insert, conn))
            {
                komandua.Parameters.AddWithValue("@izena", m.Izena);
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

            delete = @"DELETE FROM Inbentarioa.Mintegiak WHERE ID = '" + m.Id + "';";

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
        public static Mintegiak MintegiaBilatu(string i)
        {
            Mintegiak min;
            string select, izena;

            select = @"SELECT * FROM Inbentarioa.Mintegiak WHERE ID = '" + i + "';";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        izena = reader.GetString("izena");
                        min = new Mintegiak(i, izena);
                        return min;
                    }
                }
            }
            return null;
        }
    }
}
