using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilitario;

namespace UtilitarioUnitTest
{
    [TestClass]
    public class MatematicaTeste
    {
        [TestMethod]
        public void TesteSomatorio()
        {
            // Arrange
            Matematica mat = new Matematica();
            int[] arrayValores = new int[]{ 1, 2, 3};
            
            long resultadoEsperado_1 = 6;
            long resultadoEsperado_2 = 10;
            long resultadoEsperado_3 = 0;
            long resultadoEsperado_4 = -10;

            // Act
            long resultadoAtual_1 = mat.Somatorio(arrayValores);
            long resultadoAtual_2 = mat.Somatorio(1, 2, 3, 4);
            long resultadoAtual_3 = mat.Somatorio(0);            
            long resultadoAtual_4 = mat.Somatorio(-1, -2, -3, -4);

            // Assert
            Assert.AreEqual(resultadoEsperado_1, resultadoAtual_1,
                "O método somatório aceita arrays: [1,2,3] e o resultado é 6.");

            Assert.AreEqual(resultadoEsperado_2, resultadoAtual_2,
                "O método somatório aceita número variável de parâmetros (1, 2, 3, 4) e o resultado é 10.");

            Assert.AreEqual(resultadoEsperado_3, resultadoAtual_3,
                "O método somatório de 0 é 0.");

            Assert.AreEqual(resultadoEsperado_4, resultadoAtual_4,
                "O método somatório de número negativos, resultado: -10.");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TesteSomatorioSemArgumentos()
        {
            // Arrange
            Matematica mat = new Matematica();
            
            // Act
            long resultadoAtual_1 = mat.Somatorio();            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TesteSomatorioArrayNulo()
        {
            // Arrange
            Matematica mat = new Matematica();
            int[] arrayNulo = null;

            // Act
            long resultadoAtual = mat.Somatorio(arrayNulo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TesteSomatorioArrayVazio()
        {
            // Arrange
            Matematica mat = new Matematica();
            int[] arrayVazio = new int[] { };

            // Act
            long resultadoAtual_1 = mat.Somatorio(arrayVazio);
        }
    }
}
