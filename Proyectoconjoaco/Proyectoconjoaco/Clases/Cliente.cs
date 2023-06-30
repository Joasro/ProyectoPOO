using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Lisandro Adolfo, 28 junio, creación de la clase cliente para utilizar 

namespace Proyectoconjoaco.Clases
{
    public class Cliente : Usuario
    {
        private string correoElectronico;

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }

        public Cliente()
        {
            // Constructor por defecto
        }

        public Cliente(string nombre, string rol, string correoElectronico)
            : base(nombre, rol)
        {
            this.correoElectronico = correoElectronico;
        }

        public override string ToString()
        {
            return $"Cliente: Nombre - {Nombre}, Rol - {Rol}, Correo Electrónico - {correoElectronico}";
        }
    }

}
