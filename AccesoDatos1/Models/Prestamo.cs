using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos1.Models
{
    public class Prestamo : IPrestamoCalculable
    {  
        public int Id { get; set; }
        public DateTime FechaPrestamo{ get; set; }
        public DateTime? FechaDevolucionReal { get; set; }
        public DateTime FechaDevolucionEstimada { get; set; }
        public decimal CalcularMultaDias(int diasAtraso)
        {
            decimal multa = 0;
            if (diasAtraso > 0)
            {
                multa = diasAtraso * 0.5m; 
            }
            return multa;
        }
        public int SocioId { get; set; }
        public Socio Socio { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }
    }
}
