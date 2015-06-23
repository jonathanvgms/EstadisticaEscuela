using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstadisticasEscuelaFrontEnd
{
    class Turno
    {
        private int IdTurno { get; set; }
        private string turno { get; set; }

        public Turno(int UnidTurno, string Unturno)
        {
            IdTurno = UnidTurno;
            turno = Unturno;
        }
    }
}
