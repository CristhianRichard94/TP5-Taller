using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class Circulo
    {
        private Punto iCentro;
        private double iRadio;
        /// <summary>
        /// Propiedad del atributo centro del circulo
        /// </summary>
        public Punto Centro
        {
            get { return this.iCentro; } 
        }

        
        /// <summary>
        /// Propiedad del atributo radio del circulo
        /// </summary>
        public double Radio
        {
            get {return this.iRadio; }
        }
        /// <summary>
        /// Constructor de la clase, toma un punto y un real
        /// </summary>
        /// <param name="pCentro">atributo centro de tipo punto</param>
        /// <param name="pRadio">atributo radio  de tipo real</param>
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }
        /// <summary>
        /// Constructor de la clase toma 3 puntos
        /// </summary>
        /// <param name="pX">Coordenada del Centro en X</param>
        /// <param name="pY">Coordenada del Centro en Y</param>
        /// <param name="pRadio">Valor del Radio</param>
        public Circulo(double pX, double pY, double pRadio) //Constructor de la clase Circulo
        {
            Punto iPunto = new Punto(pX, pY);
            this.iCentro = iPunto;
            this.iRadio = pRadio;
        }
        /// <summary>
        /// Propiedad del Area
        /// </summary>
        public double Area                                  
            {
           get { return Math.PI * Math.Pow(this.iRadio, 2); } 
            }
        /// <summary>
        /// Propiedad Perimetro
        /// </summary>
        public double Perimetro 
        {
           get { return 2 * Math.PI * this.iRadio; }        
        }
    }
}
