using System;
using System.Data;
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


        public Curso(string anio, string division, string turno, string especialidad)
        {          
            Anio = anio;
            
            Division = division;

            Turno = turno;

            Especialidad = especialidad;

            Parametros.Add(new Parametro("@unAnio", Anio));
            
            Parametros.Add(new Parametro("@unaDivision", Division));

            Parametros.Add(new Parametro("@unTurno", Turno));

            Parametros.Add(new Parametro("@unaEspecialidad", Especialidad));

            Tipo = "Curso";
        }

        public Curso(string id, string anio, string division, string turno, string especialidad) 
            : this (anio, division, turno, especialidad)
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
            string turno="";

            string especialidad = "";

            MySqlDataReader myReader = null;

            MySqlConnection connectionLive = databaseMySqlConnection();

            MySqlCommand command = new MySqlCommand(query, connectionLive);

            try
            {
                connectionLive.Open();

                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    /*string turno = turnoTexto(myReader["idTurno"].ToString());

                    string especialidad = especialidadTexto(myReader["idEspecialidad"].ToString());*/

                    /*
                    if (myReader["idTurno"].ToString().Equals("1"))
                    {
                        turno = "Mañana";
                    }
                    if (myReader["idTurno"].ToString().Equals("2"))
                    {
                        turno = "Tarde";
                    }
                    else if (myReader["idTurno"].ToString().Equals("3"))
                    {
                        turno = "Noche";
                    }*/

                    switch((myReader["idTurno"].ToString()))
                    {
                        case "1":
                            turno="Mañana";
                            break;
                        case "2":
                            turno="Tarde";
                            break;
                        case "3":
                            turno="Noche";
                            break;
                    }
                    switch((myReader["idEspecialidad"].ToString()))
                    {
                        case "1":
                            especialidad="Computacion";
                            break;
                        case "2":
                            especialidad="Electronica";
                            break;
                        case "3":
                            especialidad="Electrica";
                            break;
                        case "4":
                            especialidad="Ciclo Basico";
                            break;
                    }

                    cursos.Add(new Curso(myReader["idCurso"].ToString(), myReader["anio"].ToString(), myReader["division"].ToString(),turno,especialidad));

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
