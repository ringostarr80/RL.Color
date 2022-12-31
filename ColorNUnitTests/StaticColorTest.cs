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
            Assert.AreEqual(new Color(0x00, 0x00, 0x00, 0x00), Color.Empty);

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

            Assert.AreEqual(new Color(0xFF, 0xF0, 0xFF, 0xF0), Color.Honeydew);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0x69, 0xB4), Color.HotPink);

            Assert.AreEqual(new Color(0xFF, 0xCD, 0x5C, 0x5C), Color.IndianRed);
            Assert.AreEqual(new Color(0xFF, 0x4B, 0x00, 0x82), Color.Indigo);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xFF, 0xF0), Color.Ivory);

            Assert.AreEqual(new Color(0xFF, 0xF0, 0xE6, 0x8C), Color.Khaki);

            Assert.AreEqual(new Color(0xFF, 0xE6, 0xE6, 0xFA), Color.Lavender);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xF0, 0xF5), Color.LavenderBlush);
            Assert.AreEqual(new Color(0xFF, 0x7C, 0xFC, 0x00), Color.LawnGreen);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xFA, 0xCD), Color.LemonChiffon);
            Assert.AreEqual(new Color(0xFF, 0xAD, 0xD8, 0xE6), Color.LightBlue);
            Assert.AreEqual(new Color(0xFF, 0xF0, 0x80, 0x80), Color.LightCoral);
            Assert.AreEqual(new Color(0xFF, 0xE0, 0xFF, 0xFF), Color.LightCyan);
            Assert.AreEqual(new Color(0xFF, 0xFA, 0xFA, 0xD2), Color.LightGoldenrodYellow);
            Assert.AreEqual(new Color(0xFF, 0xD3, 0xD3, 0xD3), Color.LightGray);
            Assert.AreEqual(new Color(0xFF, 0x90, 0xEE, 0x90), Color.LightGreen);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xB6, 0xC1), Color.LightPink);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xA0, 0x7A), Color.LightSalmon);
            Assert.AreEqual(new Color(0xFF, 0x20, 0xB2, 0xAA), Color.LightSeaGreen);
            Assert.AreEqual(new Color(0xFF, 0x87, 0xCE, 0xFA), Color.LightSkyBlue);
            Assert.AreEqual(new Color(0xFF, 0x77, 0x88, 0x99), Color.LightSlateGray);
            Assert.AreEqual(new Color(0xFF, 0xB0, 0xC4, 0xDE), Color.LightSteelBlue);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xFF, 0xE0), Color.LightYellow);
            Assert.AreEqual(new Color(0xFF, 0x00, 0xFF, 0x00), Color.Lime);
            Assert.AreEqual(new Color(0xFF, 0x32, 0xCD, 0x32), Color.LimeGreen);
            Assert.AreEqual(new Color(0xFF, 0xFA, 0xF0, 0xE6), Color.Linen);

            Assert.AreEqual(new Color(0xFF, 0xFF, 0x00, 0xFF), Color.Magenta);
            Assert.AreEqual(new Color(0xFF, 0x80, 0x00, 0x00), Color.Maroon);
            Assert.AreEqual(new Color(0xFF, 0x66, 0xCD, 0xAA), Color.MediumAquamarine);
            Assert.AreEqual(new Color(0xFF, 0x00, 0x00, 0xCD), Color.MediumBlue);
            Assert.AreEqual(new Color(0xFF, 0xBA, 0x55, 0xD3), Color.MediumOrchid);
            Assert.AreEqual(new Color(0xFF, 0x93, 0x70, 0xDB), Color.MediumPurple);
            Assert.AreEqual(new Color(0xFF, 0x3C, 0xB3, 0x71), Color.MediumSeaGreen);
            Assert.AreEqual(new Color(0xFF, 0x7B, 0x68, 0xEE), Color.MediumSlateBlue);
            Assert.AreEqual(new Color(0xFF, 0x00, 0xFA, 0x9A), Color.MediumSpringGreen);
            Assert.AreEqual(new Color(0xFF, 0x48, 0xD1, 0xCC), Color.MediumTurquoise);
            Assert.AreEqual(new Color(0xFF, 0xC7, 0x15, 0x85), Color.MediumVioletRed);
            Assert.AreEqual(new Color(0xFF, 0x19, 0x19, 0x70), Color.MidnightBlue);
            Assert.AreEqual(new Color(0xFF, 0xF5, 0xFF, 0xFA), Color.MintCream);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xE4, 0xE1), Color.MistyRose);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xE4, 0xB5), Color.Moccasin);

            Assert.AreEqual(new Color(0xFF, 0xFF, 0xDE, 0xAD), Color.NavajoWhite);
            Assert.AreEqual(new Color(0xFF, 0x00, 0x00, 0x80), Color.Navy);

            Assert.AreEqual(new Color(0xFF, 0xFD, 0xF5, 0xE6), Color.OldLace);
            Assert.AreEqual(new Color(0xFF, 0x80, 0x80, 0x00), Color.Olive);
            Assert.AreEqual(new Color(0xFF, 0x6B, 0x8E, 0x23), Color.OliveDrab);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xA5, 0x00), Color.Orange);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0x45, 0x00), Color.OrangeRed);
            Assert.AreEqual(new Color(0xFF, 0xDA, 0x70, 0xD6), Color.Orchid);

            Assert.AreEqual(new Color(0xFF, 0xEE, 0xE8, 0xAA), Color.PaleGoldenrod);
            Assert.AreEqual(new Color(0xFF, 0x98, 0xFB, 0x98), Color.PaleGreen);
            Assert.AreEqual(new Color(0xFF, 0xAF, 0xEE, 0xEE), Color.PaleTurquoise);
            Assert.AreEqual(new Color(0xFF, 0xDB, 0x70, 0x93), Color.PaleVioletRed);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xEF, 0xD5), Color.PapayaWhip);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xDA, 0xB9), Color.PeachPuff);
            Assert.AreEqual(new Color(0xFF, 0xCD, 0x85, 0x3F), Color.Peru);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xC0, 0xCB), Color.Pink);
            Assert.AreEqual(new Color(0xFF, 0xDD, 0xA0, 0xDD), Color.Plum);
            Assert.AreEqual(new Color(0xFF, 0xB0, 0xE0, 0xE6), Color.PowderBlue);
            Assert.AreEqual(new Color(0xFF, 0x80, 0x00, 0x80), Color.Purple);

            Assert.AreEqual(new Color(0xFF, 0xFF, 0x00, 0x00), Color.Red);
            Assert.AreEqual(new Color(0xFF, 0xBC, 0x8F, 0x8F), Color.RosyBrown);
            Assert.AreEqual(new Color(0xFF, 0x41, 0x69, 0xE1), Color.RoyalBlue);

            Assert.AreEqual(new Color(0xFF, 0x8B, 0x45, 0x13), Color.SaddleBrown);
            Assert.AreEqual(new Color(0xFF, 0xFA, 0x80, 0x72), Color.Salmon);
            Assert.AreEqual(new Color(0xFF, 0xF4, 0xA4, 0x60), Color.SandyBrown);
            Assert.AreEqual(new Color(0xFF, 0x2E, 0x8B, 0x57), Color.SeaGreen);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xF5, 0xEE), Color.SeaShell);
            Assert.AreEqual(new Color(0xFF, 0xA0, 0x52, 0x2D), Color.Sienna);
            Assert.AreEqual(new Color(0xFF, 0xC0, 0xC0, 0xC0), Color.Silver);
            Assert.AreEqual(new Color(0xFF, 0x87, 0xCE, 0xEB), Color.SkyBlue);
            Assert.AreEqual(new Color(0xFF, 0x6A, 0x5A, 0xCD), Color.SlateBlue);
            Assert.AreEqual(new Color(0xFF, 0x70, 0x80, 0x90), Color.SlateGray);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xFA, 0xFA), Color.Snow);
            Assert.AreEqual(new Color(0xFF, 0x00, 0xFF, 0x7F), Color.SpringGreen);
            Assert.AreEqual(new Color(0xFF, 0x46, 0x82, 0xB4), Color.SteelBlue);

            Assert.AreEqual(new Color(0xFF, 0xD2, 0xB4, 0x8C), Color.Tan);
            Assert.AreEqual(new Color(0xFF, 0x00, 0x80, 0x80), Color.Teal);
            Assert.AreEqual(new Color(0xFF, 0xD8, 0xBF, 0xD8), Color.Thistle);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0x63, 0x47), Color.Tomato);
            Assert.AreEqual(new Color(0x00, 0xFF, 0xFF, 0xFF), Color.Transparent);
            Assert.AreEqual(new Color(0xFF, 0x40, 0xE0, 0xD0), Color.Turquoise);

            Assert.AreEqual(new Color(0xFF, 0xEE, 0x82, 0xEE), Color.Violet);

            Assert.AreEqual(new Color(0xFF, 0xF5, 0xDE, 0xB3), Color.Wheat);
            Assert.AreEqual(new Color(0xFF, 0xFF, 0xFF, 0xFF), Color.White);
            Assert.AreEqual(new Color(0xFF, 0xF5, 0xF5, 0xF5), Color.WhiteSmoke);

            Assert.AreEqual(new Color(0xFF, 0xFF, 0xFF, 0x00), Color.Yellow);
            Assert.AreEqual(new Color(0xFF, 0x9A, 0xCD, 0x32), Color.YellowGreen);
        }
    }
}