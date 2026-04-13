using InbentarioaUnmi.DatuModeloak;
using InterAgenda;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                        if (reader.GetString("Koloretakoa") == "Bai")
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
        public static int GailuaAldatu(Gailuak ga1, Gailuak be)
        {
            string update, min;

            min = MintegiaLortu(be.Mintegia.Izena);

            if (be is Ordenagailuak or)
            {
                update = @"UPDATE Inbentarioa.Ordenagailuak SET ID = '" + or.Id + "', marka = '" + or.Marka + "', kokalekua = '" + or.Kokalekua + "', erostedata = '" + or.ErosteData + "', IDMintegia = '" + min + "', CPU = '" + or.Cpu + "', RAM = '" + or.Ram + "' WHERE ID = '" + ga1.Id + "';";
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
            else if (be is Inprimagailuak inpri)
            {
                if (inpri.Koloretakoa)
                {
                    update = @"UPDATE Inbentarioa.Inprimagailuak SET ID = '" + inpri.Id + "', marka = '" + inpri.Marka + "', kokalekua = '" + inpri.Kokalekua + "', erostedata = '" + inpri.ErosteData + "', IDMintegia = '" + min + "', koloretakoa = 'Bai' WHERE ID = '" + ga1.Id + "';";

                }
                else
                {
                    update = @"UPDATE Inbentarioa.Inprimagailuak SET ID = '" + inpri.Id + "', marka = '" + inpri.Marka + "', kokalekua = '" + inpri.Kokalekua + "', erostedata = '" + inpri.ErosteData + "', IDMintegia = '" + min + "', koloretakoa = 'Ez' WHERE ID = '" + ga1.Id + "';";
                }

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
            return 0;
        }
        public static int GailuaGehitu(Gailuak g)
        {
            string inserto = @"INSERT INTO Inbentarioa.Ordenagailuak(ID, marka, kokalekua, erostedata, IDMintegia, CPU, RAM) VALUES(@ID, @marka, @kokalekua, @erostedata, @IDMintegia, @CPU, @RAM)";
            string inserti = @"INSERT INTO Inbentarioa.Inprimagailuak(ID, marka, kokalekua, erostedata, IDMintegia, koloretakoa) VALUES(@ID, @marka, @kokalekua, @erostedata, @IDMintegia, @koloretakoa)";
            string min;
            using (MySqlConnection conn = DBKonexioa.Konektatu())
            {
                conn.Open();
                min = MintegiaLortu(g.Mintegia.Izena);

                if (g is Ordenagailuak or)
                {
                    using (MySqlCommand komandua1 = new MySqlCommand(inserto, conn))
                    {
                        komandua1.Parameters.AddWithValue("@ID", g.Id);
                        komandua1.Parameters.AddWithValue("@marka", g.Marka);
                        komandua1.Parameters.AddWithValue("@kokalekua", g.Kokalekua);
                        komandua1.Parameters.AddWithValue("@erostedata", g.ErosteData);
                        komandua1.Parameters.AddWithValue("@IDMintegia", min);
                        komandua1.Parameters.AddWithValue("@CPU", or.Cpu);
                        komandua1.Parameters.AddWithValue("@RAM", or.Ram);
                        try
                        {
                            komandua1.ExecuteNonQuery();
                            return 1;
                        }
                        catch (MySqlException ex)
                        {
                            return ex.Number;
                        }
                    }
                }
                else if (g is Inprimagailuak inpri)
                {
                    using (MySqlCommand komandua1 = new MySqlCommand(inserti, conn))
                    {
                        komandua1.Parameters.AddWithValue("@ID", g.Id);
                        komandua1.Parameters.AddWithValue("@marka", g.Marka);
                        komandua1.Parameters.AddWithValue("@kokalekua", g.Kokalekua);
                        komandua1.Parameters.AddWithValue("@erostedata", g.ErosteData);
                        komandua1.Parameters.AddWithValue("@IDMintegia", min);
                        if (inpri.Koloretakoa)
                        {
                            komandua1.Parameters.AddWithValue("@koloretakoa", "Bai");
                        }
                        else
                        {
                            komandua1.Parameters.AddWithValue("@koloretakoa", "Ez");
                        }
                        try
                        {
                            komandua1.ExecuteNonQuery();
                            return 1;
                        }
                        catch (MySqlException ex)
                        {
                            return ex.Number;
                        }
                    }
                }
            }
            return 0;
        }
        public static int KontaktuaEzabatu(Gailuak g)
        {
            string delete;
            if (g is Inprimagailuak)
            {
                delete = @"DELETE FROM Inbentarioa.Inprimagailuak WHERE ID = '" + g.Id + "';";
            }
            else
            {
                delete = @"DELETE FROM Inbentarioa.Ordenagailuak WHERE ID = '" + g.Id + "';";
            }
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
        public static string MintegiaLortu(string i)
        {
            string min = null;
            string select = @"SELECT ID FROM Inbentarioa.mintegiak WHERE izena = '" + i + "';";

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            {
                conn.Open();

                using (MySqlCommand komandua = new MySqlCommand(select, conn))
                {
                    komandua.Parameters.AddWithValue("@izena", i);

                    using (MySqlDataReader reader = komandua.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            min = reader.GetString("ID");
                        }
                    }

                }
            }
            return min;
        }
    }
}
