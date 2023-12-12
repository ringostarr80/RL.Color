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
            Assert.That(Color.Empty, Is.EqualTo(new Color(0x00, 0x00, 0x00, 0x00)));

            Assert.That(Color.AliceBlue, Is.EqualTo(new Color(0xFF, 0xF0, 0xF8, 0xFF)));
            Assert.That(Color.AntiqueWhite, Is.EqualTo(new Color(0xFF, 0xFA, 0xEB, 0xD7)));
            Assert.That(Color.Aqua, Is.EqualTo(new Color(0xFF, 0x00, 0xFF, 0xFF)));
            Assert.That(Color.Aquamarine, Is.EqualTo(new Color(0xFF, 0x7F, 0xFF, 0xD4)));
            Assert.That(Color.Azure, Is.EqualTo(new Color(0xFF, 0xF0, 0xFF, 0xFF)));

            Assert.That(Color.Beige, Is.EqualTo(new Color(0xFF, 0xF5, 0xF5, 0xDC)));
            Assert.That(Color.Bisque, Is.EqualTo(new Color(0xFF, 0xFF, 0xE4, 0xC4)));
            Assert.That(Color.Black, Is.EqualTo(new Color(0xFF, 0x00, 0x00, 0x00)));
            Assert.That(Color.BlanchedAlmond, Is.EqualTo(new Color(0xFF, 0xFF, 0xEB, 0xCD)));
            Assert.That(Color.Blue, Is.EqualTo(new Color(0xFF, 0x00, 0x00, 0xFF)));
            Assert.That(Color.BlueViolet, Is.EqualTo(new Color(0xFF, 0x8A, 0x2B, 0xE2)));
            Assert.That(Color.Brown, Is.EqualTo(new Color(0xFF, 0xA5, 0x2A, 0x2A)));
            Assert.That(Color.BurlyWood, Is.EqualTo(new Color(0xFF, 0xDE, 0xB8, 0x87)));

            Assert.That(Color.CadetBlue, Is.EqualTo(new Color(0xFF, 0x5F, 0x9E, 0xA0)));
            Assert.That(Color.Chartreuse, Is.EqualTo(new Color(0xFF, 0x7F, 0xFF, 0x00)));
            Assert.That(Color.Chocolate, Is.EqualTo(new Color(0xFF, 0xD2, 0x69, 0x1E)));
            Assert.That(Color.Coral, Is.EqualTo(new Color(0xFF, 0xFF, 0x7F, 0x50)));
            Assert.That(Color.CornflowerBlue, Is.EqualTo(new Color(0xFF, 0x64, 0x95, 0xED)));
            Assert.That(Color.Cornsilk, Is.EqualTo(new Color(0xFF, 0xFF, 0xF8, 0xDC)));
            Assert.That(Color.Crimson, Is.EqualTo(new Color(0xFF, 0xDC, 0x14, 0x3C)));
            Assert.That(Color.Cyan, Is.EqualTo(new Color(0xFF, 0x00, 0xFF, 0xFF)));

            Assert.That(Color.DarkBlue, Is.EqualTo(new Color(0xFF, 0x00, 0x00, 0x8B)));
            Assert.That(Color.DarkCyan, Is.EqualTo(new Color(0xFF, 0x00, 0x8B, 0x8B)));
            Assert.That(Color.DarkGoldenrod, Is.EqualTo(new Color(0xFF, 0xB8, 0x86, 0x0B)));
            Assert.That(Color.DarkGray, Is.EqualTo(new Color(0xFF, 0xA9, 0xA9, 0xA9)));
            Assert.That(Color.DarkGreen, Is.EqualTo(new Color(0xFF, 0x00, 0x64, 0x00)));
            Assert.That(Color.DarkKhaki, Is.EqualTo(new Color(0xFF, 0xBD, 0xB7, 0x6B)));
            Assert.That(Color.DarkMagenta, Is.EqualTo(new Color(0xFF, 0x8B, 0x00, 0x8B)));
            Assert.That(Color.DarkOliveGreen, Is.EqualTo(new Color(0xFF, 0x55, 0x6B, 0x2F)));
            Assert.That(Color.DarkOrange, Is.EqualTo(new Color(0xFF, 0xFF, 0x8C, 0x00)));
            Assert.That(Color.DarkOrchid, Is.EqualTo(new Color(0xFF, 0x99, 0x32, 0xCC)));
            Assert.That(Color.DarkRed, Is.EqualTo(new Color(0xFF, 0x8B, 0x00, 0x00)));
            Assert.That(Color.DarkSalmon, Is.EqualTo(new Color(0xFF, 0xE9, 0x96, 0x7A)));
            Assert.That(Color.DarkSeaGreen, Is.EqualTo(new Color(0xFF, 0x8F, 0xBC, 0x8F)));
            Assert.That(Color.DarkSlateBlue, Is.EqualTo(new Color(0xFF, 0x48, 0x3D, 0x8B)));
            Assert.That(Color.DarkSlateGray, Is.EqualTo(new Color(0xFF, 0x2F, 0x4F, 0x4F)));
            Assert.That(Color.DarkTurquoise, Is.EqualTo(new Color(0xFF, 0x00, 0xCE, 0xD1)));
            Assert.That(Color.DarkViolet, Is.EqualTo(new Color(0xFF, 0x94, 0x00, 0xD3)));
            Assert.That(Color.DeepPink, Is.EqualTo(new Color(0xFF, 0xFF, 0x14, 0x93)));
            Assert.That(Color.DeepSkyBlue, Is.EqualTo(new Color(0xFF, 0x00, 0xBF, 0xFF)));
            Assert.That(Color.DimGray, Is.EqualTo(new Color(0xFF, 0x69, 0x69, 0x69)));
            Assert.That(Color.DodgerBlue, Is.EqualTo(new Color(0xFF, 0x1E, 0x90, 0xFF)));

            Assert.That(Color.Firebrick, Is.EqualTo(new Color(0xFF, 0xB2, 0x22, 0x22)));
            Assert.That(Color.FloralWhite, Is.EqualTo(new Color(0xFF, 0xFF, 0xFA, 0xF0)));
            Assert.That(Color.ForestGreen, Is.EqualTo(new Color(0xFF, 0x22, 0x8B, 0x22)));
            Assert.That(Color.Fuchsia, Is.EqualTo(new Color(0xFF, 0xFF, 0x00, 0xFF)));

            Assert.That(Color.Gainsboro, Is.EqualTo(new Color(0xFF, 0xDC, 0xDC, 0xDC)));
            Assert.That(Color.GhostWhite, Is.EqualTo(new Color(0xFF, 0xF8, 0xF8, 0xFF)));
            Assert.That(Color.Gold, Is.EqualTo(new Color(0xFF, 0xFF, 0xD7, 0x00)));
            Assert.That(Color.Goldenrod, Is.EqualTo(new Color(0xFF, 0xDA, 0xA5, 0x20)));
            Assert.That(Color.Gray, Is.EqualTo(new Color(0xFF, 0x80, 0x80, 0x80)));
            Assert.That(Color.Green, Is.EqualTo(new Color(0xFF, 0x00, 0x80, 0x00)));
            Assert.That(Color.GreenYellow, Is.EqualTo(new Color(0xFF, 0xAD, 0xFF, 0x2F)));

            Assert.That(Color.Honeydew, Is.EqualTo(new Color(0xFF, 0xF0, 0xFF, 0xF0)));
            Assert.That(Color.HotPink, Is.EqualTo(new Color(0xFF, 0xFF, 0x69, 0xB4)));

            Assert.That(Color.IndianRed, Is.EqualTo(new Color(0xFF, 0xCD, 0x5C, 0x5C)));
            Assert.That(Color.Indigo, Is.EqualTo(new Color(0xFF, 0x4B, 0x00, 0x82)));
            Assert.That(Color.Ivory, Is.EqualTo(new Color(0xFF, 0xFF, 0xFF, 0xF0)));

            Assert.That(Color.Khaki, Is.EqualTo(new Color(0xFF, 0xF0, 0xE6, 0x8C)));

            Assert.That(Color.Lavender, Is.EqualTo(new Color(0xFF, 0xE6, 0xE6, 0xFA)));
            Assert.That(Color.LavenderBlush, Is.EqualTo(new Color(0xFF, 0xFF, 0xF0, 0xF5)));
            Assert.That(Color.LawnGreen, Is.EqualTo(new Color(0xFF, 0x7C, 0xFC, 0x00)));
            Assert.That(Color.LemonChiffon, Is.EqualTo(new Color(0xFF, 0xFF, 0xFA, 0xCD)));
            Assert.That(Color.LightBlue, Is.EqualTo(new Color(0xFF, 0xAD, 0xD8, 0xE6)));
            Assert.That(Color.LightCoral, Is.EqualTo(new Color(0xFF, 0xF0, 0x80, 0x80)));
            Assert.That(Color.LightCyan, Is.EqualTo(new Color(0xFF, 0xE0, 0xFF, 0xFF)));
            Assert.That(Color.LightGoldenrodYellow, Is.EqualTo(new Color(0xFF, 0xFA, 0xFA, 0xD2)));
            Assert.That(Color.LightGray, Is.EqualTo(new Color(0xFF, 0xD3, 0xD3, 0xD3)));
            Assert.That(Color.LightGreen, Is.EqualTo(new Color(0xFF, 0x90, 0xEE, 0x90)));
            Assert.That(Color.LightPink, Is.EqualTo(new Color(0xFF, 0xFF, 0xB6, 0xC1)));
            Assert.That(Color.LightSalmon, Is.EqualTo(new Color(0xFF, 0xFF, 0xA0, 0x7A)));
            Assert.That(Color.LightSeaGreen, Is.EqualTo(new Color(0xFF, 0x20, 0xB2, 0xAA)));
            Assert.That(Color.LightSkyBlue, Is.EqualTo(new Color(0xFF, 0x87, 0xCE, 0xFA)));
            Assert.That(Color.LightSlateGray, Is.EqualTo(new Color(0xFF, 0x77, 0x88, 0x99)));
            Assert.That(Color.LightSteelBlue, Is.EqualTo(new Color(0xFF, 0xB0, 0xC4, 0xDE)));
            Assert.That(Color.LightYellow, Is.EqualTo(new Color(0xFF, 0xFF, 0xFF, 0xE0)));
            Assert.That(Color.Lime, Is.EqualTo(new Color(0xFF, 0x00, 0xFF, 0x00)));
            Assert.That(Color.LimeGreen, Is.EqualTo(new Color(0xFF, 0x32, 0xCD, 0x32)));
            Assert.That(Color.Linen, Is.EqualTo(new Color(0xFF, 0xFA, 0xF0, 0xE6)));

            Assert.That(Color.Magenta, Is.EqualTo(new Color(0xFF, 0xFF, 0x00, 0xFF)));
            Assert.That(Color.Maroon, Is.EqualTo(new Color(0xFF, 0x80, 0x00, 0x00)));
            Assert.That(Color.MediumAquamarine, Is.EqualTo(new Color(0xFF, 0x66, 0xCD, 0xAA)));
            Assert.That(Color.MediumBlue, Is.EqualTo(new Color(0xFF, 0x00, 0x00, 0xCD)));
            Assert.That(Color.MediumOrchid, Is.EqualTo(new Color(0xFF, 0xBA, 0x55, 0xD3)));
            Assert.That(Color.MediumPurple, Is.EqualTo(new Color(0xFF, 0x93, 0x70, 0xDB)));
            Assert.That(Color.MediumSeaGreen, Is.EqualTo(new Color(0xFF, 0x3C, 0xB3, 0x71)));
            Assert.That(Color.MediumSlateBlue, Is.EqualTo(new Color(0xFF, 0x7B, 0x68, 0xEE)));
            Assert.That(Color.MediumSpringGreen, Is.EqualTo(new Color(0xFF, 0x00, 0xFA, 0x9A)));
            Assert.That(Color.MediumTurquoise, Is.EqualTo(new Color(0xFF, 0x48, 0xD1, 0xCC)));
            Assert.That(Color.MediumVioletRed, Is.EqualTo(new Color(0xFF, 0xC7, 0x15, 0x85)));
            Assert.That(Color.MidnightBlue, Is.EqualTo(new Color(0xFF, 0x19, 0x19, 0x70)));
            Assert.That(Color.MintCream, Is.EqualTo(new Color(0xFF, 0xF5, 0xFF, 0xFA)));
            Assert.That(Color.MistyRose, Is.EqualTo(new Color(0xFF, 0xFF, 0xE4, 0xE1)));
            Assert.That(Color.Moccasin, Is.EqualTo(new Color(0xFF, 0xFF, 0xE4, 0xB5)));

            Assert.That(Color.NavajoWhite, Is.EqualTo(new Color(0xFF, 0xFF, 0xDE, 0xAD)));
            Assert.That(Color.Navy, Is.EqualTo(new Color(0xFF, 0x00, 0x00, 0x80)));

            Assert.That(Color.OldLace, Is.EqualTo(new Color(0xFF, 0xFD, 0xF5, 0xE6)));
            Assert.That(Color.Olive,Is.EqualTo(new Color(0xFF, 0x80, 0x80, 0x00)));
            Assert.That(Color.OliveDrab, Is.EqualTo(new Color(0xFF, 0x6B, 0x8E, 0x23)));
            Assert.That(Color.Orange, Is.EqualTo(new Color(0xFF, 0xFF, 0xA5, 0x00)));
            Assert.That(Color.OrangeRed, Is.EqualTo(new Color(0xFF, 0xFF, 0x45, 0x00)));
            Assert.That(Color.Orchid, Is.EqualTo(new Color(0xFF, 0xDA, 0x70, 0xD6)));

            Assert.That(Color.PaleGoldenrod, Is.EqualTo(new Color(0xFF, 0xEE, 0xE8, 0xAA)));
            Assert.That(Color.PaleGreen, Is.EqualTo(new Color(0xFF, 0x98, 0xFB, 0x98)));
            Assert.That(Color.PaleTurquoise, Is.EqualTo(new Color(0xFF, 0xAF, 0xEE, 0xEE)));
            Assert.That(Color.PaleVioletRed, Is.EqualTo(new Color(0xFF, 0xDB, 0x70, 0x93)));
            Assert.That(Color.PapayaWhip, Is.EqualTo(new Color(0xFF, 0xFF, 0xEF, 0xD5)));
            Assert.That(Color.PeachPuff, Is.EqualTo(new Color(0xFF, 0xFF, 0xDA, 0xB9)));
            Assert.That(Color.Peru, Is.EqualTo(new Color(0xFF, 0xCD, 0x85, 0x3F)));
            Assert.That(Color.Pink, Is.EqualTo(new Color(0xFF, 0xFF, 0xC0, 0xCB)));
            Assert.That(Color.Plum, Is.EqualTo(new Color(0xFF, 0xDD, 0xA0, 0xDD)));
            Assert.That(Color.PowderBlue, Is.EqualTo(new Color(0xFF, 0xB0, 0xE0, 0xE6)));
            Assert.That(Color.Purple, Is.EqualTo(new Color(0xFF, 0x80, 0x00, 0x80)));

            Assert.That(Color.Red, Is.EqualTo(new Color(0xFF, 0xFF, 0x00, 0x00)));
            Assert.That(Color.RosyBrown, Is.EqualTo(new Color(0xFF, 0xBC, 0x8F, 0x8F)));
            Assert.That(Color.RoyalBlue, Is.EqualTo(new Color(0xFF, 0x41, 0x69, 0xE1)));

            Assert.That(Color.SaddleBrown, Is.EqualTo(new Color(0xFF, 0x8B, 0x45, 0x13)));
            Assert.That(Color.Salmon, Is.EqualTo(new Color(0xFF, 0xFA, 0x80, 0x72)));
            Assert.That(Color.SandyBrown, Is.EqualTo(new Color(0xFF, 0xF4, 0xA4, 0x60)));
            Assert.That(Color.SeaGreen, Is.EqualTo(new Color(0xFF, 0x2E, 0x8B, 0x57)));
            Assert.That(Color.SeaShell, Is.EqualTo(new Color(0xFF, 0xFF, 0xF5, 0xEE)));
            Assert.That(Color.Sienna, Is.EqualTo(new Color(0xFF, 0xA0, 0x52, 0x2D)));
            Assert.That(Color.Silver, Is.EqualTo(new Color(0xFF, 0xC0, 0xC0, 0xC0)));
            Assert.That(Color.SkyBlue, Is.EqualTo(new Color(0xFF, 0x87, 0xCE, 0xEB)));
            Assert.That(Color.SlateBlue, Is.EqualTo(new Color(0xFF, 0x6A, 0x5A, 0xCD)));
            Assert.That(Color.SlateGray, Is.EqualTo(new Color(0xFF, 0x70, 0x80, 0x90)));
            Assert.That(Color.Snow, Is.EqualTo(new Color(0xFF, 0xFF, 0xFA, 0xFA)));
            Assert.That(Color.SpringGreen, Is.EqualTo(new Color(0xFF, 0x00, 0xFF, 0x7F)));
            Assert.That(Color.SteelBlue, Is.EqualTo(new Color(0xFF, 0x46, 0x82, 0xB4)));

            Assert.That(Color.Tan, Is.EqualTo(new Color(0xFF, 0xD2, 0xB4, 0x8C)));
            Assert.That(Color.Teal, Is.EqualTo(new Color(0xFF, 0x00, 0x80, 0x80)));
            Assert.That(Color.Thistle, Is.EqualTo(new Color(0xFF, 0xD8, 0xBF, 0xD8)));
            Assert.That(Color.Tomato, Is.EqualTo(new Color(0xFF, 0xFF, 0x63, 0x47)));
            Assert.That(Color.Transparent, Is.EqualTo(new Color(0x00, 0xFF, 0xFF, 0xFF)));
            Assert.That(Color.Turquoise, Is.EqualTo(new Color(0xFF, 0x40, 0xE0, 0xD0)));

            Assert.That(Color.Violet, Is.EqualTo(new Color(0xFF, 0xEE, 0x82, 0xEE)));

            Assert.That(Color.Wheat, Is.EqualTo(new Color(0xFF, 0xF5, 0xDE, 0xB3)));
            Assert.That(Color.White, Is.EqualTo(new Color(0xFF, 0xFF, 0xFF, 0xFF)));
            Assert.That(Color.WhiteSmoke, Is.EqualTo(new Color(0xFF, 0xF5, 0xF5, 0xF5)));

            Assert.That(Color.Yellow, Is.EqualTo(new Color(0xFF, 0xFF, 0xFF, 0x00)));
            Assert.That(Color.YellowGreen, Is.EqualTo(new Color(0xFF, 0x9A, 0xCD, 0x32)));
        }
    }
}