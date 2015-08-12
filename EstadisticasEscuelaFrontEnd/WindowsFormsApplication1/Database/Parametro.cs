using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstadisticasEscuelaFrontEnd.Dominio;

namespace EstadisticasEscuelaFrontEnd.Database
{
    class Parametro
    {
        private string arg;

        public string Arg
        {
            get { return arg; }
            set { arg = value; }
        }

        private string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public Parametro(string param, int valor)
        {
            arg = param;
            value = valor.ToString();
        }

        public Parametro(string param, string valor)
        {
            arg = param;
            value = valor;
        }
    }
}
