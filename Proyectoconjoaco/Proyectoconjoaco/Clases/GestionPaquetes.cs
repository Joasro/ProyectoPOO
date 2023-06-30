using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Joaquin David, 28 junio, creación de la clase, para poderla usarla en el main con sus funciones ya dadas

namespace Proyectoconjoaco.Clases
{
    public class GestionPaquetes
    {
        private List<Paquete> paquetes;

        public GestionPaquetes()
        {
            paquetes = new List<Paquete>();
        }

        public void AgregarPaquete(Paquete paquete)
        {
            paquetes.Add(paquete);
        }

        public void EliminarPaquete(Paquete paquete)
        {
            paquetes.Remove(paquete);
        }

        public void ConsultarPaquetes()
        {
            Console.WriteLine("Lista de Paquetes:");
            foreach (Paquete paquete in paquetes)
            {
                Console.WriteLine(paquete);
            }
        }
    }

}
