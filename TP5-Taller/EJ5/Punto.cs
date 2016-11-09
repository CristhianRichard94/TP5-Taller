using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Punto
    {
        private double iX;
        /// <summary>
        /// Propiedad del atributo X de la clase
        /// </summary>
        public double X
        {
            get { return this.iX; }
        }
        private double iY;
        
        /// <summary>
        /// Propiedad del atributo Y de la clase
        /// </summary>
        public double Y
        {
            get { return this.iY; }
        }
        /// <summary>
        /// Constructor de la clase 
        /// </summary>
        /// <param name="pX"> coordenada del punto en X</param>
        /// <param name="pY">coordenada del punto en Y</param>
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }
        /// <summary>
        /// Calcula la distancia desde un punto a otro como Raiz cuadrada de la suma de los cuadrados de las distancias entre las componentes x e y
        /// </summary>
        /// <param name="p">punto en componentes x e y</param>
        /// <returns>Devuelve un valor real que representa la distancia entre ambos puntos</returns>
        public double calcularDistanciaDesde(Punto p)    
        {                                               
            return Math.Sqrt(Math.Pow((this.iX - p.iX), 2) + Math.Pow((this.iY - p.iY), 2));
        }
    }
}
