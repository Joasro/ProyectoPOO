using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Lisnadro Adolfo, 28 junio, creación de la clase, para poderla usarla en el main con sus funciones ya dadas, igual que las anteriores

namespace Proyectoconjoaco.Clases
{
    public class GestionSuscripciones
    {
        private List<Suscripcion> suscripciones;

        public GestionSuscripciones()
        {
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

        public void ConsultarSuscripciones()
        {
            Console.WriteLine("Lista de Suscripciones:");
            foreach (Suscripcion suscripcion in suscripciones)
            {
                Console.WriteLine(suscripcion);
            }
        }
    }

}
