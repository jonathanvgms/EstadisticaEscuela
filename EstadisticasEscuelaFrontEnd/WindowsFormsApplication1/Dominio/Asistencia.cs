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
    class Asistencia : Objeto
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private bool _presentismo;

        public bool Presentismo
        {
            get { return _presentismo; }
            set { _presentismo = value; }
        }
        private int _idAlumno;

        public int IdAlumno
        {
            get { return _idAlumno; }
            set { _idAlumno = value; }
        }

        public Asistencia( DateTime UnaFecha, Boolean UnPresentismo, int UnIdAlumno)
        {
            Fecha = UnaFecha;
            Presentismo = UnPresentismo;
            IdAlumno = UnIdAlumno;

            //Parametros.Add(new Parametro("@unaFecha",Fecha));

            //Parametros.Add(new Parametro("@UnPresentismo", Presentismo));

            Parametros.Add(new Parametro("@unIdAlumno", IdAlumno));

            Tipo = "";
        }
    }
}
