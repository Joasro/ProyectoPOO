using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectoconjoaco.Clases
{
    internal class GestionMultimedia
    {
        private List<Multimedia> multimediaList;

        public GestionMultimedia()
        {
            multimediaList = new List<Multimedia>();
        }

        public void AgregarMultimedia(Multimedia multimedia)
        {
            multimediaList.Add(multimedia);
        }

        public void EliminarMultimedia(Multimedia multimedia)
        {
            multimediaList.Remove(multimedia);
        }

        public void ConsultarMultimedia()
        {
            Console.WriteLine("Lista de Multimedia:");
            foreach (Pelicula pelicula in s)
            {
                Console.WriteLine(peliculas);
            }
        }
    }

}
