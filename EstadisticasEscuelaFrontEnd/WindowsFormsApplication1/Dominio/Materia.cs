using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Materia : Objeto
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Materia(string nombre)
        {
            Nombre = nombre;
        }
    }
}
