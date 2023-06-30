using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Autor: Joaquin David, 28 junio, creación de la clase serie para utilizar como gestion de peliculas y series talvez

namespace Proyectoconjoaco.Clases
{
    public class Serie : Multimedia
    {
        private int numTemporadas;

        public int NumTemporadas
        {
            get { return numTemporadas; }
            set { numTemporadas = value; }
        }

        public Serie()
        {
            // Constructor por defecto
        }

        public Serie(int id, string titulo, int duracion, int numTemporadas)
            : base(id, titulo, duracion)
        {
            this.numTemporadas = numTemporadas;
        }

        public override string ObtenerInformacion()
        {
            return $"Serie: Título - {Titulo}, Duración - {Duracion} minutos, Número de Temporadas - {numTemporadas}";
        }
    }

}
