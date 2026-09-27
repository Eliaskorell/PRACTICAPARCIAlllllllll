using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AccesoDatos1.Models
{
    public abstract class Persona
    { public int Id { get; set; }
      public string Nombre { get; set; }
      public int Dni { get; set; }
      public abstract string Descripcion();

    }
}
