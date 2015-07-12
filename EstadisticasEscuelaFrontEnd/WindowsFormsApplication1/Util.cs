using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstadisticasEscuelaFrontEnd
{
    static class Util
    {
        //El metodo recibe un string y devuelve un bool verdadero mientras que la cadena este entre A y Z
        public static bool todasLetras(string buffer)
        {
            string aux = buffer.ToUpper();

            for (int i = 0; i < buffer.Length; i++)
            {
                if (aux[i] < 65 || aux[i] > 90)
                {
                    /*  int auxi = (int)aux[i];
                      if (auxi!= 165)
                     * */
                    return false;
                }
            }

            return true;
        }

        //Este metodo recibe un string y devuelve bool verdadero mientras que la cadena este entre 0 y 9 
        public static bool todasNumeros(string buffer)
        {

            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] < 48 || buffer[i] > 57)
                {
                    return false;
                }
            }

            return true;
        }
        
    }
}
