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
    public static class InbentarioaDB
    {
        /* Gailuak listaratu bakarrik dao mas o menos jarrita baino definitzia falta da gailuak gehitu ta aldatzian nola bereiztu ze gailu mota dan.
         * 
         * DB klaseak txukun jartzeko daude InbentarioaDB, ErabiltzaileaDB, InzidentzianDB, KontaktuakDB kodea dake.
         * KontaktuaZerrendatu Selecta ondo definitzeko nola itean. FMintegia erdi kodifikatzen hasita.
        */
        public static List<Gailuak> GailuakListaratu()
        {
            string id, select, marka, kokalekua, CPU, RAM;
            bool kol;
            Mintegiak min;
            DateOnly er;
            DateTime erosteData;
            List<Gailuak> Lisgai = new List<Gailuak>();

            select = @"SELECT o.ID, o.marka, o.Kokalekua, o.CPU, o.RAM, o.erosteData, m.izena FROM Inbentarioa.Ordenagailuak o JOIN Inbentarioa.Mintegiak m ON o.IDMintegiak = m.Id";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetString("ID");
                        marka = reader.GetString("marka");
                        kokalekua = reader.GetString("kokalekua");
                        CPU = reader.GetString("CPU");
                        RAM = reader.GetString("RAM");
                        erosteData = reader.GetDateTime("erosteData");
                        er = DateOnly.FromDateTime(erosteData);
                        min = new Mintegiak(reader.GetString("izena"));

                        Ordenagailuak ga = new Ordenagailuak(id, marka, kokalekua, er, min, CPU, RAM);

                        Lisgai.Add(ga);
                    }
                }
            }
            select = @"SELECT i.ID, i.marka, i.Kokalekua, i.Koloretakoa, i.erosteData, m.izena FROM Inbentarioa.Inprimagailuak i JOIN Inbentarioa.Mintegiak m ON o.IDMintegiak = m.Id";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetString("ID");
                        marka = reader.GetString("marka");
                        kokalekua = reader.GetString("kokalekua");
                        CPU = reader.GetString("CPU");
                        erosteData = reader.GetDateTime("erosteData");
                        er = DateOnly.FromDateTime(erosteData);
                        min = new Mintegiak(reader.GetString("izena"));
                        if(reader.GetString("Koloretakoa") == "Bai")
                        {
                            kol = true;
                        }
                        else
                        {
                            kol = false;
                        }
                        Inprimagailuak ga = new Inprimagailuak(id, marka, kokalekua, er, min, kol);

                        Lisgai.Add(ga);
                    }
                }
            }
            return Lisgai;
        }
        public static int GailuaAldatu(Gailuak ga1, Gailuak berri)
        {
            string update;

            update = @"UPDATE Inbentarioa SET telefonoa = '" + t + "' WHERE kontaktua = '" + i + "';";
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



        public static int KontaktuaGehitu(Gailuak g)
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
