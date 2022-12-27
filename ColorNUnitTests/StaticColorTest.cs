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

            Assert.AreEqual(new Color(0xFF, 0x5F, 0x9E, 0xA0), Color.CadetBlue);
            Assert.AreEqual(new Color(0xFF, 0x7F, 0xFF, 0x00), Color.Chartreuse);
            Assert.AreEqual(new Color(0xFF, 0xD2, 0x69, 0x1E), Color.Chocolate);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0x7F, 0x50), Color.Coral);
            Assert.AreEqual(new Color(0xFF, 0x64, 0x95, 0xED), Color.CornflowerBlue);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xF8, 0xDC), Color.Cornsilk);
            Assert.AreEqual(new Color(0xFF, 0xDC, 0x14, 0x3C), Color.Crimson);
            Assert.AreEqual(new Color(0xFF, 0x00, 0xFF, 0xFF), Color.Cyan);

            Assert.AreEqual(new Color(0xFF, 0x00, 0x00, 0x8B), Color.DarkBlue);
            Assert.AreEqual(new Color(0xFF, 0x00, 0x8B, 0x8B), Color.DarkCyan);
            Assert.AreEqual(new Color(0xFF, 0xB8, 0x86, 0x0B), Color.DarkGoldenrod);
            Assert.AreEqual(new Color(0xFF, 0xA9, 0xA9, 0xA9), Color.DarkGray);
            Assert.AreEqual(new Color(0xFF, 0x00, 0x64, 0x00), Color.DarkGreen);
            Assert.AreEqual(new Color(0xFF, 0xBD, 0xB7, 0x6B), Color.DarkKhaki);
            Assert.AreEqual(new Color(0xFF, 0x8B, 0x00, 0x8B), Color.DarkMagenta);
            Assert.AreEqual(new Color(0xFF, 0x55, 0x6B, 0x2F), Color.DarkOliveGreen);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0x8C, 0x00), Color.DarkOrange);
            Assert.AreEqual(new Color(0xFF, 0x99, 0x32, 0xCC), Color.DarkOrchid);
            Assert.AreEqual(new Color(0xFF, 0x8B, 0x00, 0x00), Color.DarkRed);
            Assert.AreEqual(new Color(0xFF, 0xE9, 0x96, 0x7A), Color.DarkSalmon);
            Assert.AreEqual(new Color(0xFF, 0x8F, 0xBC, 0x8F), Color.DarkSeaGreen);
            Assert.AreEqual(new Color(0xFF, 0x48, 0x3D, 0x8B), Color.DarkSlateBlue);
            Assert.AreEqual(new Color(0xFF, 0x2F, 0x4F, 0x4F), Color.DarkSlateGray);
            Assert.AreEqual(new Color(0xFF, 0x00, 0xCE, 0xD1), Color.DarkTurquoise);
            Assert.AreEqual(new Color(0xFF, 0x94, 0x00, 0xD3), Color.DarkViolet);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0x14, 0x93), Color.DeepPink);
            Assert.AreEqual(new Color(0xFF, 0x00, 0xBF, 0xFF), Color.DeepSkyBlue);
            Assert.AreEqual(new Color(0xFF, 0x69, 0x69, 0x69), Color.DimGray);
            Assert.AreEqual(new Color(0xFF, 0x1E, 0x90, 0xFF), Color.DodgerBlue);

            Assert.AreEqual(new Color(0xFF, 0xB2, 0x22, 0x22), Color.Firebrick);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xFA, 0xF0), Color.FloralWhite);
            Assert.AreEqual(new Color(0xFF, 0x22, 0x8B, 0x22), Color.ForestGreen);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0x00, 0xFF), Color.Fuchsia);

            Assert.AreEqual(new Color(0xFF, 0xDC, 0xDC, 0xDC), Color.Gainsboro);
            Assert.AreEqual(new Color(0xFF, 0xF8, 0xF8, 0xFF), Color.GhostWhite);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xD7, 0x00), Color.Gold);
            Assert.AreEqual(new Color(0xFF, 0xDA, 0xA5, 0x20), Color.Goldenrod);
            Assert.AreEqual(new Color(0xFF, 0x80, 0x80, 0x80), Color.Gray);
            Assert.AreEqual(new Color(0xFF, 0x00, 0x80, 0x00), Color.Green);
            Assert.AreEqual(new Color(0xFF, 0xAD, 0xFF, 0x2F), Color.GreenYellow);
        }
    }
}