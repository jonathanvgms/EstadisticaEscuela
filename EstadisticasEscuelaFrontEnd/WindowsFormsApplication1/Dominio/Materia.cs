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
    class Materia : Objeto
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombreMateria;

        public string NombreMateria
        {
            get { return _nombreMateria; }
            set { _nombreMateria = value; }
        }

        private string _turno;

        public string Turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        private string _especialidad;

        public string Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public Materia(string nombreMateria, string turno, string especialidad)
        {
            NombreMateria = nombreMateria;

            Turno = turno;

            Especialidad = especialidad;

            Parametros.Add(new Parametro("@unaMateria", NombreMateria));

            Parametros.Add(new Parametro("@unTurno", Turno));

            Parametros.Add(new Parametro("@unaEspecialidad", Especialidad));

            Tipo = "Materia";
        }

        public Materia(string id, string unNombreMateria, string turno, string especialidad)
            :this (unNombreMateria, turno, especialidad)
            
        {
            Id = id;

            Parametros.Add(new Parametro("@unIdMateria", Id));

            Tipo = "Materia";
        }

        public Materia(string idMateria)
        {
            _id = idMateria;

            Parametros.Add(new Parametro("@unIdMateria", _id));

            Tipo = "Materia";
        }

        private static List<Materia> Select()
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
                    materias.Add(new Materia(myReader["idMateria"].ToString(), myReader["materia"].ToString(), myReader["turno"].ToString(), myReader["especialidad"].ToString()));
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
