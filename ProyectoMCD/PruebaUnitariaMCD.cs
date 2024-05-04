using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMCD
{
    public class PruebaUnitariaMCD
    {
        public static int CalcularMCD(int a, int b)
        {
            while (b != 0) //Se ejecutará el while mientras b sea diferente de cero.
            {
                int temp = b;   // Almacenaremos temporalmente el valor de b.
                b = a % b;      // Calculamos el residuo de la división de a entre b y se actualizará b con ese valor.
                a = temp;       // Restaura el valor original de b en a.
            }
            return a;           // Devuelve a, que contiene el máximo común divisor calculado.
        }

        public static int CalcularCuatroNumerosMCD(int a, int b, int c, int d)
        {
            //Aquí retornamos el calculo del máximo común divisor (MCD) de los números a, b, c y d
            return CalcularMCD(CalcularMCD(CalcularMCD(a, b), c), d);
        }
    }
}
