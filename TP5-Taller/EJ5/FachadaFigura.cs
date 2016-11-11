using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ5
{
    class FachadaFigura
    {
        /// <summary>
        /// Se encarga de recibir los valores de program y llama al constructor de Triangulo, luego accede a la propiedad Perimetro
        /// </summary>
        /// <param name="px1">Coordenada del punto1 en X</param>
        /// <param name="py1">Coordenada del punto1 en Y</param>
        /// <param name="px2">Coordenada del punto2 en X</param>
        /// <param name="py2">Coordenada del punto2 en Y</param>
        /// <param name="px3">Coordenada del punto3 en X</param>
        /// <param name="py3">Coordenada del punto3 en Y</param>
        /// <returns></returns>
        public double CalcularPerimetroTriangulo(double px1,double py1, double px2,double  py2,double px3,double  py3)
        {
            Triangulo t = new Triangulo(new Punto(px1,py1), new Punto(px2,py2),new Punto(px3,py3));
            return t.Perimetro;
        }
        /// <summary>
        /// Se encarga de recibir los valores de program y llama al constructor de Triangulo, luego accede a la propiedad Area
        /// </summary>
        /// <param name="px1">Coordenada del punto1 en X</param>
        /// <param name="py1">Coordenada del punto1 en Y</param>
        /// <param name="px2">Coordenada del punto2 en X</param>
        /// <param name="py2">Coordenada del punto2 en Y</param>
        /// <param name="px3">Coordenada del punto3 en X</param>
        /// <param name="py3">Coordenada del punto3 en Y</param>
        /// <returns></returns>
        public double CalcularAreaTriangulo(double px1, double py1, double px2, double py2, double px3, double py3)
        {
            Triangulo t = new Triangulo(new Punto(px1, py1), new Punto(px2, py2), new Punto(px3, py3));
            return t.Area;
        }
        /// <summary>
        /// Se encarga de recibir los valores de program y llama al constructor de Circulo, luego accede a la propiedad Perimetro de este
        /// </summary>
        /// <param name="px">Coordenada del Centro en X</param>
        /// <param name="py">Coordenada del Centro en y</param>
        /// <param name="pr">Valor real del Radio del Circulo</param>
        /// <returns></returns>
        public double CalcularPerimetroCirculo(double px, double py, double pr)
        {
            Circulo c = new Circulo(px, py, pr);
            return c.Perimetro;
        }
        /// <summary>
        /// Se encarga de recibir los valores de program y llama al constructor de Triangulo, luego accede a la propiedad Area
        /// </summary>
        /// <param name="px">Coordenada del Centro en X</param>
        /// <param name="py">Coordenada del Centro en y</param>
        /// <param name="pr">Valor real del Radio del Circulo</param>
        /// <returns></returns>
        public double CalcularAreaCirculo(double px, double py, double pr)
        {
            Circulo c = new Circulo(px, py, pr);
            return c.Area;
        }
    }
}
