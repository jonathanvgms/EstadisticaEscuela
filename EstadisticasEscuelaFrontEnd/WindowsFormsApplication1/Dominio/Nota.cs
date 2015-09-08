using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstadisticasEscuelaFrontEnd.Database;

namespace EstadisticasEscuelaFrontEnd.Dominio
{
    class Nota : Objeto
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id =value;}
        }
        private int _nota1Trimestre;

        public int Nota1Trimestre
        {
            get { return _nota1Trimestre; }
            set { _nota1Trimestre = value; }
        }

        private int _nota2Trimestre;

        public int Nota2Trimestre
        {
            get { return _nota2Trimestre; }
            set { _nota2Trimestre = value; }
        }

        private int _nota3Trimestre;

        public int Nota3Trimestre
        {
            get { return _nota3Trimestre; }
            set { _nota3Trimestre = value; }
        }

        private int _notaFinal;

        public int NotaFinal
        {
            get{ return _notaFinal;}
            set {_notaFinal=value;}
        }

        private int _notaDefinitiva;

        public int NotaDefinitiva
        {
            get { return _notaFinal; }
            set { _notaFinal = value; }
        }

        private int _idMateria;

        public int IdMateria
        {
            get { return _idMateria; }
            set { _idMateria = value; }
        }

        public Nota(int UnaNota1Trimestre, int unaNota2Trimestre, int unaNota3Trimestre, int unaNotaFinal, int unaNotaDefinitiva, int unaIdMateria)
        {
            
            Nota1Trimestre = UnaNota1Trimestre;
            Nota2Trimestre = unaNota2Trimestre;
            Nota3Trimestre = unaNota3Trimestre;
            NotaFinal = unaNotaDefinitiva;
            NotaDefinitiva = unaNotaDefinitiva;
            IdMateria = unaIdMateria;

            Parametros.Add(new Parametro("@Nota1erTrim", UnaNota1Trimestre));
            Parametros.Add(new Parametro("@Nota2doTrim", unaNota2Trimestre));
            Parametros.Add(new Parametro("@Nota3erTrim", unaNota3Trimestre));
            Parametros.Add(new Parametro("@NotaDefinitiva", unaNotaDefinitiva));
            Parametros.Add(new Parametro("@IdMateria", unaIdMateria));

            Tipo = "Nota";
        }

        //public Nota(int 
    }
}
