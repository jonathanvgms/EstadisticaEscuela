using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstadisticasEscuelaFrontEnd
{
    class Especialidad
    {
        private int IdEspecialidad { get; set; }
        private string nombreEspecialidad { get; set; }

        public Especialidad(int UnIdEspecialidad, string UnnombreEspecialidad)
        {
            IdEspecialidad = UnIdEspecialidad;
            nombreEspecialidad = UnnombreEspecialidad;
        }
          
    }
}
