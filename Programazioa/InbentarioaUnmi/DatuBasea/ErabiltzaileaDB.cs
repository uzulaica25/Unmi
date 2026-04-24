using InbentarioaUnmi.DatuModeloak;
using InbentarioaUnmi.Formularioak;
using InterAgenda;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace InbentarioaUnmi.DatuBasea
{
    /// <summary>
    /// 
    /// </summary>
    public static class ErabiltzaileaDB
    {
        /// <summary>
        /// Erabiltzaileas the zerrendatu.
        /// </summary>
        /// <returns></returns>
        public static List<Erabiltzaileak> ErabiltzaileaZerrendatu()
        {
            string id, select, Izena, Pas, minte, IDmin;
            Mintegiak min;
            List<Erabiltzaileak> LisEr = new List<Erabiltzaileak>();

            // Irakasle motako erabiltzaileak 
            select = @"SELECT i.ID, e.izena as erabil, e.pasahitza, e.IDMintegia, m.izena as mintegia FROM Inbentarioa.Irakaslea i JOIN Inbentarioa.Erabiltzaileak e ON i.ID = e.ID JOIN Inbentarioa.Mintegiak m ON e.IDMintegia = m.ID";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        IDmin = reader.GetString("IDMintegia");
                        minte = reader.GetString("mintegia");
                        min = new Mintegiak(IDmin, minte);
                        Erabiltzaileak era = new Erabiltzaileak(id, Izena, Pas, min, "Irakaslea");

                        LisEr.Add(era);
                    }
                }
            }

            // Mintegi burua motako erabiltzaileak
            select = @"SELECT i.ID, e.izena as erabil, e.pasahitza, e.IDMintegia, m.izena as mintegia FROM Inbentarioa.MintegiBurua i JOIN Inbentarioa.Erabiltzaileak e ON i.ID = e.ID JOIN Inbentarioa.Mintegiak m ON e.IDMintegia = m.ID";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        IDmin = reader.GetString("IDMintegia");
                        minte = reader.GetString("mintegia");
                        min = new Mintegiak(IDmin, minte);
                        Erabiltzaileak era = new Erabiltzaileak(id, Izena, Pas, min, "MintegiBurua");

                        LisEr.Add(era);
                    }
                }
            }

            // IKT arduraduna motako erabiltzaileak
            select = @"SELECT i.ID, e.izena as erabil, e.pasahitza, e.IDMintegia, m.izena as mintegia FROM Inbentarioa.IKTArduraduna i JOIN Inbentarioa.Erabiltzaileak e ON i.ID = e.ID JOIN Inbentarioa.Mintegiak m ON e.IDMintegia = m.ID";

            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        IDmin = reader.GetString("IDMintegia");
                        minte = reader.GetString("mintegia");
                        min = new Mintegiak(IDmin, minte);
                        Erabiltzaileak era = new Erabiltzaileak(id, Izena, Pas, min, "IKTArduraduna");

                        LisEr.Add(era);
                    }
                }
            }
            return LisEr;
        }

        /// <summary>
        /// Erabiltzaileas the gehitu.
        /// </summary>
        /// <param name="e">The e.</param>
        /// <returns></returns>
        public static int ErabiltzaileaGehitu(Erabiltzaileak e)
        {
            string insert, idberria, queryID;

            queryID = @"SELECT CONCAT('U', LPAD(IFNULL(MAX(CAST(SUBSTRING(ID,2) AS UNSIGNED)),0)+1,2,'0')) FROM Erabiltzaileak";

            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand cmd = new MySqlCommand(queryID, conn))
            {
                idberria = cmd.ExecuteScalar().ToString();
            }
            insert = @"INSERT INTO Inbentarioa.Erabiltzaileak(ID, izena, pasahitza, IDMintegia) VALUES(@id, @izena, @pasahitza, @Mintegia)";
            e.Id = idberria;
            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand komandua = new MySqlCommand(insert, conn))
            {
                komandua.Parameters.AddWithValue("@id", e.Id);
                komandua.Parameters.AddWithValue("@izena", e.Izena);
                komandua.Parameters.AddWithValue("@pasahitza", e.Pasahitza);
                komandua.Parameters.AddWithValue("@Mintegia", e.Mintegia.Id);
                komandua.ExecuteNonQuery();
            }
             
            if (e.Rola == "MintegiBurua")
            {
                insert = @"INSERT INTO Inbentarioa.MintegiBurua(ID) VALUES(@id)";
            }
            else if (e.Rola == "IKTArduraduna")
            {
                insert = @"INSERT INTO Inbentarioa.IKTArduraduna(ID) VALUES(@id)";
            }
            else
            {
                insert = @"INSERT INTO Inbentarioa.Irakaslea(ID) VALUES(@id)";
            }
            using (MySqlConnection conn = DBKonexioa.Konektatu())
            using (MySqlCommand komandua = new MySqlCommand(insert, conn))
            {
                komandua.Parameters.AddWithValue("@id", e.Id);
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

        /// <summary>
        /// Erabiltzaileas the aldatu.
        /// </summary>
        /// <param name="e">The e.</param>
        /// <returns></returns>
        public static int ErabiltzaileaAldatu(Erabiltzaileak e)
        {
            string update;

            update = @"UPDATE Inbentarioa.Erabiltzaileak SET izena = @era, pasahitza = @pas, IDMintegia = @min WHERE ID = @id;";
            try
            {
                using var conn = DBKonexioa.Konektatu();

                using (MySqlCommand komandua = new MySqlCommand(update, conn))
                {
                    komandua.Parameters.AddWithValue("@id", e.Id);
                    komandua.Parameters.AddWithValue("@era", e.Izena);
                    komandua.Parameters.AddWithValue("@pas", e.Pasahitza);
                    komandua.Parameters.AddWithValue("@min", e.Mintegia.Id);
                    komandua.ExecuteNonQuery();
                }
                return 1;
            }
            catch (MySqlException ex)
            {
                return ex.Number;
            }

        }

        /// <summary>
        /// Erabiltzaileas the ezabatu.
        /// </summary>
        /// <param name="e">The e.</param>
        /// <returns></returns>
        public static int ErabiltzaileaEzabatu(Erabiltzaileak e)
        {
            string delete;

            delete = @"DELETE FROM Inbentarioa.Erabiltzaileak WHERE ID = @id;";
            try
            {
                using var conn = DBKonexioa.Konektatu();

                using (var cmd = new MySqlCommand(delete, conn))
                {
                    cmd.Parameters.AddWithValue("@id", e.Id);
                    cmd.ExecuteNonQuery();
                }
                return 1;
            }
            catch (MySqlException ex)
            {
                return ex.Number;

            }
        }

        /// <summary>
        /// Erabiltzaileas the bilatu.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <param name="p">The p.</param>
        /// <returns></returns>
        public static Erabiltzaileak ErabiltzaileaBilatu(string i, string p)
        {
            string id, select, Izena, Pas, minte, mizena;
            Mintegiak min;
            Erabiltzaileak era =  null;
            // Irakasle motako erabiltzaileak 
            select = @"SELECT i.ID, e.izena as erabil, e.pasahitza, e.IDMintegia, m.izena as mintegia FROM Inbentarioa.Irakaslea i JOIN Inbentarioa.Erabiltzaileak e ON i.ID = e.ID JOIN Inbentarioa.Mintegiak m ON e.IDMintegia = m.ID WHERE e.izena = '" + i + "' AND e.pasahitza = '" + p + "';";
            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        minte = reader.GetString("IDMintegia");
                        mizena = reader.GetString("mintegia");
                        min = new Mintegiak(minte, mizena);
                        era = new Erabiltzaileak(id, Izena, Pas, min, "Irakaslea" );
                        return era;
                    }
                }
            }
            // Mintegi burua motako erabiltzaileak
            select = @"SELECT mb.ID, e.izena as erabil, e.pasahitza, e.IDMintegia, m.izena as mintegia FROM Inbentarioa.MintegiBurua mb JOIN Inbentarioa.Erabiltzaileak e ON mb.ID = e.ID JOIN Inbentarioa.Mintegiak m ON e.IDMintegia = m.ID WHERE e.izena = '" + i + "' AND e.pasahitza = '" + p + "';";
            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        minte = reader.GetString("IDMintegia");
                        mizena = reader.GetString("mintegia");
                        min = new Mintegiak(minte, mizena);
                        era = new Erabiltzaileak(id, Izena, Pas, min, "MintegiBurua");
                        return era;
                    }
                }
            }
            // IKT arduraduna motako erabiltzaileak
            select = @"SELECT i.ID, e.izena as erabil, e.pasahitza, e.IDMintegia, m.izena as mintegia FROM Inbentarioa.IKTArduraduna i JOIN Inbentarioa.Erabiltzaileak e ON i.ID = e.ID JOIN Inbentarioa.Mintegiak m ON e.IDMintegia = m.ID WHERE e.izena = '" + i + "'  AND e.pasahitza = '" + p + "';";
            using (MySqlCommand komandua = new MySqlCommand(select, DBKonexioa.Konektatu()))
            {
                using (MySqlDataReader reader = komandua.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = reader.GetString("ID");
                        Izena = reader.GetString("erabil");
                        Pas = reader.GetString("pasahitza");
                        minte = reader.GetString("IDMintegia");
                        mizena = reader.GetString("mintegia");
                        min = new Mintegiak(minte, mizena);
                        era = new Erabiltzaileak(id, Izena, Pas, min, "IKTArduraduna");
                        return era;
                    }
                }
            }
            return era;
        }
    }
}
