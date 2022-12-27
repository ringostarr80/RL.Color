using NUnit.Framework;
using RL;

namespace ColorNUnitTests
{
    [TestFixture]
    public class StaticColorTest
    {
        [Test]
        public void TestStaticColors()
        {
            Assert.AreEqual(new Color(0xFF, 0xF0, 0xF8, 0xFF), Color.AliceBlue);
            Assert.AreEqual(new Color(0xFF, 0xFA, 0xEB, 0xD7), Color.AntiqueWhite);
            Assert.AreEqual(new Color(0xFF, 0x00, 0xFF, 0xFF), Color.Aqua);
            Assert.AreEqual(new Color(0xFF, 0x7F, 0xFF, 0xD4), Color.Aquamarine);
            Assert.AreEqual(new Color(0xFF, 0xF0, 0xFF, 0xFF), Color.Azure);
            Assert.AreEqual(new Color(0xFF, 0xF5, 0xF5, 0xDC), Color.Beige);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xE4, 0xC4), Color.Bisque);
            Assert.AreEqual(new Color(0xFF, 0x00, 0x00, 0x00), Color.Black);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xEB, 0xCD), Color.BlanchedAlmond);
            Assert.AreEqual(new Color(0xFF, 0x00, 0x00, 0xFF), Color.Blue);
            Assert.AreEqual(new Color(0xFF, 0x8A, 0x2B, 0xE2), Color.BlueViolet);
            Assert.AreEqual(new Color(0xFF, 0xA5, 0x2A, 0x2A), Color.Brown);
            Assert.AreEqual(new Color(0xFF, 0xDE, 0xB8, 0x87), Color.BurlyWood);
        }
    }
}