using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos1.Models
{
    public class Socio : Persona
    {
        public DateTime FechaAlta { get; set; }
        public override string Descripcion()
        {
            return $"Socio: {Nombre}, DNI: {Dni}, Fecha de Alta: {FechaAlta:yyyy-MM-dd}";
        }
    }
}
