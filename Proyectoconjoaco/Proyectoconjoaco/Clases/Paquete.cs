using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Autor: Lisandro Afolfo, 28 junio, creación de la clase paquete para utilizar 
}
namespace Proyectoconjoaco.Clases
{
    public class Paquete
    {
        private double id;
        private string nombre;
        private List<Suscripcion> suscripciones;

        public double Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public List<Suscripcion> Suscripciones
        {
            get { return suscripciones; }
            set { suscripciones = value; }
        }

        public Paquete(string v)
        {
            // Constructor por defecto
            suscripciones = new List<Suscripcion>();
        }

        public Paquete(string nombre, double id)
        {
            this.id = id;
            this.nombre = nombre;
            suscripciones = new List<Suscripcion>();
        }

        public void AgregarSuscripcion(Suscripcion suscripcion)
        {
            suscripciones.Add(suscripcion);
        }

        public void EliminarSuscripcion(Suscripcion suscripcion)
        {
            suscripciones.Remove(suscripcion);
        }

        public override string ToString()
        {
            return $" - {nombre}, Precio: - {id} ";
        }
    }

}
