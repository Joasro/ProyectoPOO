using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Joaquin David, 28 junio, creación de la clase, que se agrega utilidad en el futuro
namespace Proyectoconjoaco.Clases
{
    public abstract class Multimedia
    {
        private int id;
        private string titulo;
        private int duracion;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public Multimedia()
        {
            // Constructor por defecto
        }

        public Multimedia(int id, string titulo, int duracion)
        {
            this.id = id;
            this.titulo = titulo;
            this.duracion = duracion;
        }

        public abstract string ObtenerInformacion();
    }

}
