using InbentarioaUnmi.DatuModeloak;
using InterAgenda;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace InbentarioaUnmi.DatuBasea
{
    public static class intzidentziakDB
    {
        public static List<Intzidentziak> IntzidentziakZerrendatu(Erabiltzaileak erab)
        {
            string select, mezua, id, mar, kok, ize, ram, cpu, idmin, idIntz;
            bool kolore;
            DateTime dataordua, erostedata;
            DateOnly data, er;
            Ordenagailuak or;
            Inprimagailuak inp;
            Mintegiak min;
            List<Intzidentziak> LisInz = new List<Intzidentziak>();

            if (erab.Rola == "MintegiBurua" || erab.Rola == "Irakaslea")
            {
                // Ordenagailuen itzidentziak
                select = @"SELECT h.ID AS IdIntzi, h.mezua, h.data, o.ID as IdGailua, o.marka, o.kokalekua, o.erostedata,o.IDMintegia, m.izena, o.RAM, o.CPU FROM Inbentarioa.Intzidentziak h JOIN Inbentarioa.Ordenagailuak o ON h.IDGailua = o.ID JOIN Inbentarioa.Mintegiak m ON o.IDMintegia = m.ID WHERE o.ID IN (SELECT ID FROM Gailuak WHERE IDMintegia = '" + erab.Mintegia.Id + "');";

                using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
                {
                    using (MySqlDataReader reader = komandua.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idIntz = reader.GetString("IdIntzi");
                            mezua = reader.GetString("mezua");
                            dataordua = reader.GetDateTime("data");
                            data = DateOnly.FromDateTime(dataordua);
                            id = reader.GetString("IdGailua");
                            mar = reader.GetString("marka");
                            kok = reader.GetString("kokalekua");
                            erostedata = reader.GetDateTime("erostedata");
                            er = DateOnly.FromDateTime(erostedata);
                            ize = reader.GetString("izena");
                            idmin = reader.GetString("IDMintegia");
                            ram = reader.GetString("RAM");
                            cpu = reader.GetString("CPU");

                            min = new Mintegiak(idmin, ize);
                            or = new Ordenagailuak(id, mar, kok, er, min, ram, cpu);
                            Intzidentziak Inz = new Intzidentziak(idIntz, or, "Ordenagailua", data, mezua);

                            LisInz.Add(Inz);
                        }
                    }
                }

                // Inprimagailuen itzidentziak
                select = @"SELECT h.ID AS IdIntzi, h.mezua, h.data, o.ID as IdGailua, o.marka, o.kokalekua, o.erostedata,o.IDMintegia, m.izena, o.Koloretakoa FROM Inbentarioa.Intzidentziak h JOIN Inbentarioa.Inprimagailuak o ON h.IDGailua = o.ID JOIN Inbentarioa.Mintegiak m ON o.IDMintegia = m.ID";

                using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
                {
                    using (MySqlDataReader reader = komandua.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idIntz = reader.GetString("IdIntzi");
                            mezua = reader.GetString("mezua");
                            dataordua = reader.GetDateTime("data");
                            data = DateOnly.FromDateTime(dataordua);
                            id = reader.GetString("IdGailua");
                            mar = reader.GetString("marka");
                            kok = reader.GetString("kokalekua");
                            erostedata = reader.GetDateTime("erostedata");
                            er = DateOnly.FromDateTime(erostedata);
                            ize = reader.GetString("izena");
                            idmin = reader.GetString("IDMintegia");
                            ram = reader.GetString("koloretakoa");
                            if (ram == "Bai")
                            {
                                kolore = true;
                            }
                            else
                            {
                                kolore = false;
                            }

                            min = new Mintegiak(idmin, ize);
                            inp = new Inprimagailuak(id, mar, kok, er, min, kolore);
                            Intzidentziak Inz = new Intzidentziak(idIntz, inp, "Inprimagailua", data, mezua);

                            LisInz.Add(Inz);
                        }
                    }
                }
            }
            else
            {
                // Ordenagailuen itzidentziak
                select = @"SELECT h.ID AS IdIntzi, h.mezua, h.data, o.ID as IdGailua, o.marka, o.kokalekua, o.erostedata,o.IDMintegia, m.izena, o.RAM, o.CPU FROM Inbentarioa.Intzidentziak h JOIN Inbentarioa.Ordenagailuak o ON h.IDGailua = o.ID JOIN Inbentarioa.Mintegiak m ON o.IDMintegia = m.ID";

                using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
                {
                    using (MySqlDataReader reader = komandua.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idIntz = reader.GetString("IdIntzi");
                            mezua = reader.GetString("mezua");
                            dataordua = reader.GetDateTime("data");
                            data = DateOnly.FromDateTime(dataordua);
                            id = reader.GetString("IdGailua");
                            mar = reader.GetString("marka");
                            kok = reader.GetString("kokalekua");
                            erostedata = reader.GetDateTime("erostedata");
                            er = DateOnly.FromDateTime(erostedata);
                            ize = reader.GetString("izena");
                            idmin = reader.GetString("IDMintegia");
                            ram = reader.GetString("RAM");
                            cpu = reader.GetString("CPU");

                            min = new Mintegiak(idmin, ize);
                            or = new Ordenagailuak(id, mar, kok, er, min, ram, cpu);
                            Intzidentziak Inz = new Intzidentziak(idIntz, or, "Ordenagailua", data, mezua);

                            LisInz.Add(Inz);
                        }
                    }
                }

                // Inprimagailuen itzidentziak
                select = @"SELECT h.ID AS IdIntzi, h.mezua, h.data, o.ID as IdGailua, o.marka, o.kokalekua, o.erostedata,o.IDMintegia, m.izena, o.Koloretakoa FROM Inbentarioa.Intzidentziak h JOIN Inbentarioa.Inprimagailuak o ON h.IDGailua = o.ID JOIN Inbentarioa.Mintegiak m ON o.IDMintegia = m.ID";

                using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
                {
                    using (MySqlDataReader reader = komandua.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idIntz = reader.GetString("IdIntzi");
                            mezua = reader.GetString("mezua");
                            dataordua = reader.GetDateTime("data");
                            data = DateOnly.FromDateTime(dataordua);
                            id = reader.GetString("IdGailua");
                            mar = reader.GetString("marka");
                            kok = reader.GetString("kokalekua");
                            erostedata = reader.GetDateTime("erostedata");
                            er = DateOnly.FromDateTime(erostedata);
                            ize = reader.GetString("izena");
                            idmin = reader.GetString("IDMintegia");
                            ram = reader.GetString("koloretakoa");
                            if (ram == "Bai")
                            {
                                kolore = true;
                            }
                            else
                            {
                                kolore = false;
                            }

                            min = new Mintegiak(idmin, ize);
                            inp = new Inprimagailuak(id, mar, kok, er, min, kolore);
                            Intzidentziak Inz = new Intzidentziak(idIntz, inp, "Inprimagailua", data, mezua);

                            LisInz.Add(Inz);
                        }
                    }
                }
            }
            return LisInz;
        }
        public static int IntzidentziaGehitu(Intzidentziak k)
        {
            string insert, queryID, idb;

            queryID = @"SELECT CONCAT('I', LPAD(IFNULL(MAX(CAST(SUBSTRING(ID,2) AS UNSIGNED)),0)+1,2,'0')) FROM Inbentarioa.Intzidentziak";

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand cmd = new MySqlCommand(queryID, conn))
            {
                idb = cmd.ExecuteScalar().ToString();
            }
            insert = @"INSERT INTO Inbentarioa.Intzidentziak(ID, data, mezua, IDGailua) VALUES(@ID, @data, @mezua, @gailua)";

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand komandua = new MySqlCommand(insert, conn))
            {
                komandua.Parameters.AddWithValue("@ID", idb);
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
        public static int IntzidentziaAldatu(Intzidentziak berria, Intzidentziak intzi)
        {
            string update;

            update = @"UPDATE Inbentarioa.Intzidentziak SET IDGailua = @Gailua, mezua = @mezua, data = @data WHERE ID = '" + intzi.Id + "';";
            try
            {
                using (MySqlConnection conn = DBKonexioa.Konektatu())
                {
                    using (MySqlCommand komandua = new MySqlCommand(update, conn))
                    {
                        komandua.Parameters.AddWithValue("@Gailua", berria.Gailua.Id);
                        komandua.Parameters.AddWithValue("@mezua", berria.Mezua);
                        komandua.Parameters.Add("@data", MySqlDbType.Date).Value = berria.Data.ToDateTime(TimeOnly.MinValue);
                        komandua.Parameters.AddWithValue("@oldGailua", intzi.Gailua.Id);

                        komandua.ExecuteNonQuery();
                    }
                }
                return 1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString()); // 👈 para debug real
                return ex.Number;
            }
        }
        public static List<Intzidentziak> IntzidentziaAurkitu(Gailuak gail)
        {
            Intzidentziak Inz;
            string select, mezua, id;
            DateTime dataordua;
            DateOnly data;
            List<Intzidentziak> LisInz = new List<Intzidentziak>();

            select = @"SELECT * FROM Inbentarioa.Intzidentziak WHERE IDGailua = '" + gail.Id + "';";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetString("ID");
                        mezua = reader.GetString("mezua");
                        dataordua = reader.GetDateTime("data");
                        data = DateOnly.FromDateTime(dataordua);
                        if (gail is Ordenagailuak or)
                        {
                            Inz = new Intzidentziak(id, gail, "Ordenagailua", data, mezua);
                        }
                        else
                        {
                            Inz = new Intzidentziak(id, gail,"Inprimagailua", data, mezua);
                        }
                        LisInz.Add(Inz);
                    }
                }
            }
            return LisInz;
        }
        public static int IntzidentziaEzabatu(Intzidentziak intzi)
        {
            string delete;
            delete = @"DELETE FROM Inbentarioa.Intzidentziak WHERE ID = '" + intzi.Id + "';";
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
