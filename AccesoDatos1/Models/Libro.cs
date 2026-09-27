using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace AccesoDatos1.Models
{
     public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        private int CopiasDisponibles;
        public int copiasDisponibles
        {
            get { return copiasDisponibles; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Las copias disponibles no pueden ser negativas.");
                else
                    CopiasDisponibles = value;
            }
        }
    }
}
   
