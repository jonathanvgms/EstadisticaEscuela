using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Especialidad : Objeto
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _tipoEspecialidad;

        public string TipoEspecialidad
        {
            get { return _tipoEspecialidad; }
            set { _tipoEspecialidad = value; }
        }
        
        public Especialidad(int id, string nombre)
        {
            Id = id;

            TipoEspecialidad = nombre;
        }          
    }
}
