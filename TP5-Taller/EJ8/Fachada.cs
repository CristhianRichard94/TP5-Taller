using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    class Fachada
    { /// <summary>
      /// Atributo para asignarles codigo único a cada usuario
      /// </summary>
        int iCantidadID;

        /// <summary>
        /// Atributo de la clase Repositorio Usuarios.
        /// </summary>
        private RepositorioUsuario iRepositorio;

        /// <summary>
        /// Instancia de fachada para cumplir el patrón Singleton
        /// </summary>
        private static Fachada cInstancia;

        /// <summary>
        /// Constructor de la Fachada
        /// </summary>
        private Fachada()
        {
            iRepositorio = new RepositorioUsuario();
            this.iCantidadID = 0;
        }

        /// <summary>
        /// Propiedad Instancia de la Fachada.
        /// </summary>
        public static Fachada Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    return cInstancia = new Fachada();
                }
                else
                {
                    return cInstancia;
                }
            }
        }


        /// <summary>
        /// Método par agregar Usuario al repositorio
        /// </summary>
        /// <param name="pNombreCompleto">Nombre completo del usuario</param>
        /// <param name="pCorreoElectronico">Correo Electrónico del Usuario</param>
        public void AgregarUsuario(string pNombreCompleto, string pCorreoElectronico)
        {
            Usuario usuario = new Usuario();
            usuario.Codigo = this.iCantidadID.ToString();
            usuario.NombreCompleto = pNombreCompleto;
            usuario.CorreoElectronico = pCorreoElectronico;
            this.iRepositorio.Agregar(usuario);
            this.iCantidadID++;
        }

        /// <summary>
        /// Actualiza un Usuario
        /// </summary>
        /// <param name="pcodigoAModificar">Codigo a Modificar</param>
        /// <param name="pNombreCompleto">Nombre modificado</param>
        /// <param name="pCorreoElectronico">Correo Electrónico Modificado</param>
        public void Actualizar(string pcodigoAModificar, string pNombreCompleto, string pCorreoElectronico)
        {
            Usuario usuario = new Usuario();
            usuario.Codigo = pcodigoAModificar;
            usuario.NombreCompleto = pNombreCompleto;
            usuario.CorreoElectronico = pCorreoElectronico;
            this.iRepositorio.Actualizar(usuario);
        }

        /// <summary>
        /// Elimina un Usuario de la lista de Usuarios
        /// </summary>
        /// <param name="pCodigo">Codigo del Usuario a eliminar</param>
        public void Eliminar(string pCodigo)
        {
            this.iRepositorio.Eliminar(pCodigo);
        }

        /// <summary>
        /// Obtiene todos los usuarios de la lista
        /// </summary>
        /// <returns></returns>
        public List<Usuario> ObtenerTodos()
        {
            return this.iRepositorio.ObtenerTodos();
        }

        /// <summary>
        /// Obtiene la lista ordenada por un atributo en particular
        /// </summary>
        /// <param name="atributoOrdenacion"></param>
        /// <returns></returns>
        public List<Usuario> ObtenerComparadosPor(string atributoOrdenacion)
        {
            List<Usuario> lista;
            switch (atributoOrdenacion)
            {
                case "CorreoElectronico":
                    lista = this.iRepositorio.ObtenerComparadosPor(new OrdenarPorCorreo());
                    break;
                case "NombreCompleto":
                    lista = this.iRepositorio.ObtenerComparadosPor(new OrdenarPorNombreDesc());
                    break;
                default:
                    lista = this.iRepositorio.ObtenerTodos();
                    lista.Sort();
                    break;
            }
            return lista;
        }
    }
}
