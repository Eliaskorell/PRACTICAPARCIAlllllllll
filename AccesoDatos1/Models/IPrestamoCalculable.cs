using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos1.Models
{
    public class IPrestamoCalculable
    { public interface ICalcularMultaDias
        { public int DiasAtraso { get; set; }
            public decimal CalcularMulta();
        }

    }
}
