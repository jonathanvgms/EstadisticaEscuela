using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Nota : Objeto
    {
        private int IdNota { get; set; }
        private int Nota1Trimestre { get; set; }
        private int Nota2Trimestre { get; set; }
        private int Nota3Trimestre { get; set; }
        private int NotaFinal { get; set; }
        private int NotaDefinitiva { get; set; }
        private int IdMateria { get; set; }

        public Nota(int UnIdNota, int UnaNota1Trimestre, int unaNota2Trimestre, int unaNota3Trimestre, int unaNotaFinal, int unaNotaDefinitiva, int unaIdMateria)
        {
            IdNota = UnIdNota;
            Nota1Trimestre = UnaNota1Trimestre;
            Nota2Trimestre = unaNota2Trimestre;
            Nota3Trimestre = unaNota3Trimestre;
            NotaFinal = unaNotaDefinitiva;
            NotaDefinitiva = unaNotaDefinitiva;
            IdMateria = unaIdMateria;
        }
    }
}
