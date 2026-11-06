using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Views
{
    public  class LibroVista
    {

        public void MostrarMenu()
        {
            Console.WriteLine("=== Menú de Biblioteca ===");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Prestar libro");
            Console.WriteLine("3. Devolver libro");
            Console.WriteLine("4. Mostrar libros disponibles");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
           
        }

        public void MostrarLibrosDisponibles(List<Models.Libro> libros)
        {
            Console.WriteLine("=== Libros Disponibles ===");
            foreach (var libro in libros)
            {
                string disponibilidad = libro.Disponible ? "Disponible" : "No disponible";

                Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}, Disponibilidad: {disponibilidad}");
            }
            
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
