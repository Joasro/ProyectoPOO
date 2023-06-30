using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Joaquin David, 28 junio, creación de la clase usuario


namespace Proyectoconjoaco.Clases
{
    public class Usuario
    {
        private string nombre;
        private string rol;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        public Usuario()
        {
            // Constructor por defecto
        }

        public Usuario(string nombre, string rol)
        {
            this.nombre = nombre;
            this.rol = rol;
        }

        public override string ToString()
        {
            return $"Usuario: Nombre - {nombre}, Rol - {rol}";
        }
    }

}
