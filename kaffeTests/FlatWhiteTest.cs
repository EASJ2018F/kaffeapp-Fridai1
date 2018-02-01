using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffe.Tests
{
    [TestClass()]
    public class FlatWhiteTest
    {
        [TestMethod()]
        public void prisTest()
        {
            //Arrange
            FlatWhite kaffe = new FlatWhite();
            //Act
            int pris = kaffe.Pris();
            //Assert
            Assert.AreEqual(45, pris);

        }

        [TestMethod()]
        public void MiMælkTest()
        {
            //Arrange
            FlatWhite kaffe = new FlatWhite();
            //Act
            int miMælk = kaffe.MlMælk();
            //Assert
            Assert.AreEqual(160, miMælk);

        }

        public void StykeTest()
        {
            //Arrange
            FlatWhite kaffe = new FlatWhite();
            //Act
            string Styrke = kaffe.Styrke();
            //Assert
            Assert.AreEqual("mild", Styrke);

        }
    }
}