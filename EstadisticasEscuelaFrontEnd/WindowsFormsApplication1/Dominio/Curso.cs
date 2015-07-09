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
        private string idEspecialidad;

        public string IdEspecialidad
        {
            get { return idEspecialidad; }
            set { idEspecialidad = value; }
        }

        private string idTurno;

        public string IdTurno
        {
            get { return idTurno; }
            set { idTurno = value; }
        }

        private string anio;

        public string Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        private string division;

        public string Division
        {
            get{ return division; }
            set { division = value; }
        }

        public Curso(string unAnio, string unaDivision, string unIDTurno, string unIDEspecialidad)
        {          
            idTurno = unIDTurno;
           
            anio = unAnio;
            
            division = unaDivision;

            idEspecialidad = unIDEspecialidad;
            
            Parametros.Add(new Parametro("@unAnio", anio));
            
            Parametros.Add(new Parametro("@unaDivision", division));

            Parametros.Add(new Parametro("@unIDTurno", idTurno));
            
            Parametros.Add(new Parametro("@unIDEspecialidad", idEspecialidad));
                        
            Tipo = "Curso";
        }
        
        public static List<Curso> Select()
        {
            List<Curso> curso = new List<Curso>();

            string query = "select * from curso";

            MySqlDataReader myReader = null;

            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand command = new MySqlCommand(query, connectionLive);

            connectionLive.Open();

            myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                curso.Add(new Curso(myReader["anio"].ToString(), 
                        myReader["division"].ToString(),
                        myReader["idTurno"].ToString(), 
                        myReader["idEspecialidad"].ToString()));
            }

            myReader.Dispose();

            connectionLive.Close();

            return curso;
        }    
    }
}
