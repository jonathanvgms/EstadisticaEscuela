                                                                                                                                                  using System;using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Materia : Objeto
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        
        public Materia(string id, string nombreMateria)
        {
            Id = id;

            Nombre = nombreMateria;
            
            Parametros.Add(new Parametro("@unIdMateria", Id));

            Parametros.Add(new Parametro("@unNombre", Nombre));

            Tipo = "Materia";
        }

     

        public Materia(string nombre)
        {
            Nombre = nombre;

            Parametros.Add(new Parametro("@unNombre", nombre));

            Tipo = "Materia";
        }


        public static List<Materia> Select()
        {
            List<Materia> materia = new List<Materia>();

            string query = "select * from materia";

            materia = Query(query, materia);

            return materia;
        }

        public static List<Materia> Select(string where)
        {
            List<Materia> materia = new List<Materia>();

            string query = "Select * from materia" + where;

            materia = Query(query, materia);

            return materia;
        }

        private static List<Materia> Query(string query, List<Materia> materias)
        {
            MySqlDataReader myReader = null;

            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand comand = new MySqlCommand(query, connectionLive);

            try
            {
                connectionLive.Open();

                myReader = comand.ExecuteReader();

                while (myReader.Read())
                {
                    materias.Add(new Materia(myReader["Id"].ToString(), myReader["Nombre"].ToString()));
                }
                myReader.Dispose();

                connectionLive.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return materias;
        }
    }
}
