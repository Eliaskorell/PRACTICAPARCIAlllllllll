using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos1.Models
{
    public class Prestamo : IPrestamoCalculable
    {  
        public int Id { get; set; }
        public int FechaPrestamo { get; set; }
        public int FechaDevolucionEstimada { get; set; }
        public int? FechaDevolucionReal { get; set; }

        public int DiasAtraso { get; set; }
        public decimal CalcularMulta()
        {
            decimal multa = 0;
            if (DiasAtraso > 0)
            {
                multa = DiasAtraso * 2; // Ejemplo: $2 por cada día de atraso
            }
            return multa;
        }
        public int SocioId { get; set; }
        public Socio Socio { get; set; }
        public int LibroId { get; set; }
        public Libro libro { get; set; }
    }
}
