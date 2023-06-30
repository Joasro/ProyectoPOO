using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Autor: Joaquin David, 28 junio, creación de la clase catalogo para utilizar 

namespace Proyectoconjoaco.Clases
{
    public class Catalogo
    {
        private List<Pelicula> peliculas;

        public Catalogo()
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
            Console.WriteLine("Catálogo de Películas:");
            foreach (Pelicula pelicula in peliculas)
            {
                Console.WriteLine(pelicula);
            }
        }
    }

}
