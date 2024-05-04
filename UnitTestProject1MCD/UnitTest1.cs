using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using ProyectoMCD;

namespace UnitTestProject1MCD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int esperado = 3; // Definimos el valor esperado del máximo común divisor (MCD).
            int actual = PruebaUnitariaMCD.CalcularCuatroNumerosMCD(6, 9, 15, 18); // Llamamos a la función que calcula el MCD de cuatro números.
            Assert.AreEqual(esperado, actual); // Verificamos si el valor actual calculado es igual al valor esperado.

        }
    }
}
