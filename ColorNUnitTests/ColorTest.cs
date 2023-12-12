using NUnit.Framework;
using RL;

namespace ColorNUnitTests
{
    [TestFixture]
    public class ColorTest
    {
        [Test]
        public void TestDefaultColor()
        {
            var defaultColor = new Color();
            Assert.That(defaultColor.A, Is.EqualTo(255));
            Assert.That(defaultColor.R, Is.Zero);
            Assert.That(defaultColor.G, Is.Zero);
            Assert.That(defaultColor.B, Is.Zero);
            Assert.That(defaultColor.C, Is.Zero);
            Assert.That(defaultColor.M, Is.Zero);
            Assert.That(defaultColor.Y, Is.Zero);
            Assert.That(defaultColor.K, Is.EqualTo(100.0));
        }

        [Test]
        public void TestInvalidColorString()
        {
            Assert.Throws<System.InvalidCastException>(() => {
                new Color("foo");
            });
        }

        [Test]
        public void TestGetHashCode()
        {
            var color = new Color("red");
            Assert.That(color.GetHashCode().GetType().ToString(), Is.EqualTo("System.Int32"));
        }

        [Test]
        public void TestSystemColorConstructor()
        {
            var sysColor = new Color(System.Drawing.Color.Aqua);
            Assert.That(sysColor.A, Is.EqualTo(255));
            Assert.That(sysColor.R, Is.EqualTo(0));
            Assert.That(sysColor.G, Is.EqualTo(255));
            Assert.That(sysColor.B, Is.EqualTo(255));
        }

        [Test]
        public void TestRGBConstructor()
        {
            var redColor = new Color(255, 0, 0);
            Assert.That(redColor.A, Is.EqualTo(255));
            Assert.That(redColor.R, Is.EqualTo(255));
            Assert.That(redColor.G, Is.EqualTo(0));
            Assert.That(redColor.B, Is.EqualTo(0));
        }

        [Test]
        public void TestDefaultColorToHEXString()
        {
            var defaultColor = new Color();
            Assert.That(defaultColor.ToHEXString(), Is.EqualTo("#000000"));
        }

        [Test]
        public void TestDefaultColorToRGBString()
        {
            var defaultColor = new Color();
            Assert.That(defaultColor.ToRGBString(), Is.EqualTo("rgb(0, 0, 0)"));
        }

        [Test]
        public void TestDefaultColorToRGBAString()
        {
            var defaultColor = new Color();
            Assert.That(defaultColor.ToRGBAString(), Is.EqualTo("rgba(0, 0, 0, 1)"));
        }

        [Test]
        public void TestDefaultColorToCMYKString()
        {
            var defaultColor = new Color();
            Assert.That(defaultColor.ToCMYKString(), Is.EqualTo("cmyk(0%, 0%, 0%, 100%)"));
        }

        [Test]
        public void TestParseIntColor()
        {
            var intColor = new Color(unchecked((int)0xFF0000FF));
            Assert.That(intColor.A, Is.EqualTo(255));
            Assert.That(intColor.R, Is.EqualTo(0));
            Assert.That(intColor.G, Is.EqualTo(0));
            Assert.That(intColor.B, Is.EqualTo(255));
            Assert.That(intColor.C, Is.EqualTo(100));
            Assert.That(intColor.M, Is.EqualTo(100));
            Assert.That(intColor.Y, Is.EqualTo(0.0));
            Assert.That(intColor.K, Is.EqualTo(0.0));
        }

        [Test]
        public void TestParseAlphaWithBaseColor()
        {
            var intColor = new Color(127, System.Drawing.Color.Red);
            Assert.That(intColor.A, Is.EqualTo(127));
            Assert.That(intColor.R, Is.EqualTo(255));
            Assert.That(intColor.G, Is.EqualTo(0));
            Assert.That(intColor.B, Is.EqualTo(0));
            Assert.That(intColor.C, Is.EqualTo(0.0));
            Assert.That(intColor.M, Is.EqualTo(100.0));
            Assert.That(intColor.Y, Is.EqualTo(100.0));
            Assert.That(intColor.K, Is.EqualTo(0.0));
        }

