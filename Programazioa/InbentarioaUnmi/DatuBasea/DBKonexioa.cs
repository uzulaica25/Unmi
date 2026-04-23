using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InterAgenda
{
    /// <summary>
    /// Datu basearekin komunikatzeko
    /// </summary>
    public static class DBKonexioa
    {
        private static readonly string konexioa = "server=192.168.80.10;user=Admin;password=1234;database=Inbentarioa;";
        /// <summary>
        /// Datu basea konektatzeko.
        /// </summary>
        public static MySqlConnection Konektatu()
        {
            MySqlConnection conn = new MySqlConnection(konexioa);
            conn.Open();
            return conn;
        }
        /// <summary>
        /// Datu basea deskonektatzeko
        /// </summary>
        public static void Deskonektatu()
        {
            using var conn = new MySqlConnection(konexioa);
            conn.Close();
        }
    }
}

