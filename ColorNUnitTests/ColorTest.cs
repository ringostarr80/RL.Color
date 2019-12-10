using System;

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
			Assert.AreEqual(255, defaultColor.A);
            Assert.AreEqual(0, defaultColor.R);
            Assert.AreEqual(0, defaultColor.G);
            Assert.AreEqual(0, defaultColor.B);
            Assert.AreEqual(0.0, defaultColor.C);
            Assert.AreEqual(0.0, defaultColor.M);
            Assert.AreEqual(0.0, defaultColor.Y);
            Assert.AreEqual(100.0, defaultColor.K);
		}

        [Test]
        public void TestDefaultColorToHEXString()
        {
			var defaultColor = new Color();
			Assert.AreEqual("#000000", defaultColor.ToHEXString());
        }

        [Test]
        public void TestDefaultColorToRGBString()
        {
			var defaultColor = new Color();
			Assert.AreEqual("rgb(0, 0, 0)", defaultColor.ToRGBString());
        }

        [Test]
        public void TestDefaultColorToRGBAString()
        {
			var defaultColor = new Color();
			Assert.AreEqual("rgba(0, 0, 0, 1)", defaultColor.ToRGBAString());
        }

        [Test]
        public void TestDefaultColorToCMYKString()
        {
			var defaultColor = new Color();
			Assert.AreEqual("cmyk(0%, 0%, 0%, 100%)", defaultColor.ToCMYKString());
        }

        [Test]
        public void TestParseIntColor()
        {
			var intColor = new Color(unchecked((int)0xFF0000FF));
			Assert.AreEqual(255, intColor.A);
            Assert.AreEqual(0, intColor.R);
            Assert.AreEqual(0, intColor.G);
            Assert.AreEqual(255, intColor.B);
            Assert.AreEqual(100.0, intColor.C);
            Assert.AreEqual(100.0, intColor.M);
            Assert.AreEqual(0.0, intColor.Y);
            Assert.AreEqual(0.0, intColor.K);
        }

        [Test]
        public void TestParseAlphaWithBaseColor()
        {
			var intColor = new Color(127, System.Drawing.Color.Red);
			Assert.AreEqual(127, intColor.A);
            Assert.AreEqual(255, intColor.R);
            Assert.AreEqual(0, intColor.G);
            Assert.AreEqual(0, intColor.B);
            Assert.AreEqual(0.0, intColor.C);
            Assert.AreEqual(100.0, intColor.M);
            Assert.AreEqual(100.0, intColor.Y);
            Assert.AreEqual(0.0, intColor.K);
        }

        [Test]
        public void TestParseAlphaWithBaseColor2()
        {
			var intColor = new Color(127, new Color("red"));
			Assert.AreEqual(127, intColor.A);
            Assert.AreEqual(255, intColor.R);
            Assert.AreEqual(0, intColor.G);
            Assert.AreEqual(0, intColor.B);
            Assert.AreEqual(0.0, intColor.C);
            Assert.AreEqual(100.0, intColor.M);
            Assert.AreEqual(100.0, intColor.Y);
            Assert.AreEqual(0.0, intColor.K);
        }

        [Test]
        public void TestParseHEXColor()
        {
			var hexColor = new Color("#123456");
			Assert.AreEqual(255, hexColor.A);
            Assert.AreEqual(18, hexColor.R);
            Assert.AreEqual(52, hexColor.G);
            Assert.AreEqual(86, hexColor.B);
            Assert.AreEqual(79.069767441860478, hexColor.C);
            Assert.AreEqual(39.534883720930253, hexColor.M);
            Assert.AreEqual(0.0, hexColor.Y);
            Assert.AreEqual(66.274509803921561, hexColor.K);
        }

        [Test]
        public void TestParseHEXColorToHEXString()
        {
			var hexColor = new Color("#123456");
			Assert.AreEqual("#123456", hexColor.ToHEXString());
        }

        [Test]
        public void TestParseHEXColorToRGBString()
        {
			var hexColor = new Color("#123456");
			Assert.AreEqual("rgb(18, 52, 86)", hexColor.ToRGBString());
        }

        [Test]
        public void TestParseHEXColorToRGBAString()
        {
			var hexColor = new Color("#123456");
			Assert.AreEqual("rgba(18, 52, 86, 1)", hexColor.ToRGBAString());
        }

        [Test]
        public void TestParseHEXColorToCMYKString()
        {
			var hexColor = new Color("#123456");
			Assert.AreEqual("cmyk(79%, 40%, 0%, 66%)", hexColor.ToCMYKString());
        }

        [Test]
        public void TestParseHEXColorWithAlpha()
        {
			var hexColor = new Color("#aa123456");
			Assert.AreEqual(170, hexColor.A);
            Assert.AreEqual(18, hexColor.R);
            Assert.AreEqual(52, hexColor.G);
            Assert.AreEqual(86, hexColor.B);
            Assert.AreEqual(79.069767441860478, hexColor.C);
            Assert.AreEqual(39.534883720930253, hexColor.M);
            Assert.AreEqual(0.0, hexColor.Y);
            Assert.AreEqual(66.274509803921561, hexColor.K);
        }

        [Test]
        public void TestParseHEXColorWithAlphaToHEXString()
        {
			var hexColor = new Color("#aa123456");
			Assert.AreEqual("#AA123456", hexColor.ToHEXString());
        }

        [Test]
        public void TestParseHEXColorWithAlphaToRGBString()
        {
			var hexColor = new Color("#aa123456");
			Assert.AreEqual("rgb(18, 52, 86)", hexColor.ToRGBString());
        }

        [Test]
        public void TestParseHEXColorWithAlphaToRGBAString()
        {
			var hexColor = new Color("#aa123456");
			Assert.AreEqual("rgba(18, 52, 86, 0.67)", hexColor.ToRGBAString());
        }

        [Test]
        public void TestParseHEXColorWithAlphaToCMYKString()
        {
			var hexColor = new Color("#aa123456");
			Assert.AreEqual("cmyk(79%, 40%, 0%, 66%)", hexColor.ToCMYKString());
        }

        [Test]
        public void TestParseRGBColor()
        {
			var rgbColor = new Color("rgb(255, 115, 0)");
			Assert.AreEqual("#FF7300", rgbColor.ToHEXString());
        }

        [Test]
        public void TestParseRGBAColor()
        {
			var rgbaColor = new Color("rgba(255, 115, 0, 0.5)");
			Assert.AreEqual("#7FFF7300", rgbaColor.ToHEXString());
        }

        [Test]
        public void TestParseCMYKColor()
        {
			var cmykColor = new Color("cmyk(0%, 55%, 100%, 0%)");
			Assert.AreEqual("#FF7300", cmykColor.ToHEXString());

            var cmykColor2 = new Color("cmyk(0, 55, 100, 0)");
			Assert.AreEqual("#FF7300", cmykColor2.ToHEXString());
        }

        [Test]
        public void TestParseAbbreviationColor()
        {
			var whiteColor = new Color("WH");
            var blackColor = new Color("BK");
            var redColor = new Color("RD");
			Assert.AreEqual("#FFFFFF", whiteColor.ToHEXString());
            Assert.AreEqual("#000000", blackColor.ToHEXString());
            Assert.AreEqual("#FF0000", redColor.ToHEXString());
        }

        [Test]
        public void TestParseNamedColor()
        {
			var whiteColor = new Color("white");
            var blackColor = new Color("black");
            var redColor = new Color("red");
            var cyanColor = new Color("cyan");
            var magentaColor = new Color("magenta");
			Assert.AreEqual("#FFFFFF", whiteColor.ToHEXString());
            Assert.AreEqual("#000000", blackColor.ToHEXString());
            Assert.AreEqual("#FF0000", redColor.ToHEXString());
            Assert.AreEqual("#00FFFF", cyanColor.ToHEXString());
            Assert.AreEqual("#FF00FF", magentaColor.ToHEXString());
        }

		[Test]
		public void TestColorReset()
        {
            var hexColor = new Color("#aa123456");
			Assert.AreEqual(170, hexColor.A);
            Assert.AreEqual(18, hexColor.R);
            Assert.AreEqual(52, hexColor.G);
            Assert.AreEqual(86, hexColor.B);

			hexColor.Reset();

            Assert.AreEqual(255, hexColor.A);
            Assert.AreEqual(0, hexColor.R);
            Assert.AreEqual(0, hexColor.G);
            Assert.AreEqual(0, hexColor.B);
		}

        [Test]
        public void TestColorGrayscale()
        {
            var hexColor = new Color("#123456");
			var grayscale = hexColor.Grayscale();
            Assert.AreEqual("#2D2D2D", grayscale.ToHEXString());
		}

        [Test]
        public void TestColorInvert()
        {
            var hexColor = new Color("#123456");
			var invertedColor = hexColor.Invert();
            Assert.AreEqual("#EDCBA9", invertedColor.ToHEXString());
		}

        [Test]
        public void TestColorInvertLuminescence()
        {
            var hexColor = new Color("#123456");
			var invertedColor = hexColor.InvertLuminescence();
            Assert.AreEqual("#A9CBED", invertedColor.ToHEXString());
		}

        [Test]
        public void TestColorColorize()
        {
            var whiteColor = new Color("#FFFFFF");
			var randomColor = new Color("#ABCDEF");
			var colorizedRedColor = whiteColor.Colorize("red");
			var colorizedRandomColor = randomColor.Colorize("#FEDCBA");
			Assert.AreEqual("#FF0000", colorizedRedColor.ToHEXString());
            Assert.AreEqual("#AAB1AE", colorizedRandomColor.ToHEXString());
		}

        [Test]
        public void TestColorEquals()
        {
			var whiteColor1 = new Color("white");
			var whiteColor2 = new Color("#FFFFFF");
			Assert.AreEqual(whiteColor1, whiteColor2);
			Assert.IsTrue(whiteColor1.Equals(whiteColor2));
            Assert.IsTrue(whiteColor1 == whiteColor2);
		}

        [Test]
        public void TestColorNotEquals()
        {
			var whiteColor = new Color("white");
			var blackColor = new Color("black");
			Assert.AreNotEqual(whiteColor, blackColor);
			Assert.IsFalse(whiteColor.Equals(blackColor));
            Assert.IsTrue(whiteColor != blackColor);
		}

        [Test]
        public void TestColorAddition()
        {
			var redColor = new Color("red");
            var greenColor = new Color("green");
			var addedColor = redColor + greenColor;
			Assert.AreEqual("#FF8000", addedColor.ToHEXString());
		}

        [Test]
        public void TestColorSubtraction()
        {
			var redColor = new Color("red");
            var greenColor = new Color("#800000");
			var subtractedColor = redColor - greenColor;
			Assert.AreEqual("#7F0000", subtractedColor.ToHEXString());
		}

        [Test]
        public void TestColorOriginalString()
        {
            var redColor = new Color("red");
            var greenColor = new Color("#800000");
            Assert.AreEqual("red", redColor.OriginalString);
            Assert.AreEqual("#800000", greenColor.OriginalString);
        }

        [Test]
        public void TestInterpolate()
        {
            var color1 = new Color("#FF0000");
            var color2 = new Color("#0000FF");
            var interpolated = color1.Interpolate(color2, 0.5);
            Assert.AreEqual("#800080", interpolated.ToHEXString());
        }

        [Test]
        public void TestInterpolateHSV()
        {
            var color1 = new Color("#FF0000");
            var color2 = new Color("#0000FF");
            var interpolated = color1.InterpolateHSV(color2, 0.5);
            Assert.AreEqual("#00FF00", interpolated.ToHEXString());
        }
	}
}
