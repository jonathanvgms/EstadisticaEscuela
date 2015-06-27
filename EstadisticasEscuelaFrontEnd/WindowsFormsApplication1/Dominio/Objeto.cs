using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Objeto
    {
        protected string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private List<Parametro> parametros = new List<Parametro>();

        public List<Parametro> Parametros
        {
            get { return parametros; }
            set { parametros = value; }
        }       
    }
}
