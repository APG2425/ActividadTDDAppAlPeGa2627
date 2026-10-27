using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActividadTDDAppAlPeGa2627;

namespace TestActividadTDDAppAlPeGa2627
{
    [TestClass]
    public class FuncionesTestAlPeGa2627
    {
        [TestMethod]
        public void Factorial_NumeroNegativo()
        {
            FuncionesAlPeGa2627 funcion = new FuncionesAlPeGa2627();

            long resultado = funcion.CalcularFactorial(-1);

            Assert.AreEqual(-1L, resultado);
        }

        [TestMethod]
        public void Factorial_Cero()
        {
            FuncionesAlPeGa2627 funcion = new FuncionesAlPeGa2627();

            long resultado = funcion.CalcularFactorial(0);

            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void Factorial_Positivo()
        {
            FuncionesAlPeGa2627 funcion = new FuncionesAlPeGa2627();

            long resultado = funcion.CalcularFactorial(4);

            Assert.AreEqual(24L, resultado);
        }

        [TestMethod]
        public void Contrasenya_Vacia()
        {
            FuncionesAlPeGa2627 funcion = new FuncionesAlPeGa2627();

            bool resultado = funcion.EsContrasenyaValida("");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_Null()
        {
            FuncionesAlPeGa2627 funcion = new FuncionesAlPeGa2627();

            bool resultado = funcion.EsContrasenyaValida(null);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_MenosOchoCaracteres()
        {
            FuncionesAlPeGa2627 funcion = new FuncionesAlPeGa2627();

            bool resultado = funcion.EsContrasenyaValida("alpe#27");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_SinAlmohadilla()
        {
            FuncionesAlPeGa2627 funcion = new FuncionesAlPeGa2627();

            bool resultado = funcion.EsContrasenyaValida("alpega2627");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Contrasenya_Valida()
        {
            FuncionesAlPeGa2627 funcion = new FuncionesAlPeGa2627();

            bool resultado = funcion.EsContrasenyaValida("alpega#2627");

            Assert.IsTrue(resultado);
        }

    }
}
