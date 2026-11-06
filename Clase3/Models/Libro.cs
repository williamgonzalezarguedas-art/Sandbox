using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Models
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; private set; }

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Disponible = true;
        }

        public Libro(string titulo, string autor, bool disponible)
        {
            Titulo = titulo;
            Autor = autor;
            Disponible = disponible;
        }

        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine($"El libro '{Titulo}' ha sido prestado.");
            }
            else
            {
                Console.WriteLine($"El libro '{Titulo}' no está disponible para préstamo.");
            }
        }

        public void Devolver()
        {
            if (!Disponible)
            {
                Disponible = true;
                Console.WriteLine($"El libro '{Titulo}' ha sido devuelto.");
            }
            else
            {
                Console.WriteLine($"El libro '{Titulo}' ya está disponible.");
            }
        }



    }
}