        [Test]
        public void TestParseAlphaWithBaseColor2()
        {
            var intColor = new Color(127, new Color("red"));
            Assert.That(intColor.A, Is.EqualTo(127));
            Assert.That(intColor.R, Is.EqualTo(255));
            Assert.That(intColor.G, Is.EqualTo(0));
            Assert.That(intColor.B, Is.EqualTo(0));
            Assert.That(intColor.C, Is.EqualTo(0.0));
            Assert.That(intColor.M, Is.EqualTo(100.0));
            Assert.That(intColor.Y, Is.EqualTo(100.0));
            Assert.That(intColor.K, Is.EqualTo(0.0));
        }

        [Test]
        public void TestParseHEXColor()
        {
            var hexColor = new Color("#123456");
            Assert.That(hexColor.A, Is.EqualTo(255));
            Assert.That(hexColor.R, Is.EqualTo(18));
            Assert.That(hexColor.G, Is.EqualTo(52));
            Assert.That(hexColor.B, Is.EqualTo(86));
            Assert.That(hexColor.C, Is.EqualTo(79.069767441860478));
            Assert.That(hexColor.M, Is.EqualTo(39.534883720930253));
            Assert.That(hexColor.Y, Is.EqualTo(0.0));
            Assert.That(hexColor.K, Is.EqualTo(66.274509803921561));
        }

        [Test]
        public void TestParseHEXColorToHEXString()
        {
            var hexColor = new Color("#123456");
            Assert.That(hexColor.ToHEXString(), Is.EqualTo("#123456"));
        }

        [Test]
        public void TestParseHEXColorToRGBString()
        {
            var hexColor = new Color("#123456");
            Assert.That(hexColor.ToRGBString(), Is.EqualTo("rgb(18, 52, 86)"));
        }

        [Test]
        public void TestParseHEXColorToRGBAString()
        {
            var hexColor = new Color("#123456");
            Assert.That(hexColor.ToRGBAString(), Is.EqualTo("rgba(18, 52, 86, 1)"));
        }

        [Test]
        public void TestParseHEXColorToCMYKString()
        {
            var hexColor = new Color("#123456");
            Assert.That(hexColor.ToCMYKString(), Is.EqualTo("cmyk(79%, 40%, 0%, 66%)"));
        }

        [Test]
        public void TestParseHEXColorWithAlpha()
        {
            var hexColor = new Color("#aa123456");
            Assert.That(hexColor.A, Is.EqualTo(170));
            Assert.That(hexColor.R, Is.EqualTo(18));
            Assert.That(hexColor.G, Is.EqualTo(52));
            Assert.That(hexColor.B, Is.EqualTo(86));
            Assert.That(hexColor.C, Is.EqualTo(79.069767441860478));
            Assert.That(hexColor.M, Is.EqualTo(39.534883720930253));
            Assert.That(hexColor.Y, Is.EqualTo(0.0));
            Assert.That(hexColor.K, Is.EqualTo(66.274509803921561));
        }

        [Test]
        public void TestParseHEXColorWithAlphaToHEXString()
        {
            var hexColor = new Color("#aa123456");
            Assert.That(hexColor.ToHEXString(), Is.EqualTo("#AA123456"));
        }

        [Test]
        public void TestParseHEXColorWithAlphaToRGBString()
        {
            var hexColor = new Color("#aa123456");
            Assert.That(hexColor.ToRGBString(), Is.EqualTo("rgb(18, 52, 86)"));
        }

        [Test]
        public void TestParseHEXColorWithAlphaToRGBAString()
        {
            var hexColor = new Color("#aa123456");
            Assert.That(hexColor.ToRGBAString(), Is.EqualTo("rgba(18, 52, 86, 0.67)"));
        }

        [Test]
        public void TestParseHEXColorWithAlphaToCMYKString()
        {
            var hexColor = new Color("#aa123456");
            Assert.That(hexColor.ToCMYKString(), Is.EqualTo("cmyk(79%, 40%, 0%, 66%)"));
        }

        [Test]
        public void TestParseRGBColor()
        {
            var rgbColor = new Color("rgb(255, 115, 0)");
            Assert.That(rgbColor.ToHEXString(), Is.EqualTo("#FF7300"));
        }

