using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="pPunto1">Objeto punto1, posee componentes X e Y reales</param>
        /// <param name="pPunto2">Objeto punto2, posee componentes X e Y reales</param>
        /// <param name="pPunto3">Objeto punto3, posee componentes X e Y reales</param>
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        /// <summary>
        /// Propiedad del atributo punto1
        /// </summary>
        public Punto Punto1
        {
            get { return this.iPunto1; }
        }
        /// <summary>
        /// Propiedad del atributo punto2
        /// </summary>
        public Punto Punto2
        {
            get { return this.iPunto2; }
        }
        /// <summary>
        /// Propiedad del atributo punto3
        /// </summary>
        public Punto Punto3
        {
            get { return this.iPunto3; }
        }
        /// <summary>
        /// Propiedad que se calcula con el perimetro y los atributos puntos
        /// </summary>
        public double Area
        {
           get { double semiP = Perimetro / 2;
                 return Math.Sqrt(semiP * (Lado1-semiP)*(Lado2-semiP)*(Lado3-semiP)); }
        }
        /// <summary>
        /// Propiedad Que se calcula con con los lados entre los puntos
        /// </summary>
        public double Perimetro
        {
           get {return Lado1+Lado2+Lado3; }
        }

        /// <summary>
        /// Propiedad que calcula la distancia entre 2 de los puntos del Objeto
        /// </summary>
        private double Lado3
        {
            get {return this.iPunto1.calcularDistanciaDesde(this.iPunto2); }
        }
        /// <summary>
        /// Propiedad que calcula la distancia entre 2 de los puntos del Objeto
        /// </summary>
        private double Lado2
        {
            get { return this.iPunto1.calcularDistanciaDesde(this.iPunto3); }
        }
        /// <summary>
        /// Propiedad que calcula la distancia entre 2 de los puntos del Objeto
        /// </summary>
        private double Lado1
        {
            get { return this.iPunto2.calcularDistanciaDesde(this.iPunto3); }
        }

    }
}
