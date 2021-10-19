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

            Assert.AreEqual(diamond.Create('A'), stringBuilder.ToString());
        }

        [Test]
        public void GivenCharacterB_ShouldCreateDiamondWithCharactersAtoB()
        {
            stringBuilder.Append(" A \n");
            stringBuilder.Append("B B\n");
            stringBuilder.Append(" A \n");

            Assert.AreEqual(diamond.Create('B'), stringBuilder.ToString());
        }

        [Test]
        public void GivenCharacterC_ShouldCreateDiamondWithCharactersAtoC()
        {
            stringBuilder.Append("  A  \n");
            stringBuilder.Append(" B B \n");
            stringBuilder.Append("C   C\n");
            stringBuilder.Append(" B B \n");
            stringBuilder.Append("  A  \n");

            Assert.AreEqual(diamond.Create('C'), stringBuilder.ToString());
        }

        [Test]
        public void GivenCharacterF_ShouldCreateDiamondWithCharactersAtoF()
        {
            stringBuilder.Append("     A     \n");
            stringBuilder.Append("    B B    \n");
            stringBuilder.Append("   C   C   \n");
            stringBuilder.Append("  D     D  \n");
            stringBuilder.Append(" E       E \n");
            stringBuilder.Append("F         F\n");
            stringBuilder.Append(" E       E \n");
            stringBuilder.Append("  D     D  \n");
            stringBuilder.Append("   C   C   \n");
            stringBuilder.Append("    B B    \n");
            stringBuilder.Append("     A     \n");

            Assert.AreEqual(diamond.Create('F'), stringBuilder.ToString());
        }

        [Test]
        public void GivenCharacterNotInAtoZSet_ShouldReturnNull()
        {
            Assert.IsNull(diamond.Create('a'));
            Assert.IsNull(diamond.Create('1'));
            Assert.IsNull(diamond.Create(' '));
        }
    }
}