        [Test]
        public void TestParseRGBAColor()
        {
            var rgbaColor = new Color("rgba(255, 115, 0, 0.5)");
            Assert.That(rgbaColor.ToHEXString(), Is.EqualTo("#7FFF7300"));
        }

        [Test]
        public void TestParseCMYKColor()
        {
            var cmykColor = new Color("cmyk(0%, 55%, 100%, 0%)");
            Assert.That(cmykColor.ToHEXString(), Is.EqualTo("#FF7300"));

            var cmykColor2 = new Color("cmyk(0, 55, 100, 0)");
            Assert.That(cmykColor2.ToHEXString(), Is.EqualTo("#FF7300"));
        }

        [Test]
        public void TestParseAbbreviationColor()
        {
            var whiteColor = new Color("WH");
            var blackColor = new Color("BK");
            var redColor = new Color("RD");
            Assert.That(whiteColor.ToHEXString(), Is.EqualTo("#FFFFFF"));
            Assert.That(blackColor.ToHEXString(), Is.EqualTo("#000000"));
            Assert.That(redColor.ToHEXString(), Is.EqualTo("#FF0000"));
        }

        [Test]
        public void TestParseNamedColor()
        {
            var whiteColor = new Color("white");
            var blackColor = new Color("black");
            var redColor = new Color("red");
            var cyanColor = new Color("cyan");
            var magentaColor = new Color("magenta");
            Assert.That(whiteColor.ToHEXString(), Is.EqualTo("#FFFFFF"));
            Assert.That(blackColor.ToHEXString(), Is.EqualTo("#000000"));
            Assert.That(redColor.ToHEXString(), Is.EqualTo("#FF0000"));
            Assert.That(cyanColor.ToHEXString(), Is.EqualTo("#00FFFF"));
            Assert.That(magentaColor.ToHEXString(), Is.EqualTo("#FF00FF"));
        }

        [Test]
        public void TestColorReset()
        {
            var hexColor = new Color("#aa123456");
            Assert.That(hexColor.A, Is.EqualTo(170));
            Assert.That(hexColor.R, Is.EqualTo(18));
            Assert.That(hexColor.G, Is.EqualTo(52));
            Assert.That(hexColor.B, Is.EqualTo(86));

            hexColor.Reset();

            Assert.That(hexColor.A, Is.EqualTo(255));
            Assert.That(hexColor.R, Is.Zero);
            Assert.That(hexColor.G, Is.Zero);
            Assert.That(hexColor.B, Is.Zero);
        }

        [Test]
        public void TestColorGrayscale()
        {
            var hexColor = new Color("#123456");
            var grayscale = hexColor.Grayscale();
            Assert.That(grayscale.ToHEXString(), Is.EqualTo("#2D2D2D"));
        }

        [Test]
        public void TestColorInvert()
        {
            var hexColor = new Color("#123456");
            var invertedColor = hexColor.Invert();
            Assert.That(invertedColor.ToHEXString(), Is.EqualTo("#EDCBA9"));
        }

        [Test]
        public void TestColorInvertLuminescence()
        {
            var hexColor = new Color("#123456");
            var invertedColor = hexColor.InvertLuminescence();
            Assert.That(invertedColor.ToHEXString(), Is.EqualTo("#A9CBED"));
        }

        [Test]
        public void TestColorColorize()
        {
            var whiteColor = new Color("#FFFFFF");
            var randomColor = new Color("#ABCDEF");
            var colorizedRedColor1 = whiteColor.Colorize("red");
            var colorizedRedColor2 = whiteColor.Colorize(System.Drawing.Color.Red);
            var colorizedRandomColor = randomColor.Colorize("#FEDCBA");
            Assert.That(colorizedRedColor1.ToHEXString(), Is.EqualTo("#FF0000"));
            Assert.That(colorizedRedColor2.ToHEXString(), Is.EqualTo("#FF0000"));
            Assert.That(colorizedRandomColor.ToHEXString(), Is.EqualTo("#AAB1AE"));
        }

        [Test]
        public void TestColorEquals()
        {
            var whiteColor1 = new Color("white");
            var whiteColor2 = new Color("#FFFFFF");
            Assert.That(whiteColor2, Is.EqualTo(whiteColor1));
            Assert.That(whiteColor1.Equals(whiteColor2), Is.True);
            Assert.That(whiteColor1 == whiteColor2, Is.True);
        }

