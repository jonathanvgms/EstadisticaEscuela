using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    static class Orm
    {
        private static string connectionString;
        
        public static List<Objeto> Select(Objeto obj, string where)
        {
            List<Objeto> list = null;

            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand command = new MySqlCommand();

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                connectionLive.Open();

                command.ExecuteNonQuery();

                connectionLive.Close();
            }
            catch (MySqlException ex)
            {

            }

            return list;
        }
                        
        public static void Add(Objeto obj)
        {
            MySqlConnection connectionLive = databaseMySqlConnection();
                        
            MySqlCommand command = new MySqlCommand("agregar" + obj.Tipo, connectionLive);
                        
            command.CommandType = CommandType.StoredProcedure;

            Query(obj, connectionLive, command);
        }
                
        public static void Update(Objeto obj)
        {
            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand command = new MySqlCommand("modificar" + obj.Tipo, connectionLive);
            
            command.CommandType = CommandType.StoredProcedure;

            Query(obj, connectionLive, command);
        }
        
        public static void Delete(Objeto obj)
        {
            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand command = new MySqlCommand("borrar" + obj.Tipo, connectionLive);

            command.CommandType = CommandType.StoredProcedure;

            Query(obj, connectionLive, command);
        }
                
        public static void ConectionString(string server, string port, string database, string user, string password)
        {
            connectionString = "server=" + server + ";user=" + user + ";database=" + database + ";port=" + port + ";password=" + password + ";";
        }

        private static string ConnectionString()
        {
            return connectionString;
        }

        private static MySqlConnection databaseMySqlConnection()
        {
            MySqlConnection con = new MySqlConnection(ConnectionString());
            return con;
        }

        private static void Query(Objeto obj, MySqlConnection con, MySqlCommand com)
        {
            foreach (Parametro param in obj.Parametros)
            {
                com.Parameters.AddWithValue(param.Arg, param.Value);
            }

            try
            {
                con.Open();

                com.ExecuteNonQuery();

                con.Close();
            }
            catch (MySqlException ex)
            {
                
            }
        }
    }
}
