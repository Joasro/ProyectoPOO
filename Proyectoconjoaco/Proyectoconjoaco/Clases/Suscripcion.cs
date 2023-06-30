using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Autor: Joaquin David, 28 junio, creación de la clase suscripción para utilizar 

namespace Proyectoconjoaco.Clases
{
    public class Suscripcion
    {
        private int id;
        private string nombre;
        private decimal costo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public Suscripcion()
        {
            // Constructor por defecto
        }

        public Suscripcion(int id, string nombre, decimal costo)
        {
            this.id = id;
            this.nombre = nombre;
            this.costo = costo;
        }

        public override string ToString()
        {
            return $"Suscripción: Id - {id}, Nombre - {nombre}, Costo - {costo}";
        }
    }

}
