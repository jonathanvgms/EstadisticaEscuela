using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Asistencia : Objeto
    {
        private int IdAsistencia { get; set; }
        private DateTime Fecha { get; set; }
        private Boolean presentismo { get; set; }
        private int IdAlumno { get; set; }

        public Asistencia(int UnIdAsistencia, DateTime UnaFecha, Boolean UnPresentismo, int UnIdAlumno)
        {
            IdAsistencia = UnIdAsistencia;
            Fecha = UnaFecha;
            presentismo = UnPresentismo;
            IdAlumno = UnIdAlumno;
        }
    }
}
