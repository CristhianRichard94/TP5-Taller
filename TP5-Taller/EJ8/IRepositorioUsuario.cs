using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    /// <summary>
    /// Interfaz del Repositorio que define los metodos abstractos
    /// </summary>
    interface IRepositorioUsuario
    {
        void Eliminar(string pCodigo);

        void Agregar(Usuario pUsuario);


        void Actualizar(Usuario pUsuario);

        List<Usuario> ObtenerTodos();

        Usuario ObtenerPorCodigo(string pCodigo);

        List<Usuario> ObtenerComparadosPor(IComparer<Usuario> pComparador);
    }
}
