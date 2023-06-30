using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autor: Joaquin David, 28 junio, creación de la clase gestionusuarios, funcionalidad pronta a saber

namespace Proyectoconjoaco.Clases
{
    public class GestionUsuarios
    {
        private List<Usuario> usuarios;

        public GestionUsuarios()
        {
            usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            usuarios.Remove(usuario);
        }

        public void ConsultarUsuarios()
        {
            Console.WriteLine("Lista de Usuarios:");
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine(usuario);
            }
        }
    }

}
