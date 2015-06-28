using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Alumno : Objeto
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private string legajo;

        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public Alumno(string unNombre, string unApellido, string unLegajo, string unDni)
        {
            Nombre = unNombre;

            Apellido = unApellido;

            Dni = unDni;

            Legajo = unLegajo;

            Parametros.Add(new Parametro("@unNombre", nombre));

            Parametros.Add(new Parametro("@unApellido", apellido));

            Parametros.Add(new Parametro("@unLegajo", legajo));

            Parametros.Add(new Parametro("@unDni", dni));

            Tipo = "Alumno";
        }

        public static List<Alumno> Select()
        {
            List<Alumno> alumnos = new List<Alumno>();

            string query = "select * from alumno";

            MySqlDataReader myReader = null;

            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand command = new MySqlCommand(query, connectionLive);

            connectionLive.Open();

            myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                alumnos.Add(new Alumno(myReader["nombre"].ToString(), myReader["apellido"].ToString(), myReader["legajo"].ToString(), myReader["dni"].ToString()));
            }

            myReader.Dispose();

            connectionLive.Close();

            return alumnos;
        }    
    }
}
