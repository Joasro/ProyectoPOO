using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Lisandro Adolfo, 28 junio, creación de la clase película para utilizar 

namespace Proyectoconjoaco.Clases
{
    public class Pelicula 
    {

        private string genero;
        private string sinopsis;
        private string titulo;
        private int duracion;


        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Sinopsis
        {
            get { return sinopsis; }
            set { sinopsis = value; }
        }

        public Pelicula()
        {
            // Constructor por defecto
        }

        public Pelicula(string titulo, int duracion, string genero, string sinopsis)

        {
            this.genero = genero;
            this.sinopsis = sinopsis;
            this.titulo = titulo;
            this.duracion = duracion;

        }



        public override string ToString()
        {
            return $" Título - {titulo}\n Duración - {Duracion} minutos\n Género - {Genero}\n Sinopsis - {sinopsis}\n";
        }
    }

}
