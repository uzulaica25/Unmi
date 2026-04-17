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
        public static List<Gailuak> GailuakListaratu(Erabiltzaileak erab)
        {
            string id, select, marka, kokalekua, CPU, RAM, idmin,izenamin;
            bool kol;
            Mintegiak min;
            DateOnly er;
            DateTime erosteData;
            List<Gailuak> Lisgai = new List<Gailuak>();

            if(erab.Rola == "MintegiBurua" || erab.Rola == "Irakaslea")
            {
                select = @"SELECT o.ID, o.marka, o.Kokalekua, o.CPU, o.RAM, o.erosteData, o.IDMintegia, m.izena FROM Inbentarioa.Ordenagailuak o JOIN Inbentarioa.Mintegiak m ON o.IDMintegia = m.ID WHERE o.ID IN (SELECT ID FROM Gailuak WHERE IDMintegia = '"+ erab.Mintegia.Id +"');";

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
                            idmin = reader.GetString("IDMintegia");
                            izenamin = reader.GetString("izena");
                            min = new Mintegiak(idmin, izenamin);

                            Ordenagailuak ga = new Ordenagailuak(id, marka, kokalekua, er, min, CPU, RAM);

                            Lisgai.Add(ga);
                        }
                    }
                }
                select = @"SELECT i.ID, i.marka, i.Kokalekua, i.Koloretakoa, i.erosteData,i.IDMintegia, m.izena FROM Inbentarioa.Inprimagailuak i JOIN Inbentarioa.Mintegiak m ON i.IDMintegia = m.ID WHERE i.ID IN (SELECT ID FROM Gailuak WHERE IDMintegia = '" + erab.Mintegia.Id +"');";

                using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
                {
                    using (MySqlDataReader reader = komandua.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetString("ID");
                            marka = reader.GetString("marka");
                            kokalekua = reader.GetString("kokalekua");
                            erosteData = reader.GetDateTime("erosteData");
                            er = DateOnly.FromDateTime(erosteData);
                            idmin = reader.GetString("IDMintegia");
                            izenamin = reader.GetString("izena");
                            min = new Mintegiak(idmin, izenamin);
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
            }
            else
            {
                select = @"SELECT o.ID, o.marka, o.Kokalekua, o.CPU, o.RAM, o.erosteData, o.IDMintegia, m.izena FROM Inbentarioa.Ordenagailuak o JOIN Inbentarioa.Mintegiak m ON o.IDMintegia = m.Id";

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
                            idmin = reader.GetString("IDMintegia");
                            izenamin = reader.GetString("izena");
                            min = new Mintegiak(idmin, izenamin);

                            Ordenagailuak ga = new Ordenagailuak(id, marka, kokalekua, er, min, CPU, RAM);

                            Lisgai.Add(ga);
                        }
                    }
                }
                select = @"SELECT i.ID, i.marka, i.Kokalekua, i.Koloretakoa, i.erosteData,i.IDMintegia, m.izena FROM Inbentarioa.Inprimagailuak i JOIN Inbentarioa.Mintegiak m ON i.IDMintegia = m.Id";

                using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
                {
                    using (MySqlDataReader reader = komandua.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetString("ID");
                            marka = reader.GetString("marka");
                            kokalekua = reader.GetString("kokalekua");
                            erosteData = reader.GetDateTime("erosteData");
                            er = DateOnly.FromDateTime(erosteData);
                            idmin = reader.GetString("IDMintegia");
                            izenamin = reader.GetString("izena");
                            min = new Mintegiak(idmin, izenamin);
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
            string insert, inserto, inserti, idb, queryID;

            queryID = @"SELECT CONCAT('G', LPAD(IFNULL(MAX(CAST(SUBSTRING(ID,2) AS UNSIGNED)),0)+1,2,'0')) FROM Gailuak";

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand cmd = new MySqlCommand(queryID, conn))
            {
                idb = cmd.ExecuteScalar().ToString();
            }

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            {
                insert  = @"INSERT INTO Inbentarioa.Gailuak(ID, marka, kokalekua, erostedata, IDMintegia) VALUES (@ID, @marka, @kokalekua, @erostedata, @IDMintegia)";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idb);
                    cmd.Parameters.AddWithValue("@marka", g.Marka);
                    cmd.Parameters.AddWithValue("@kokalekua", g.Kokalekua);
                    cmd.Parameters.AddWithValue("@erostedata", g.ErosteData.ToDateTime(TimeOnly.MinValue));
                    cmd.Parameters.AddWithValue("@IDMintegia", g.Mintegia.Id);

                    cmd.ExecuteNonQuery();
                }
                if (g is Ordenagailuak or)
                {
                    inserto = @"INSERT INTO Inbentarioa.Ordenagailuak(ID, marka, kokalekua, erostedata, IDMintegia, CPU, RAM) VALUES (@ID, @marka, @kokalekua, @erostedata, @IDMintegia, @CPU, @RAM)";

                    using (MySqlCommand cmd = new MySqlCommand(inserto, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idb);
                        cmd.Parameters.AddWithValue("@marka", g.Marka);
                        cmd.Parameters.AddWithValue("@kokalekua", g.Kokalekua);
                        cmd.Parameters.AddWithValue("@erostedata", g.ErosteData.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@IDMintegia", g.Mintegia.Id);
                        cmd.Parameters.AddWithValue("@CPU", or.Cpu);
                        cmd.Parameters.AddWithValue("@RAM", or.Ram);

                        try
                        {
                            cmd.ExecuteNonQuery();
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
                    inserti = @"INSERT INTO Inbentarioa.Inprimagailuak(ID, marka, kokalekua, erostedata, IDMintegia, koloretakoa) VALUES(@ID, @marka, @kokalekua, @erostedata, @IDMintegia, @koloretakoa)";
                    using (MySqlCommand cmd = new MySqlCommand(inserti, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idb);
                        cmd.Parameters.AddWithValue("@marka", g.Marka);
                        cmd.Parameters.AddWithValue("@kokalekua", g.Kokalekua);
                        cmd.Parameters.AddWithValue("@erostedata", g.ErosteData.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@IDMintegia", inpri.Mintegia.Id);
                        if (inpri.Koloretakoa)
                        {
                            cmd.Parameters.AddWithValue("@koloretakoa", "Bai");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@koloretakoa", "Ez");
                        }

                        try
                        {
                            cmd.ExecuteNonQuery();
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
