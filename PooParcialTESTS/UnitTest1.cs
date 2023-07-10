using PooParcial.Entidades;

namespace PooParcialTESTS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarArea()
        {
            double radio = 2;
            double Generatiz = 2;

            Cono c = new Cono(radio, Generatiz);

            Assert.IsFalse(c.GetArea() ==25);
        }

        [TestMethod]

        public void validarVolumen()
        {
            double radio = 2;
            double altura = 2;

            Cono c = new Cono(radio, altura);
            Assert.IsFalse(c.CalcularVolumen() ==8);

        }
    }
}