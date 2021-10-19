using DiamondKata.ClassLibrary;
using NUnit.Framework;
using System.Text;

namespace DiamondKata.Tests
{
    public class DiamondKataTests
    {
        private Diamond diamond;
        private StringBuilder stringBuilder;

        [SetUp]
        public void Setup()
        {
            diamond = new Diamond();
            stringBuilder = new StringBuilder();
        }

        [Test]
        public void GivenCharacterA_ShouldCreateDiamondWithCharacterA()
        {
            stringBuilder.Append("A\n");

            Assert.AreEqual(diamond.Print('A'), stringBuilder.ToString());
        }

        [Test]
        public void GivenCharacterB_ShouldCreateDiamondWithCharactersAtoB()
        {
            stringBuilder.Append(" A \n");
            stringBuilder.Append("B B\n");
            stringBuilder.Append(" A \n");

            Assert.AreEqual(diamond.Print('B'), stringBuilder.ToString());
        }
    }
}