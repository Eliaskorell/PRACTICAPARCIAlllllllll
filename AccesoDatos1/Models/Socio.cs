using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos1.Models
{
    public class Socio : Persona
    {
        public int FechaAlta { get; set; }
        public override string Descripcion()
        {
            return "Socio";
        }
    }
}
