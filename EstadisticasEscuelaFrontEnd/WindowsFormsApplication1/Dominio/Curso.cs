using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Curso : Objeto
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        private string _anio;

        public string Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }

        private string _division;

        public string Division
        {
            get{ return _division; }
            set { _division = value; }
        }
      
        private string _idTurno;

        public string IdTurno
        {
            get { return _idTurno; }
            set { _idTurno = value; }
        }

        private string _idEspecialidad;

        public string IdEspecialidad
        {
            get { return _idEspecialidad; }
            set { _idEspecialidad = value; }
        }

        public Curso(string anio, string division, string idTurno, string idEspecialidad)
        {          
            Anio = anio;
            
            Division = division;

            IdTurno = idTurno;

            IdEspecialidad = idEspecialidad;
            
            Parametros.Add(new Parametro("@unAnio", Anio));
            
            Parametros.Add(new Parametro("@unaDivision", Division));

            Parametros.Add(new Parametro("@unIDTurno", IdTurno));
            
            Parametros.Add(new Parametro("@unIDEspecialidad", IdEspecialidad));
                        
            Tipo = "Curso";
        }

        public Curso(string id, string anio, string division, string idTurno, string idEspecialidad) 
            : this (anio, division, idTurno, idEspecialidad)
        {
            Id = id;

            Parametros.Add(new Parametro("@idCurso", Id));

            Tipo = "Curso";
        }
        
        public Curso(string id)
        {
            Id = id;

            Parametros.Add(new Parametro("@idCurso", Id));

            Tipo = "Curso";
        }

        public static List<Curso> Select()
        {
            List<Curso> cursos = new List<Curso>();

            string query = "select * from curso";

            cursos = Query(query, cursos);

            return cursos;
        }

        public static List<Curso> Select(string where)
        {
            List<Curso> cursos = new List<Curso>();

            string query = "select * from curso " + where;

            cursos = Query(query, cursos);

            return cursos;
        }
   
        private static List<Curso> Query(string query, List<Curso> cursos)
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
                    string turno = turnoTexto(myReader["idTurno"].ToString());

                    string especialidad = especialidadTexto(myReader["idEspecialidad"].ToString());

                    cursos.Add(new Curso(myReader["idCurso"].ToString(), myReader["anio"].ToString(), myReader["division"].ToString(), turno, especialidad));
                }

                myReader.Dispose();

                connectionLive.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return cursos;
        }

        private static string especialidadTexto(string p)
        {
            if (p.Equals("1"))
            {
                return "Computación";
            }

            if (p.Equals("2"))
            {
                return "Electrónica";
            }

            if (p.Equals("3"))
            {
                return "Eléctrica";
            }

            return "Ciclo Básico";
        }

        private static string turnoTexto(string p)
        {
            if (p.Equals("1"))
            {
                return "Mañana";
            }

            if (p.Equals("2"))
            {
                return "Tarde";
            }

            return "Noche";
        }
    }
}
