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
            string id, selecto, selecti, marka, kokalekua, CPU, RAM, idmin,izenamin;
            bool kol;
            Mintegiak min;
            DateOnly er;
            DateTime erosteData;
            List<Gailuak> Lisgai = new List<Gailuak>();

            if(erab.Rola == "MintegiBurua" || erab.Rola == "Irakaslea")
            {
                // Ordenagailuak
                selecto = @"SELECT o.ID, g.marka, g.Kokalekua, o.CPU, o.RAM, g.erosteData, g.IDMintegia, m.izena FROM Inbentarioa.Ordenagailuak o JOIN Inbentarioa.Gailuak g ON o.ID = g.ID WHERE o.ID JOIN Inbentarioa.Mintegiak m ON g.IDMintegia = m.ID IN (SELECT ID FROM Gailuak WHERE IDMintegia = '" + erab.Mintegia.Id +"');";

                // Inprimagailuak
                selecti = @"SELECT i.ID, g.marka, g.Kokalekua, i.Koloretakoa, g.erosteData, g.IDMintegia, m.izena FROM Inbentarioa.Inprimagailuak i JOIN Inbentarioa.Gailuak g ON i.ID = g.ID WHERE i.ID JOIN Inbentarioa.Mintegiak m ON g.IDMintegia = m.ID IN (SELECT ID FROM Gailuak WHERE IDMintegia = '" + erab.Mintegia.Id + "');";

            }
            else
            {
                // Ordenagailuak
                selecto = @"SELECT o.ID, g.marka, g.Kokalekua, o.CPU, o.RAM, g.erosteData, g.IDMintegia, m.izena FROM Inbentarioa.Ordenagailuak o JOIN Inbentarioa.Gailuak g ON o.ID = g.ID JOIN Inbentarioa.Mintegiak m ON g.IDMintegia = m.Id";

                // Inprimagailuak
                selecti = @"SELECT i.ID, g.marka, g.Kokalekua, i.Koloretakoa, g.erosteData, g.IDMintegia, m.izena FROM Inbentarioa.Inprimagailuak i JOIN Inbentarioa.Gailuak g ON i.ID = g.ID JOIN Inbentarioa.Mintegiak m ON g.IDMintegia = m.Id";
            }

            using (MySqlCommand komandua = new MySqlCommand(selecto, DBKonexioa.Konektatu()))
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

            using (MySqlCommand komandua = new MySqlCommand(selecti, DBKonexioa.Konektatu()))
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
            return Lisgai;
        }
        public static int GailuaAldatu(Gailuak ga1, Gailuak be)
        {
            try
            {
                using (MySqlConnection conn = DBKonexioa.Konektatu())
                {
                    string updateBase = @"UPDATE Inbentarioa.Gailuak SET  marka = @marka, kokalekua = @kokalekua, erostedata = @fecha, IDMintegia = @mintegia WHERE ID = @oldId";

                    using (MySqlCommand cmd = new MySqlCommand(updateBase, conn))
                    {
                        cmd.Parameters.AddWithValue("@marka", be.Marka);
                        cmd.Parameters.AddWithValue("@kokalekua", be.Kokalekua);
                        cmd.Parameters.AddWithValue("@fecha", be.ErosteData.ToDateTime(TimeOnly.MinValue));
                        cmd.Parameters.AddWithValue("@mintegia", be.Mintegia.Id);
                        cmd.Parameters.AddWithValue("@oldId", ga1.Id);

                        cmd.ExecuteNonQuery();
                    }
                    if (be is Ordenagailuak or)
                    {
                        string sql = @"UPDATE Inbentarioa.Ordenagailuak SET CPU=@cpu, RAM=@ram WHERE ID=@oldId";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@cpu", or.Cpu);
                            cmd.Parameters.AddWithValue("@ram", or.Ram);
                            cmd.Parameters.AddWithValue("@oldId", ga1.Id);

                            cmd.ExecuteNonQuery();
                        }

                        return 1;
                    }

                    // 🔹 INPRIMAGAILUA
                    if (be is Inprimagailuak inpri)
                    {
                        string sql = @"UPDATE Inbentarioa.Inprimagailuak SET  koloretakoa=@kolor WHERE ID=@oldId";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@kolor", inpri.Koloretakoa ? "Bai" : "Ez");
                            cmd.Parameters.AddWithValue("@oldId", ga1.Id);

                            cmd.ExecuteNonQuery();
                        }

                        return 1;
                    }

                    return 0;
                }
            }
            catch (MySqlException ex)
            {
                return ex.Number;
            }
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
                    inserto = @"INSERT INTO Inbentarioa.Ordenagailuak(ID, CPU, RAM) VALUES (@ID, @CPU, @RAM)";

                    using (MySqlCommand cmd = new MySqlCommand(inserto, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idb);
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
                    inserti = @"INSERT INTO Inbentarioa.Inprimagailuak(ID, koloretakoa) VALUES(@ID, @koloretakoa)";
                    using (MySqlCommand cmd = new MySqlCommand(inserti, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idb);
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
        public static int GailuaEzabatu(Gailuak g)
        {
            string delete, deleteGeneral;
            deleteGeneral = @"DELETE FROM Inbentarioa.Gailuak WHERE ID = @id;";

            try
            {
                using var conn = DBKonexioa.Konektatu();

                using (var cmd = new MySqlCommand(deleteGeneral, conn))
                {
                    cmd.Parameters.AddWithValue("@id", g.Id);
                    cmd.ExecuteNonQuery();
                }

                return 1;
            }
            catch (MySqlException ex)
            {
                return ex.Number;
            }
        }
        public static int EzabatutakoGailuak(Gailuak g)
        {
            string insert, inserto, inserti, update, queryID, idb;
            queryID = @"SELECT CONCAT('E', LPAD(IFNULL(MAX(CAST(SUBSTRING(ID,2) AS UNSIGNED)),0)+1,2,'0')) FROM Ezabatuak";

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand cmd = new MySqlCommand(queryID, conn))
            {
                idb = cmd.ExecuteScalar().ToString();
            }

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            {
                insert = @"INSERT INTO Inbentarioa.Ezabatuak(ID,IDGailua, marka, kokalekua, erostedata, IDMintegia) VALUES (@ID, @IDGailua, @marka, @kokalekua, @erostedata, @IDMintegia)";
                using (MySqlCommand cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idb);
                    cmd.Parameters.AddWithValue("@IDGailua", g.Id);
                    cmd.Parameters.AddWithValue("@marka", g.Marka);
                    cmd.Parameters.AddWithValue("@kokalekua", g.Kokalekua);
                    cmd.Parameters.AddWithValue("@erostedata", g.ErosteData.ToDateTime(TimeOnly.MinValue));
                    cmd.Parameters.AddWithValue("@IDMintegia", g.Mintegia.Id);

                    cmd.ExecuteNonQuery();
                }
                if (g is Ordenagailuak or)
                {
                    inserto = @"INSERT INTO Inbentarioa.Ezabatutako_ordenagailuak(ID, CPU, RAM) VALUES (@ID, @CPU, @RAM)";

                    using (MySqlCommand cmd = new MySqlCommand(inserto, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idb);
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
                    inserti = @"INSERT INTO Inbentarioa.Ezabatutako_inprimagailuak(ID, koloretakoa) VALUES(@ID, @koloretakoa)";
                    using (MySqlCommand cmd = new MySqlCommand(inserti, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idb);
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
    }
}