        [Test]
        public void TestColorReferenceEquals()
        {
            var whiteColor1 = new Color("white");
            var whiteColor2 = whiteColor1;
            Assert.That(whiteColor2, Is.EqualTo(whiteColor1));
            Assert.That(whiteColor1.Equals(whiteColor2), Is.True);
            Assert.That(whiteColor1 == whiteColor2, Is.True);
        }

        [Test]
        public void TestColorNotEquals()
        {
            var whiteColor = new Color("white");
            var blackColor = new Color("black");
            Assert.That(blackColor, !Is.EqualTo(whiteColor));
            Assert.That(whiteColor.Equals(blackColor), Is.False);
            Assert.That(whiteColor != blackColor, Is.True);
        }

        [Test]
        public void TestColorNotEqualsWithNull()
        {
            var whiteColor1 = new Color("white");
            Assert.That(whiteColor1, !Is.Null);
            Assert.That(whiteColor1.Equals(null), Is.False);
            Assert.That(whiteColor1 == null, Is.False);
            Assert.That(null == whiteColor1, Is.False);
        }

        [Test]
        public void TestColorNotEqualsWithDifferentType()
        {
            var whiteColor = new Color("white");
            var isBool = true;
            Assert.That(whiteColor, !Is.EqualTo(isBool));
            Assert.That(whiteColor.Equals(isBool), Is.False);
        }

        [Test]
        public void TestColorAddition()
        {
            var redColor = new Color("red");
            var greenColor = new Color("green");
            var addedColor = redColor + greenColor;
            Assert.That(addedColor.ToHEXString(), Is.EqualTo("#FF8000"));
        }

        [Test]
        public void TestColorSubtraction()
        {
            var redColor = new Color("red");
            var greenColor = new Color("#800000");
            var subtractedColor = redColor - greenColor;
            Assert.That(subtractedColor.ToHEXString(), Is.EqualTo("#7F0000"));
        }

        [Test]
        public void TestColorOriginalString()
        {
            var redColor = new Color("red");
            var greenColor = new Color("#800000");
            Assert.That(redColor.OriginalString, Is.EqualTo("red"));
            Assert.That(greenColor.OriginalString, Is.EqualTo("#800000"));
        }

        [Test]
        public void TestInterpolate()
        {
            var color1 = new Color("#FF0000");
            var color2 = new Color("#0000FF");
            var interpolated = color1.Interpolate(color2, 0.5);
            Assert.That(interpolated.ToHEXString(), Is.EqualTo("#800080"));
        }

        [Test]
        public void TestInterpolateHSV()
        {
            var color1 = new Color("#FF0000");
            var color2 = new Color("#0000FF");
            var interpolated = color1.InterpolateHSV(color2, 0.5);
            Assert.That(interpolated.ToHEXString(), Is.EqualTo("#00FF00"));
        }

        [Test]
        public void TestFromARGB()
        {
            var color = Color.FromArgb(1000);
            Assert.That(color.ToHEXString(), Is.EqualTo("#000003E8"));
        }

        [Test]
        public void TestFromARGBWithBaseColor()
        {
            var color1 = Color.FromArgb(100, System.Drawing.Color.AliceBlue);
            Assert.That(color1.ToHEXString(), Is.EqualTo("#64F0F8FF"));

            var color2 = Color.FromArgb(100, Color.AliceBlue);
            Assert.That(color2.ToHEXString(), Is.EqualTo("#64F0F8FF"));
        }

        [Test]
        public void TestFromARGBWithARGB()
        {
            var color1 = Color.FromArgb(255, 0, 0);
            Assert.That(color1.ToHEXString(), Is.EqualTo("#FF0000"));

            var color2 = Color.FromArgb(100, 255, 0, 0);
            Assert.That(color2.ToHEXString(), Is.EqualTo("#64FF0000"));
        }

        [Test]
        public void TestFromName()
        {
            var color1 = Color.FromName("red");
            Assert.That(color1.ToHEXString(), Is.EqualTo("#FF0000"));
        }
    }
}
