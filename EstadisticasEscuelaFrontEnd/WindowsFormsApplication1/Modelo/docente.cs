//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstadisticasEscuelaFrontEnd.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class docente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ficha { get; set; }
        public bool Habilitado { get; set; }
        public int IdUsuario { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}
