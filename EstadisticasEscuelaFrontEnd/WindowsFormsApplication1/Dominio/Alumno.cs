using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Alumno : Objeto
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

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private string _legajo;

        public string Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        private string _dni;

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private string _idUsuario;

        public string IdUsuario 
        { 
            get{ return _idUsuario;}
            set { _idUsuario = value; } 
        }

        public Alumno(string nombre, string apellido, string legajo, string dni, string idUsuario)
        {
            Nombre = nombre;

            Apellido = apellido;

            Dni = dni;

            Legajo = legajo;

            IdUsuario = idUsuario;

            Parametros.Add(new Parametro("@unNombre", Nombre));

            Parametros.Add(new Parametro("@unApellido", Apellido));

            Parametros.Add(new Parametro("@unLegajo", Legajo));

            Parametros.Add(new Parametro("@unDNI", Dni));

            Parametros.Add(new Parametro("@unIdUsuario", idUsuario));
            
            Tipo = "Alumno"; 
        }

        public Alumno(string id, string nombre, string apellido, string legajo, string dni,string idUsuario) 
            : this (nombre, apellido, legajo, dni, idUsuario)
        {
            Id = id;

            Parametros.Add(new Parametro("@unIdAlumno", Id));

            Tipo = "Alumno";           
        }

        public Alumno(string idAlumno)
        {
            _id = idAlumno;

            Parametros.Add(new Parametro("@unIdAlumno", _id));

            Tipo = "Alumno";
        }

        public static List<Alumno> Select()
        {
            List<Alumno> alumnos = new List<Alumno>();

            string query = "select * from alumno";

            alumnos = Query(query, alumnos);

            return alumnos;
        }    

        public static List<Alumno> Select(string where)
        {
            List<Alumno> alumnos = new List<Alumno>();

            string query = "select * from alumno " + where;

            alumnos = Query(query, alumnos);

            return alumnos;
        }

        private static List<Alumno> Query(string query, List<Alumno> alumnos)
        {
            MySqlDataReader myReader = null;

            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand command = new MySqlCommand(query, connectionLive);

            try
            {
                connectionLive.Open();

                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    alumnos.Add(new Alumno(myReader["Id"].ToString(), myReader["Nombre"].ToString(), 
                    myReader["Apellido"].ToString(), myReader["Legajo"].ToString(), myReader["Dni"].ToString(), myReader["IdUsuario"].ToString()));
                }

                myReader.Dispose();

                connectionLive.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return alumnos;
        }
    }
}
