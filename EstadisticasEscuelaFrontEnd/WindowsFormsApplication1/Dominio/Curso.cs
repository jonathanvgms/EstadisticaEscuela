using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstadisticasEscuelaFrontEnd
{
    class Curso
    {
        private int idCurso { get; set; }
        private int idTurno { get; set; }
        private int anio { get; set; }
        private int division { get; set; }

        public Curso(int unIDCurso, int unIDTurno, int unAnio, int unaDivision)
        {
            idCurso = unIDCurso;
            idTurno = unIDTurno;
            anio = unAnio;
            division = unaDivision;
        }
    }
}
