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
            string select, mezua, id, mar, kok, ize, ram, cpu;
            bool kolore;
            DateTime dataordua, erostedata;
            DateOnly data, er;
            Ordenagailuak or;
            Inprimagailuak inp;
            Mintegiak min;
            List<Inzidentziak> LisInz = new List<Inzidentziak>();

            // Ordenagailuen izidentziak
            select = @"SELECT h.mezua, h.data, o.ID, o.marka, o.kokalekua, o.erostedata, m.izena, o.RAM, o.CPU FROM Inbentarioa.Historialak h JOIN Inbentarioa.Ordenagailuak o ON h.IDGailua = o.ID JOIN Inbentarioa.Mintegiak m ON o.IDMintegiak = m.ID";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mezua = reader.GetString("mezua");
                        dataordua = reader.GetDateTime("data");
                        data = DateOnly.FromDateTime(dataordua);
                        id = reader.GetString("ID");
                        mar = reader.GetString("marka");
                        kok = reader.GetString("kokalekua");
                        erostedata = reader.GetDateTime("erostedata");
                        er = DateOnly.FromDateTime(erostedata);
                        ize = reader.GetString("izena");
                        ram = reader.GetString("RAM");
                        cpu = reader.GetString("CPU");

                        min = new Mintegiak(ize);
                        or = new Ordenagailuak(id, mar, kok, er, min, ram, cpu);
                        Inzidentziak Inz = new Inzidentziak(or, data, mezua);

                        LisInz.Add(Inz);
                    }
                }
            }

            // Inprimagailuen izidentziak
            select = @"SELECT h.mezua, h.data, o.ID, o.marka, o.kokalekua, o.erostedata, m.izena, o.Koloretakoa FROM Inbentarioa.Historialak h JOIN Inbentarioa.Inprimagailuak o ON h.IDGailua = o.ID JOIN Inbentarioa.Mintegiak m ON o.IDMintegiak = m.ID";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mezua = reader.GetString("mezua");
                        dataordua = reader.GetDateTime("data");
                        data = DateOnly.FromDateTime(dataordua);
                        id = reader.GetString("ID");
                        mar = reader.GetString("marka");
                        kok = reader.GetString("kokalekua");
                        erostedata = reader.GetDateTime("erostedata");
                        er = DateOnly.FromDateTime(erostedata);
                        ize = reader.GetString("izena");
                        ram = reader.GetString("koloretakoa");
                        if(ram == "Bai")
                        {
                            kolore = true;
                        }
                        else
                        {
                            kolore = false;
                        }

                        min = new Mintegiak(ize);
                        inp = new Inprimagailuak(id, mar, kok, er, min, kolore);
                        Inzidentziak Inz = new Inzidentziak(inp, data, mezua);

                        LisInz.Add(Inz);
                    }
                }
            }
            return LisInz;
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
