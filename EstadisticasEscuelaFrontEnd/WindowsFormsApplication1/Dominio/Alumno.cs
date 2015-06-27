using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Alumno : Objeto
    {
        public Alumno(string nombre, string apellido, int legajo, int dni)
        {
            Parametros.Add(new Parametro("@unNombre", nombre));

            Parametros.Add(new Parametro("@unApellido", apellido));

            Parametros.Add(new Parametro("@unLegajo", legajo));

            Parametros.Add(new Parametro("@unDni", dni));

            Tipo = "Alumno";
        }       
    }
}
