using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Joaquin David, 28 junio, creación de la clase historial, para poder usarla como historial xd

namespace Proyectoconjoaco.Clases
{
    public class Historial
    {
        private Cliente cliente;
        private List<Pelicula> peliculasHistorial;

        public Historial(Cliente cliente)
        {
            this.cliente = cliente;
            peliculasHistorial = new List<Pelicula>();
        }

        public void AgregarPeliculaHistorial(Pelicula pelicula)
        {
            peliculasHistorial.Add(pelicula);
        }

        public void EliminarPeliculaHistorial(Pelicula pelicula)
        {
            peliculasHistorial.Remove(pelicula);
        }

        public void ConsultarPeliculasHistorial()
        {
            Console.WriteLine($"Historial de películas de {cliente.Nombre}:");
            foreach (Pelicula pelicula in peliculasHistorial)
            {
                Console.WriteLine(pelicula);
            }
        }
    }

}
