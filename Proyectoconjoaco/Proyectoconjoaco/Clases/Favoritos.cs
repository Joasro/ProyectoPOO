using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Joaquin David, 28 junio, creación de la clase favoritos para utilizar 

namespace Proyectoconjoaco.Clases
{
    public class Favoritos
    {
        private Cliente cliente;
        private List<Multimedia> favoritos;

        public Favoritos(Cliente cliente)
        {
            this.cliente = cliente;
            favoritos = new List<Multimedia>();
        }

        public void AgregarFavorito(Multimedia multimedia)
        {
            favoritos.Add(multimedia);
        }

        public void EliminarFavorito(Multimedia multimedia)
        {
            favoritos.Remove(multimedia);
        }

        public void ConsultarFavoritos()
        {
            Console.WriteLine($"Favoritos de {cliente.Nombre}:");
            foreach (Multimedia multimedia in favoritos)
            {
                Console.WriteLine(multimedia.ObtenerInformacion());
            }
        }
    }

}
