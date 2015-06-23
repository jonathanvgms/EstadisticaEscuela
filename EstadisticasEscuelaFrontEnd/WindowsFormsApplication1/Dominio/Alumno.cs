using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Alumno : Objeto
    {
        private string nombre { get; set; }
        private int legajo { get; set; }
        private int dni { get; set; }
        private int idAlumno { get; set; }
        private int idNota { get; set; }
        private int idCurso { get; set; }
        
        public Alumno(string unNombre, int unLegajo, int unDni, int unIDAlumno, int unIDNota, int unIDCurso)
        {
            nombre = unNombre;
            legajo = unLegajo;
            dni = unDni;
            idAlumno = unIDAlumno;
            idNota = unIDNota;
            idCurso = unIDCurso;
        }       
    }
}
