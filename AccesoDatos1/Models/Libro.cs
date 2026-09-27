using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace AccesoDatos1.Models
{
     public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;
        private int copiasDisponibles;
        public int CopiasDisponibles
        {
            get { return copiasDisponibles; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Las copias disponibles no pueden ser negativas.");
                else
                    copiasDisponibles = value;
            }
        }
    }
}
   
