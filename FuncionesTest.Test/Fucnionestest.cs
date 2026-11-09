using Microsoft.VisualStudio.TestTools.UnitTesting;
using PF02_Marwane;

namespace PracticaTDD.Tests
{
    [TestClass]
    public class FuncionesTest
    {
        [TestMethod]
        public void Factorial_Negativo_DevuelveMenosUno()
        {
            long resultado = Funciones.CalcularFactorial(-3);
            Assert.AreEqual(-1L, resultado);
        }

        [TestMethod]
        public void Factorial_Cero_DevuelveUno()
        {
            long resultado = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void Factorial_Uno_DevuelveUno()
        {
            long resultado = Funciones.CalcularFactorial(1);
            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void Factorial_Cinco_Devuelve120()
        {
            long resultado = Funciones.CalcularFactorial(5);
            Assert.AreEqual(120L, resultado);
        }

        [TestMethod]
        public void Factorial_Trece_Devuelve6227020800()
        {
            long resultado = Funciones.CalcularFactorial(13);
            Assert.AreEqual(6227020800L, resultado);
        }

        [TestMethod]
        public void Contrasenya_Valida_DevuelveTrue()
        {
            bool resultado = Funciones.EsContrasenyaValida("Hola#123");
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Contrasenya_Null_DevuelveFalse()
        {
            bool resultado = Funciones.EsContrasenyaValida(null);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_Vacia_DevuelveFalse()
        {
            bool resultado = Funciones.EsContrasenyaValida("");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_MenosDeOchoCaracteres_DevuelveFalse()
        {
            bool resultado = Funciones.EsContrasenyaValida("Abc#12");
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_SinAlmohadilla_DevuelveFalse()
        {
            bool resultado = Funciones.EsContrasenyaValida("Hola1234");
            Assert.IsFalse(resultado);
        }

    }
}