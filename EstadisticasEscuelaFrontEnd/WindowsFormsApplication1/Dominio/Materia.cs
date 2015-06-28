using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Materia : Objeto
    {
        private int idMateria { get; set; }
        private string materia { get; set; }

        public Materia(int unaIDMateria, string unaMateria)
        {
            idMateria = unaIDMateria;
            materia = unaMateria;
        }
    }
}
