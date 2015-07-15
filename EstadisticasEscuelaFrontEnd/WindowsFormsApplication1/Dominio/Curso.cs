using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private string _idEspecialidad;

        public string IdEspecialidad
        {
            get { return _idEspecialidad; }
            set { _idEspecialidad = value; }
        }

        private string _idTurno;

        public string IdTurno
        {
            get { return _idTurno; }
            set { _idTurno = value; }
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

            connectionLive.Open();

            myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                cursos.Add(new Curso(myReader["anio"].ToString(),
                        myReader["division"].ToString(),
                        myReader["idTurno"].ToString(),
                        myReader["idEspecialidad"].ToString()));
            }

            myReader.Dispose();

            connectionLive.Close();

            return cursos;
        }
    }
}
