﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{ 

    /// <summary>
    /// Clase que implementa los metodos del Repositorio
    /// </summary>
     public class RepositorioUsuario : IRepositorioUsuario
    {
        /// <summary>
        /// Lista de los usuarios persistidos en memoria
        /// </summary>
        private IDictionary<string, Usuario> iRepositorio;



        /// <summary>
        /// Construye una instancia del Respositorio de Usuarios
        /// </summary>
        public RepositorioUsuario()
        {
            this.iRepositorio= new Dictionary<string, Usuario>();
        }


        /// <summary>
        /// Agregar un usuario
        /// </summary>
        /// <param name="pUsuario">Usuario a agregar</param>
        public void Agregar(Usuario pUsuario)
        {
            this.iRepositorio.Add(pUsuario.Codigo, (Usuario)pUsuario.Clone());
        }



        /// <summary>
        /// Elimina un usuario
        /// </summary>
        /// <param name="pCodigo">Código del usuario a eliminar</param>
        public void Eliminar(string pCodigo)
        {
            this.iRepositorio.Remove(pCodigo);
        }

        /// <summary>
        /// Actualiza los datos del usuario
        /// </summary>
        /// <param name="pUsuario">Usuario a actualizar sus datos</param>
        public void Actualizar(Usuario pUsuario)
        {
            this.iRepositorio[pUsuario.Codigo] = (Usuario)pUsuario.Clone();
        }

        /// <summary>
        /// Devuelve una lista de todos los usuarios
        /// </summary>
        /// <returns>Tipo de dato Lista que representa todos los usuarios</returns>
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> listaUsuarios = this.iRepositorio.Values.ToList<Usuario>();
            listaUsuarios.Sort();
            return listaUsuarios;
        }


        /// <summary>
        /// Devuelve un usuario cuyo código es igual al del parámetro
        /// </summary>
        /// <param name="pCodigo">Código del usuario a encontrar</param>
        /// <returns>Tipo de dato usuario que representa aquél cuyo código es igual al suministrado por parámetro</returns>
        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return this.iRepositorio[pCodigo];
        }


        /// <summary>
        /// Este metodo devuelve una lista de usuarios cuyos nombres cumplen con la subcadena ingresada, 
        /// utiliza el concepto de defensive copy por lo cual devuelve una copia del usuario
        /// </summary>
        /// <param name="pNombre"> subcadena para buscar</param>
        /// <returns></returns>
        public IList<Usuario> BuscarAproximado (string pNombre)
        {
            List<Usuario> lista = new List<Usuario>();
            lista = this.ObtenerTodos();
            IEnumerator<Usuario> enumerador = lista.GetEnumerator();
            while (enumerador.MoveNext())
            {
                if (enumerador.Current.NombreCompleto.StartsWith(pNombre))
                {
                    lista.Add(enumerador.Current.Copy());
                }
            }
            return lista;

        }

        /// <summary>
        /// Devuelve una lista de usuarios ordenados por el parametro
        /// </summary>
        /// <param name="pComparador"></param>
        /// <returns></returns>
        public List<Usuario> ObtenerComparadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> ILista = this.iRepositorio.Values.ToList<Usuario>();
            ILista.Sort(pComparador.Compare);
            return ILista;
        }

    }
}
