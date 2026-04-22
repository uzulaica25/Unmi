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
        public static int MintegiakAldatu(Mintegiak m)
        {
            string update;

            update = @"UPDATE Inbentarioa.Mintegiak SET izena = @izena WHERE ID = @id;";
            try
            {
                using (MySqlConnection conn = DBKonexioa.Konektatu())
                using (MySqlCommand komandua = new MySqlCommand(update, conn))
                {
                    komandua.Parameters.AddWithValue("@id", m.Id);
                    komandua.Parameters.AddWithValue("@izena", m.Izena);
                    komandua.ExecuteNonQuery();
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

            delete = @"DELETE FROM Inbentarioa.Mintegiak WHERE ID = @id;";

            try
            {
                using var conn = DBKonexioa.Konektatu();

                using (var cmd = new MySqlCommand(delete, conn))
                {
                    cmd.Parameters.AddWithValue("@id", m.Id);
                    cmd.ExecuteNonQuery();
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
            Mintegiak min = null;
            string select, id;
                select = @"SELECT * FROM Inbentarioa.Mintegiak WHERE izena = @izena;";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                komandua.Parameters.AddWithValue("@izena", i);

                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetString("ID");
                        min = new Mintegiak(id, i);
                    }
                }
            }
            return min;
        }
    }
}
