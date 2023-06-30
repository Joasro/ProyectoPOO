using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Joaquin David, 28 junio, creación de la clase, para poderla usarla en el main con sus funciones ya dadas

namespace Proyectoconjoaco.Clases
{
    public class GestionPeliculas
    {
        private List<Pelicula> peliculas;

        public GestionPeliculas()
        {
            peliculas = new List<Pelicula>();
        }

        public void AgregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }

        public void EliminarPelicula(Pelicula pelicula)
        {
            peliculas.Remove(pelicula);
        }

        public void ConsultarPeliculas()
        {
            Console.WriteLine("Lista de Peliculas:");
            foreach (Pelicula pelicula in peliculas)
            {
                Console.WriteLine(pelicula);
            }
        }
    }
}
