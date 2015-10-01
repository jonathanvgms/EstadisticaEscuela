using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstadisticasEscuelaFrontEnd.Modelo;

namespace EstadisticasEscuelaFrontEnd.Alumnos
{
    class AlumnoModificado
    {
        private string nombreUsuario;

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        private alumno alumnoMod;

        public alumno AlumnoMod
        {
            get { return alumnoMod; }
            set { alumnoMod = value; }
        }

        private EstadisticasEscuelaEntities context;

        public EstadisticasEscuelaEntities Context
        {
            get { return context; }
            set { context = value; }
        }
    }
}
