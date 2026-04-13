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
    public static class inzidentziakDB
    {
        public static int InzidentziaGehitu(Inzidentziak k)
        {
            // Id nola jarri erabakitzia falta da
            string insert;
            insert = @"INSERT INTO Inzidentzia.Historiala(ID, data, mezua, IDGailua) VALUES(@ID, @data, @mezua, @gailua)";

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand komandua = new MySqlCommand(insert, conn))
            {
                komandua.Parameters.AddWithValue("@Id", "");
                komandua.Parameters.AddWithValue("@data", DateTime.Now);
                komandua.Parameters.AddWithValue("@mezua", k.Mezua);
                komandua.Parameters.AddWithValue("@gailua", k.Gailua.Id);
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
        public static int InzidentziaAldatu(Gailuak gail, string m)
        {
            string update;

            update = @"UPDATE Inbentarioa.Historiala SET mezua = '" + m + "' WHERE IDGailua = '" + gail.Id + "';";
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
        public static List<Inzidentziak> InzidentziaZerrendatu()
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
        public static List<Inzidentziak> InzidentziaAurkitu(Gailuak gail)
        {
            string select, mezua;
            DateTime dataordua;
            DateOnly data;
            List<Inzidentziak> LisInz = new List<Inzidentziak>();

            select = @"SELECT * FROM Inbentarioa.Historiala WHERE IDGailua = '" + gail.Id + "';";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mezua = reader.GetString("mezua");
                        dataordua = reader.GetDateTime("data");
                        data = DateOnly.FromDateTime(dataordua);
                        Inzidentziak Inz = new Inzidentziak(gail, data, mezua);
                        LisInz.Add(Inz);
                    }
                }
            }
            return LisInz;
        }
    }
}
