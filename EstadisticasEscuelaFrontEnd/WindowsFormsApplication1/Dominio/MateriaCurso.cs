using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class MateriaCurso : Objeto
    {
        private int idMateria { get; set; }
        private int idCurso { get; set; }

        public MateriaCurso(int unIDMateria, int unIDCurso)
        {
            idMateria = unIDMateria;
            idCurso = unIDCurso;
        }

    }
}
