using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace RL
{
    /// <summary>
    /// A replacement class for the System.Drawing.Color structure.
    /// </summary>
    public class Color
    {
        private static readonly Dictionary<string, byte[]> abbreviations = new() {
            {"AQ", new byte[3] {0x00, 0xFF, 0xFF}},
            {"BK", new byte[3] {0x00, 0x00, 0x00}},
            {"BL", new byte[3] {0x00, 0x00, 0xFF}},
            {"BR", new byte[3] {0xA5, 0x2A, 0x2A}},
            {"FU", new byte[3] {0xFF, 0x00, 0xFF}},
            {"GN", new byte[3] {0x00, 0x80, 0x00}},
            {"GR", new byte[3] {0x80, 0x80, 0x80}},
            {"LI", new byte[3] {0x00, 0xFF, 0x00}},
            {"MR", new byte[3] {0x80, 0x00, 0x00}},
            {"NA", new byte[3] {0x00, 0x00, 0x80}},
            {"OL", new byte[3] {0x80, 0x80, 0x00}},
            {"OR", new byte[3] {0xFF, 0xA5, 0x00}},
            {"PK", new byte[3] {0xFF, 0xC0, 0xCB}},
            {"PU", new byte[3] {0x80, 0x00, 0x80}},
            {"RD", new byte[3] {0xFF, 0x00, 0x00}},
            {"SI", new byte[3] {0xC0, 0xC0, 0xC0}},
            {"TE", new byte[3] {0x00, 0x80, 0x80}},
            {"TN", new byte[3] {0xD2, 0xB4, 0x8C}},
            {"VI", new byte[3] {0xEE, 0x82, 0xEE}},
            {"WH", new byte[3] {0xFF, 0xFF, 0xFF}},
            {"YE", new byte[3] {0xFF, 0xFF, 0x00}}
        };
        private static readonly Dictionary<string, string> knownColors = new() {
            {"aliceblue", "#F0F8FF"},
            {"antiqueqhite", "#FAEBD7"},
            {"aqua", "#00FFFF"},
            {"aquamarine", "#7FFFD4"},
            {"azure", "#F0FFFF"},
            {"beige", "#F5F5DC"},
            {"bisque", "#FFE4C4"},
            {"black", "#000000"},
            {"blanchedalmond", "#FFEBCD"},
            {"blue", "#0000FF"},
            {"blueviolet", "#8A2BE2"},
            {"brown", "#A52A2A"},
            {"burlywood", "#DEB887"},
            {"cadetblue", "#5F9EA0"},
            {"chartreuse", "#7FFF00"},
            {"chocolate", "#D2691E"},
            {"coral", "#FF7F50"},
            {"cornflowerblue", "#6495ED"},
            {"cornsilk", "#FFF8DC"},
            {"crimson", "#DC143C"},
            {"cyan", "#00FFFF"},
            {"darkblue", "#00008B"},
            {"darkcyan", "#008B8B"},
            {"darkgoldenrod", "#B8860B"},
            {"darkgray", "#A9A9A9"},
            {"darkgrey", "#A9A9A9"},
            {"darkgreen", "#006400"},
            {"darkkhaki", "#BDB76B"},
            {"darkmagenta", "#8B008B"},
            {"darkolivegreen", "#556B2F"},
            {"darkorange", "#FF8C00"},
            {"darkorchid", "#9932CC"},
            {"darkred", "#8B0000"},
            {"darksalmon", "#E9967A"},
            {"darkseagreen", "#8FBC8B"},
            {"darkslateblue", "#483D8B"},
            {"darkslategray", "#2F4F4F"},
            {"darkslategrey", "#2F4F4F"},
            {"darkturquoise", "#00CED1"},
            {"darkviolet", "#9400D3"},
            {"deeppink", "#FF1493"},
            {"deepskyblue", "#00BFFF"},
            {"dimgray", "#696969"},
            {"dimgrey", "#696969"},
            {"dodgerblue", "#1E90FF"},
            {"firebrick", "#B22222"},
            {"floralwhite", "#FFFAF0"},
            {"forestgreen", "#228B22"},
            {"fuchsia", "#FF00FF"},
            {"gainsboro", "#DCDCDC"},
            {"ghostwhite", "#F8F8FF"},
            {"gold", "#FFD700"},
            {"goldenrod", "#DAA520"},
            {"gray", "#808080"},
            {"grey", "#808080"},
            {"green", "#008000"},
            {"greenyellow", "#ADFF2F"},
            {"honeydew", "#F0FFF0"},
            {"hotpink", "#FF69B4"},
            {"indianred", "#CD5C5C"},
            {"indigo", "#4B0082"},
            {"ivory", "#FFFFF0"},
            {"khaki", "#F0E68C"},
            {"lavender", "#E6E6FA"},
            {"lavenderblush", "#FFF0F5"},
            {"lawngreen", "#7CFC00"},
            {"lemonchiffon", "#FFFACD"},
            {"lightblue", "#ADD8E6"},
            {"lightcoral", "#F08080"},
            {"lightcyan", "#E0FFFF"},
            {"lightgoldenrodyellow", "#FAFAD2"},
            {"lightgray", "#D3D3D3"},
            {"lightgrey", "#D3D3D3"},
            {"lightgreen", "#90EE90"},
            {"lightpink", "#FFB6C1"},
            {"lightsalmon", "#FFA07A"},
            {"lightseagreen", "#20B2AA"},
            {"lightskyblue", "#87CEFA"},
            {"lightslategray", "#778899"},
            {"lightslategrey", "#778899"},
            {"lightsteelblue", "#B0C4DE"},
            {"lightyellow", "#FFFFE0"},
            {"lime", "#00FF00"},
            {"limegreen", "#32CD32"},
            {"linen", "#FAF0E6"},
            {"magenta", "#FF00FF"},
            {"maroon", "#800000"},
            {"mediumaquamarine", "#66CDAA"},
            {"mediumblue", "#0000CD"},
            {"mediumorchid", "#BA55D3"},
            {"mediumpurple", "#9370DB"},
            {"mediumseagreen", "#3CB371"},
            {"mediumslateblue", "#7B68EE"},
            {"mediumspringgreen", "#00FA9A"},
            {"mediumturquoise", "#48D1CC"},
            {"mediumvioletred", "#C71585"},
            {"midnightblue", "#191970"},
            {"mintcream", "#F5FFFA"},
            {"mistyrose", "#FFE4E1"},
            {"moccasin", "#FFE4B5"},
            {"navajowhite", "#FFDEAD"},
            {"navy", "#000080"},
            {"oldlace", "#FDF5E6"},
            {"olive", "#808000"},
            {"olivedrab", "#6B8E23"},
            {"orange", "#FFA500"},
            {"orangered", "#FF4500"},
            {"orchid", "#DA70D6"},
            {"palegoldenrod", "#EEE8AA"},
            {"palegreen", "#98FB98"},
            {"paleturquoise", "#AFEEEE"},
            {"palevioletred", "#DB7093"},
            {"papayawhip", "#FFEFD5"},
            {"peachpuff", "#FFDAB9"},
            {"peru", "#CD853F"},
            {"pink", "#FFC0CB"},
            {"plum", "#DDA0DD"},
            {"powderblue", "#B0E0E6"},
            {"purple", "#800080"},
            {"red", "#FF0000"},
            {"rosybrown", "#BC8F8F"},
            {"royalblue", "#4169E1"},
            {"saddlebrown", "#8B4513"},
            {"salmon", "#FA8072"},
            {"sandybrown", "#F4A460"},
            {"seagreen", "#2E8B57"},
            {"seashell", "#FFF5EE"},
            {"sienna", "#A0522D"},
            {"silver", "#C0C0C0"},
            {"skyblue", "#87CEEB"},
            {"slateblue", "#6A5ACD"},
            {"slategray", "#708090"},
            {"slategrey", "#708090"},
            {"snow", "#FFFAFA"},
            {"springgreen", "#00FF7F"},
            {"steelblue", "#4682B4"},
            {"tan", "#D2B48C"},
            {"teal", "#008080"},
            {"thistle", "#D8BFD8"},
            {"tomato", "#FF6347"},
            {"transparent", "#FFFFFFFF"},
            {"turquoise", "#40E0D0"},
            {"violet", "#EE82EE"},
            {"wheat", "#F5DEB3"},
            {"white", "#FFFFFF"},
            {"whitesmoke", "#F5F5F5"},
            {"yellow", "#FFFF00"},
            {"yellowgreen", "#9ACD32"}
        };

        private string originalString = string.Empty;

        /// <summary>
        /// Alpha
        /// </summary>
        /// <value>The alpha value of this Color-instance.</value>
        public byte A { get; set; } = 255;
        /// <summary>
        /// Red
        /// </summary>
        /// <value>The red value of this Color-instance.</value>
        public byte R { get; set; }
        /// <summary>
        /// Green
        /// </summary>
        /// <value>The green value of this Color-instance.</value>
        public byte G { get; set; }
        /// <summary>
        /// Blue
        /// </summary>
        /// <value>The blue value of this Color-instance.</value>
        public byte B { get; set; }
        /// <summary>
        /// Original String
        /// </summary>
        /// <value>The orginal string, that was given by the new-constructor.</value>
        public string OriginalString { get { return this.originalString; } }
        /// <summary>
        /// Cyan
        /// </summary>
        /// <value>The cyan value (in percent) of this Color-instance.</value>
        public double C {
            get {
                var r = (int)this.R / 255.0;
                var g = (int)this.G / 255.0;
                var b = (int)this.B / 255.0;
                var black = 1.0 - Math.Max(Math.Max(r, g), b);
                
                var cyan = (1.0 - r - black) / (1.0 - black) * 100.0;
                if (double.NaN.Equals(cyan)) {
                    cyan = 0;
                }
                return cyan;
            }
        }
        /// <summary>
        /// Magenta
        /// </summary>
        /// <value>The magenta value (in percent) of this Color-instance.</value>
        public double M {
            get {
                var r = (int)this.R / 255.0;
                var g = (int)this.G / 255.0;
                var b = (int)this.B / 255.0;
                var black = 1.0 - Math.Max(Math.Max(r, g), b);
                
                var magenta = (1.0 - g - black) / (1.0 - black) * 100.0;
                if (double.NaN.Equals(magenta)) {
                    magenta = 0;
                }
                return magenta;
            }
        }
        /// <summary>
        /// Yellow
        /// </summary>
        /// <value>The yellow value (in percent) of this Color-instance.</value>
        public double Y {
            get {
                var r = (int)this.R / 255.0;
                var g = (int)this.G / 255.0;
                var b = (int)this.B / 255.0;
                var black = 1.0 - Math.Max(Math.Max(r, g), b);
                
                var yellow = (1.0 - b - black) / (1.0 - black) * 100.0;
                if (double.NaN.Equals(yellow)) {
                    yellow = 0;
                }
                return yellow;
            }
        }
        /// <summary>
        /// Key (Black)
        /// </summary>
        /// <value>The key value (in percent) of this Color-instance.</value>
        public double K {
            get {
                var r = (int)this.R / 255.0;
                var g = (int)this.G / 255.0;
                var b = (int)this.B / 255.0;
                return (1.0 - Math.Max(Math.Max(r, g), b)) * 100.0;
            }
        }

        public static Color AliceBlue { get { return new Color(System.Drawing.Color.AliceBlue); } }
        public static Color AntiqueWhite { get { return new Color(System.Drawing.Color.AntiqueWhite); } }
        public static Color Aqua { get { return new Color(System.Drawing.Color.Aqua); } }
        public static Color Aquamarine { get { return new Color(System.Drawing.Color.Aquamarine); } }
        public static Color Azure { get { return new Color(System.Drawing.Color.Azure); } }
        public static Color Beige { get { return new Color(System.Drawing.Color.Beige); } }
        public static Color Bisque { get { return new Color(System.Drawing.Color.Bisque); } }
        public static Color Black { get { return new Color(System.Drawing.Color.Black); } }
        public static Color BlanchedAlmond { get { return new Color(System.Drawing.Color.BlanchedAlmond); } }
        public static Color Blue { get { return new Color(System.Drawing.Color.Blue); } }
        public static Color BlueViolet { get { return new Color(System.Drawing.Color.BlueViolet); } }
        public static Color Brown { get { return new Color(System.Drawing.Color.Brown); } }
        public static Color BurlyWood { get { return new Color(System.Drawing.Color.BurlyWood); } }
        public static Color CadetBlue { get { return new Color(System.Drawing.Color.CadetBlue); } }
        public static Color Chartreuse { get { return new Color(System.Drawing.Color.Chartreuse); } }
        public static Color Chocolate { get { return new Color(System.Drawing.Color.Chocolate); } }
        public static Color Coral { get { return new Color(System.Drawing.Color.Coral); } }
        public static Color CornflowerBlue { get { return new Color(System.Drawing.Color.CornflowerBlue); } }
        public static Color Cornsilk { get { return new Color(System.Drawing.Color.Cornsilk); } }
        public static Color Crimson { get { return new Color(System.Drawing.Color.Crimson); } }
        public static Color Cyan { get { return new Color(System.Drawing.Color.Cyan); } }
        public static Color DarkBlue { get { return new Color(System.Drawing.Color.DarkBlue); } }
        public static Color DarkCyan { get { return new Color(System.Drawing.Color.DarkCyan); } }
        public static Color DarkGoldenrod { get { return new Color(System.Drawing.Color.DarkGoldenrod); } }
        public static Color DarkGray { get { return new Color(System.Drawing.Color.DarkGray); } }
        public static Color DarkGreen { get { return new Color(System.Drawing.Color.DarkGreen); } }
        public static Color DarkKhaki { get { return new Color(System.Drawing.Color.DarkKhaki); } }
        public static Color DarkMagenta { get { return new Color(System.Drawing.Color.DarkMagenta); } }
        public static Color DarkOliveGreen { get { return new Color(System.Drawing.Color.DarkOliveGreen); } }
        public static Color DarkOrange { get { return new Color(System.Drawing.Color.DarkOrange); } }
        public static Color DarkOrchid { get { return new Color(System.Drawing.Color.DarkOrchid); } }
        public static Color DarkRed { get { return new Color(System.Drawing.Color.DarkRed); } }
        public static Color DarkSalmon { get { return new Color(System.Drawing.Color.DarkSalmon); } }
        public static Color DarkSeaGreen { get { return new Color(System.Drawing.Color.DarkSeaGreen); } }
        public static Color DarkSlateBlue { get { return new Color(System.Drawing.Color.DarkSlateBlue); } }
        public static Color DarkSlateGray { get { return new Color(System.Drawing.Color.DarkSlateGray); } }
        public static Color DarkTurquoise { get { return new Color(System.Drawing.Color.DarkTurquoise); } }
        public static Color DarkViolet { get { return new Color(System.Drawing.Color.DarkViolet); } }
        public static Color DeepPink { get { return new Color(System.Drawing.Color.DeepPink); } }
        public static Color DeepSkyBlue { get { return new Color(System.Drawing.Color.DeepSkyBlue); } }
        public static Color DimGray { get { return new Color(System.Drawing.Color.DimGray); } }
        public static Color DodgerBlue { get { return new Color(System.Drawing.Color.DodgerBlue); } }
        public static Color Empty { get { return new Color(System.Drawing.Color.Empty); } }
        public static Color Firebrick { get { return new Color(System.Drawing.Color.Firebrick); } }
        public static Color FloralWhite { get { return new Color(System.Drawing.Color.FloralWhite); } }
        public static Color ForestGreen { get { return new Color(System.Drawing.Color.ForestGreen); } }
        public static Color Fuchsia { get { return new Color(System.Drawing.Color.Fuchsia); } }
        public static Color Gainsboro { get { return new Color(System.Drawing.Color.Gainsboro); } }
        public static Color GhostWhite { get { return new Color(System.Drawing.Color.GhostWhite); } }
        public static Color Gold { get { return new Color(System.Drawing.Color.Gold); } }
        public static Color Goldenrod { get { return new Color(System.Drawing.Color.Goldenrod); } }
        public static Color Gray { get { return new Color(System.Drawing.Color.Gray); } }
        public static Color Green { get { return new Color(System.Drawing.Color.Green); } }
        public static Color GreenYellow { get { return new Color(System.Drawing.Color.GreenYellow); } }
        public static Color Honeydew { get { return new Color(System.Drawing.Color.Honeydew); } }
        public static Color HotPink { get { return new Color(System.Drawing.Color.HotPink); } }
        public static Color IndianRed { get { return new Color(System.Drawing.Color.IndianRed); } }
        public static Color Indigo { get { return new Color(System.Drawing.Color.Indigo); } }
        public static Color Ivory { get { return new Color(System.Drawing.Color.Ivory); } }
        public static Color Khaki { get { return new Color(System.Drawing.Color.Khaki); } }
        public static Color Lavender { get { return new Color(System.Drawing.Color.Lavender); } }
        public static Color LavenderBlush { get { return new Color(System.Drawing.Color.LavenderBlush); } }
        public static Color LawnGreen { get { return new Color(System.Drawing.Color.LawnGreen); } }
        public static Color LemonChiffon { get { return new Color(System.Drawing.Color.LemonChiffon); } }
        public static Color LightBlue { get { return new Color(System.Drawing.Color.LightBlue); } }
        public static Color LightCoral { get { return new Color(System.Drawing.Color.LightCoral); } }
        public static Color LightCyan { get { return new Color(System.Drawing.Color.LightCyan); } }
        public static Color LightGoldenrodYellow { get { return new Color(System.Drawing.Color.LightGoldenrodYellow); } }
        public static Color LightGray { get { return new Color(System.Drawing.Color.LightGray); } }
        public static Color LightGreen { get { return new Color(System.Drawing.Color.LightGreen); } }
        public static Color LightPink { get { return new Color(System.Drawing.Color.LightPink); } }
        public static Color LightSalmon { get { return new Color(System.Drawing.Color.LightSalmon); } }
        public static Color LightSeaGreen { get { return new Color(System.Drawing.Color.LightSeaGreen); } }
        public static Color LightSkyBlue { get { return new Color(System.Drawing.Color.LightSkyBlue); } }
        public static Color LightSlateGray { get { return new Color(System.Drawing.Color.LightSlateGray); } }
        public static Color LightSteelBlue { get { return new Color(System.Drawing.Color.LightSteelBlue); } }
        public static Color LightYellow { get { return new Color(System.Drawing.Color.LightYellow); } }
        public static Color Lime { get { return new Color(System.Drawing.Color.Lime); } }
        public static Color LimeGreen { get { return new Color(System.Drawing.Color.LimeGreen); } }
        public static Color Linen { get { return new Color(System.Drawing.Color.Linen); } }
        public static Color Magenta { get { return new Color(System.Drawing.Color.Magenta); } }
        public static Color Maroon { get { return new Color(System.Drawing.Color.Maroon); } }
        public static Color MediumAquamarine { get { return new Color(System.Drawing.Color.MediumAquamarine); } }
        public static Color MediumBlue { get { return new Color(System.Drawing.Color.MediumBlue); } }
        public static Color MediumOrchid { get { return new Color(System.Drawing.Color.MediumOrchid); } }
        public static Color MediumPurple { get { return new Color(System.Drawing.Color.MediumPurple); } }
        public static Color MediumSeaGreen { get { return new Color(System.Drawing.Color.MediumSeaGreen); } }
        public static Color MediumSlateBlue { get { return new Color(System.Drawing.Color.MediumSlateBlue); } }
        public static Color MediumSpringGreen { get { return new Color(System.Drawing.Color.MediumSpringGreen); } }
        public static Color MediumTurquoise { get { return new Color(System.Drawing.Color.MediumTurquoise); } }
        public static Color MediumVioletRed { get { return new Color(System.Drawing.Color.MediumVioletRed); } }
        public static Color MidnightBlue { get { return new Color(System.Drawing.Color.MidnightBlue); } }
        public static Color MintCream { get { return new Color(System.Drawing.Color.MintCream); } }
        public static Color MistyRose { get { return new Color(System.Drawing.Color.MistyRose); } }
        public static Color Moccasin { get { return new Color(System.Drawing.Color.Moccasin); } }
        public static Color NavajoWhite { get { return new Color(System.Drawing.Color.NavajoWhite); } }
        public static Color Navy { get { return new Color(System.Drawing.Color.Navy); } }
        public static Color OldLace { get { return new Color(System.Drawing.Color.OldLace); } }
        public static Color Olive { get { return new Color(System.Drawing.Color.Olive); } }
        public static Color OliveDrab { get { return new Color(System.Drawing.Color.OliveDrab); } }
        public static Color Orange { get { return new Color(System.Drawing.Color.Orange); } }
        public static Color OrangeRed { get { return new Color(System.Drawing.Color.OrangeRed); } }
        public static Color Orchid { get { return new Color(System.Drawing.Color.Orchid); } }
        public static Color PaleGoldenrod { get { return new Color(System.Drawing.Color.PaleGoldenrod); } }
        public static Color PaleGreen { get { return new Color(System.Drawing.Color.PaleGreen); } }
        public static Color PaleTurquoise { get { return new Color(System.Drawing.Color.PaleTurquoise); } }
        public static Color PaleVioletRed { get { return new Color(System.Drawing.Color.PaleVioletRed); } }
        public static Color PapayaWhip { get { return new Color(System.Drawing.Color.PapayaWhip); } }
        public static Color PeachPuff { get { return new Color(System.Drawing.Color.PeachPuff); } }
        public static Color Peru { get { return new Color(System.Drawing.Color.Peru); } }
        public static Color Pink { get { return new Color(System.Drawing.Color.Pink); } }
        public static Color Plum { get { return new Color(System.Drawing.Color.Plum); } }
        public static Color PowderBlue { get { return new Color(System.Drawing.Color.PowderBlue); } }
        public static Color Purple { get { return new Color(System.Drawing.Color.Purple); } }
        public static Color Red { get { return new Color(System.Drawing.Color.Red); } }
        public static Color RosyBrown { get { return new Color(System.Drawing.Color.RosyBrown); } }
        public static Color RoyalBlue { get { return new Color(System.Drawing.Color.RoyalBlue); } }
        public static Color SaddleBrown { get { return new Color(System.Drawing.Color.SaddleBrown); } }
        public static Color Salmon { get { return new Color(System.Drawing.Color.Salmon); } }
        public static Color SandyBrown { get { return new Color(System.Drawing.Color.SandyBrown); } }
        public static Color SeaGreen { get { return new Color(System.Drawing.Color.SeaGreen); } }
        public static Color SeaShell { get { return new Color(System.Drawing.Color.SeaShell); } }
        public static Color Sienna { get { return new Color(System.Drawing.Color.Sienna); } }
        public static Color Silver { get { return new Color(System.Drawing.Color.Silver); } }
        public static Color SkyBlue { get { return new Color(System.Drawing.Color.SkyBlue); } }
        public static Color SlateBlue { get { return new Color(System.Drawing.Color.SlateBlue); } }
        public static Color SlateGray { get { return new Color(System.Drawing.Color.SlateGray); } }
        public static Color Snow { get { return new Color(System.Drawing.Color.Snow); } }
        public static Color SpringGreen { get { return new Color(System.Drawing.Color.SpringGreen); } }
        public static Color SteelBlue { get { return new Color(System.Drawing.Color.SteelBlue); } }
        public static Color Tan { get { return new Color(System.Drawing.Color.Tan); } }
        public static Color Teal { get { return new Color(System.Drawing.Color.Teal); } }
        public static Color Thistle { get { return new Color(System.Drawing.Color.Thistle); } }
        public static Color Tomato { get { return new Color(System.Drawing.Color.Tomato); } }
        public static Color Transparent { get { return new Color(System.Drawing.Color.Transparent); } }
        public static Color Turquoise { get { return new Color(System.Drawing.Color.Turquoise); } }
        public static Color Violet { get { return new Color(System.Drawing.Color.Violet); } }
        public static Color Wheat { get { return new Color(System.Drawing.Color.Wheat); } }
        public static Color White { get { return new Color(System.Drawing.Color.White); } }
        public static Color WhiteSmoke { get { return new Color(System.Drawing.Color.WhiteSmoke); } }
        public static Color Yellow { get { return new Color(System.Drawing.Color.Yellow); } }
        public static Color YellowGreen { get { return new Color(System.Drawing.Color.YellowGreen); } }

        /// <summary>
        /// The default-constructor. The default color is black.
        /// </summary>
        public Color()
        {
            
        }

        /// <summary>
        /// A constructor.
        /// </summary>
        /// <param name="color">A color to use.</param>
        public Color(System.Drawing.Color color)
        {
            this.A = color.A;
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
        }

        /// <summary>
        /// A cosntructor.
        /// </summary>
        /// <param name="argb">An 0xAARRGGBB-color as integer.</param>
        public Color(int argb)
        {
            var color = System.Drawing.Color.FromArgb(argb);
            this.A = color.A;
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
        }

        /// <summary>
        /// A constructor.
        /// </summary>
        /// <param name="alpha">An alpha value.</param>
        /// <param name="baseColor">A color as the base-color.</param>
        public Color(int alpha, System.Drawing.Color baseColor)
        {
            var color = System.Drawing.Color.FromArgb(alpha, baseColor);
            this.A = color.A;
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
        }

        /// <summary>
        /// A constructor.
        /// </summary>
        /// <param name="alpha">An alpha value.</param>
        /// <param name="baseColor">A Color as the base-color.</param>
        public Color(int alpha, Color baseColor)
        {
            var color = System.Drawing.Color.FromArgb(alpha, baseColor.R, baseColor.G, baseColor.B);
            this.A = color.A;
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
        }

        /// <summary>
        /// A constructor.
        /// </summary>
        /// <param name="red">The red value of the color.</param>
        /// <param name="green">The green value of the color.</param>
        /// <param name="blue">The blue value of the color.</param>
        public Color(int red, int green, int blue)
        {
            var color = System.Drawing.Color.FromArgb(red, green, blue);
            this.A = color.A;
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
        }

        /// <summary>
        /// A constructor.
        /// </summary>
        /// <param name="alpha">The alpha value of the color.</param>
        /// <param name="red">The red value of the color.</param>
        /// <param name="green">The green value of the color.</param>
        /// <param name="blue">The blue value of the color.</param>
        public Color(int alpha, int red, int green, int blue)
        {
            var color = System.Drawing.Color.FromArgb(alpha, red, green, blue);
            this.A = color.A;
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
        }

        /// <summary>
        /// A constructor.
        /// </summary>
        /// <example>
        /// <code>
        /// var redColor = new RL.Color("red");
        /// var greenColor = new RL.Color("#00FF00");
        /// var blueColor = new RL.Color("rgb(0, 0, 255)");
        /// var transparentColor = new RL.Color("rgba(100, 50, 100, 0.5)");
        /// var yellowColor = new RL.Color("YE");
        /// var cymkColor = new RL.Color("cmyk(0%, 55%, 100%, 0%)");
        /// </code>
        /// </example>
        /// <param name="stringColor">A string color value.</param>
        public Color(string stringColor)
        {
            Color color = null;
            if (TryParseHexColor(stringColor, ref color)) {
                this.A = color.A;
                this.R = color.R;
                this.G = color.G;
                this.B = color.B;
                this.originalString = stringColor;
                return;
            }

            if (TryParseRgbColor(stringColor, ref color)) {
                this.A = color.A;
                this.R = color.R;
                this.G = color.G;
                this.B = color.B;
                this.originalString = stringColor;
                return;
            }

            if (TryParseRgbaColor(stringColor, ref color)) {
                this.A = color.A;
                this.R = color.R;
                this.G = color.G;
                this.B = color.B;
                this.originalString = stringColor;
                return;
            }

            if (TryParseCmykColor(stringColor, ref color)) {
                this.A = color.A;
                this.R = color.R;
                this.G = color.G;
                this.B = color.B;
                this.originalString = stringColor;
                return;
            }

            var stringColorUpperCase = stringColor.ToUpper();
            if (abbreviations.ContainsKey(stringColorUpperCase)) {
                var abbrValue = abbreviations[stringColorUpperCase];
                this.A = 0xFF;
                this.R = abbrValue[0];
                this.G = abbrValue[1];
                this.B = abbrValue[2];
                this.originalString = stringColor;
                return;
            }

            if (knownColors.ContainsKey(stringColor.ToLower())) {
                if (TryParseHexColor(knownColors[stringColor.ToLower()], ref color)) {
                    this.A = color.A;
                    this.R = color.R;
                    this.G = color.G;
                    this.B = color.B;
                    this.originalString = stringColor;
                    return;
                }
            }

            throw new InvalidCastException("Could not parse string-color: '" + stringColor + "'.");
        }

        /// <summary>
        /// Compares 2 colors and returns true, if they are equal.
        /// </summary>
        /// <param name="obj">Another RL.Color instance to compare.</param>
        /// <returns>bool</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) {
                return false;
            }
            if (Object.ReferenceEquals(this, obj)) {
                return true;
            }
            if (this.GetType() != obj.GetType()) {
                return false;
            }

            var color = (Color)obj;
            return (this.A == color.A) && (this.R == color.R) && (this.G == color.G) && (this.B == color.B);
        }

        /// <summary>
        /// Calculates a hash-code for this object.
        /// </summary>
        /// <returns>int</returns>
        public override int GetHashCode()
        {
            return HashCode.Combine(this.A, this.R, this.G, this.B);
        }

        /// <summary>
        /// Compares 2 colors and returns true, if they are equal.
        /// </summary>
        /// <param name="color1">The left color of the equal operator</param>
        /// <param name="color2">The right color of the equal operator</param>
        /// <returns>bool</returns>
        public static bool operator ==(Color color1, Color color2)
        {
            if (color1 is null) {
                if (color2 is null) {
                    return true;
                }
                return false;
            }
            return color1.Equals(color2);
        }

        /// <summary>
        /// Compares 2 colors and returns true, if they are not equal.
        /// </summary>
        /// <param name="color1">The left color of the not-equal operator</param>
        /// <param name="color2">The right color of the not-equal operator</param>
        /// <returns>bool</returns>
        public static bool operator !=(Color color1, Color color2)
        {
            return !(color1 == color2);
        }

        /// <summary>
        /// This simply applies the mathematical addition of the 2 colors and returns a new RL.Color instance.
        /// </summary>
        /// <param name="color1">The left color of the "+"-operator</param>
        /// <param name="color2">The right color of the "+"-operator</param>
        /// <returns>RL.Color</returns>
        public static Color operator +(Color color1, Color color2)
        {
            var red = Math.Min(color1.R + color2.R, 255);
            var green = Math.Min(color1.G + color2.G, 255);
            var blue = Math.Min(color1.B + color2.B, 255);

            return new Color(color1.A, red, green, blue);
        }

        /// <summary>
        /// This simply applies the mathematical subtraction of the 2 colors and returns a new RL.Color instance.
        /// </summary>
        /// <param name="color1">The left color of the "-"-operator</param>
        /// <param name="color2">The left color of the "-"-operator</param>
        /// <returns>RL.Color</returns>
        public static Color operator -(Color color1, Color color2)
        {
            var red = Math.Max(color1.R - color2.R, 0);
            var green = Math.Max(color1.G - color2.G, 0);
            var blue = Math.Max(color1.B - color2.B, 0);

            return new Color(color1.A, red, green, blue);
        }

        /// <summary>
        /// This does the same as System.Drawing.Color.FromArgb(int argb), except for the return value.
        /// </summary>
        /// <param name="argb">An integer value of the argb color.</param>
        /// <returns>RL.Color</returns>
        public static Color FromArgb(int argb)
        {
            return new Color(System.Drawing.Color.FromArgb(argb));
        }

        /// <summary>
        /// This does the same as System.Drawing.Color.FromArgb(int alpha, System.Drawing.Color baseColor), except for the return value.
        /// </summary>
        /// <param name="alpha">The alpha value</param>
        /// <param name="baseColor">The base color</param>
        /// <returns>RL.Color</returns>
        public static Color FromArgb(int alpha, System.Drawing.Color baseColor)
        {
            return new Color(System.Drawing.Color.FromArgb(alpha, baseColor));
        }

        /// <summary>
        /// This does the same as System.Drawing.Color.FromArgb(int alpha, System.Drawing.Color baseColor), except for the return value.
        /// </summary>
        /// <param name="alpha">The alpha value</param>
        /// <param name="baseColor">The base color</param>
        /// <returns>RL.Color</returns>
        public static Color FromArgb(int alpha, Color baseColor)
        {
            return new Color(System.Drawing.Color.FromArgb(alpha, baseColor.R, baseColor.G, baseColor.B));
        }

        /// <summary>
        /// This does the same as System.Drawing.Color.FromArgb(int red, int green, int blue), except for the return value.
        /// </summary>
        /// <param name="red">The red value</param>
        /// <param name="green">The green value</param>
        /// <param name="blue">The blue value</param>
        /// <returns>RL.Color</returns>
        public static Color FromArgb(int red, int green, int blue)
        {
            return new Color(System.Drawing.Color.FromArgb(red, green, blue));
        }

        /// <summary>
        /// This does the same as System.Drawing.Color.FromArgb(int alpha, int red, int green, int blue), except for the return value.
        /// </summary>
        /// <param name="alpha">The alpha value</param>
        /// <param name="red">The red value</param>
        /// <param name="green">The green value</param>
        /// <param name="blue">The blue value</param>
        /// <returns>RL.Color</returns>
        public static Color FromArgb(int alpha, int red, int green, int blue)
        {
            return new Color(System.Drawing.Color.FromArgb(alpha, red, green, blue));
        }

        /// <summary>
        /// This does the same as System.Drawing.Color.FromName(string name), except for the return value.
        /// </summary>
        /// <param name="name">The color name</param>
        /// <returns>RL.Color</returns>
        public static Color FromName(string name)
        {
            return new Color(System.Drawing.Color.FromName(name));
        }

        /// <summary>
        /// Returns the color as a hex value.
        /// </summary>
        /// <example>
        /// <code>
        /// var redColor = new RL.Color("red");
        /// Console.WriteLine("red-hex: " + redColor.ToHEXString());
        /// </code>
        /// </example>
        /// <seealso cref="RL.Color.ToRGBString()"/>
        /// <seealso cref="RL.Color.ToRGBAString()"/>
        /// <seealso cref="RL.Color.ToCMYKString()"/>
        /// <returns>string</returns>
        public string ToHEXString()
        {
            var colorString = "#";
            if (this.A != 255) {
                colorString += string.Format("{0:X2}", this.A);
            }
            colorString += string.Format("{0:X2}{1:X2}{2:X2}", this.R, this.G, this.B);
            return colorString;
        }

        /// <summary>
        /// Returns the color as rgb value.
        /// </summary>
        /// <example>
        /// <code>
        /// var redColor = new RL.Color("red");
        /// Console.WriteLine("red-rgb: " + redColor.ToRGBString());
        /// </code>
        /// </example>
        /// <seealso cref="RL.Color.ToHEXString()"/>
        /// <seealso cref="RL.Color.ToRGBAString()"/>
        /// <seealso cref="RL.Color.ToCMYKString()"/>
        /// <returns>string</returns>
        public string ToRGBString()
        {
            return string.Format("rgb({0}, {1}, {2})", this.R, this.G, this.B);
        }

        /// <summary>
        /// Returns the color as rgba value.
        /// </summary>
        /// <example>
        /// <code>
        /// var redColor = new RL.Color("red");
        /// Console.WriteLine("red-rgba: " + redColor.ToRGBAString());
        /// </code>
        /// </example>
        /// <seealso cref="RL.Color.ToHEXString()"/>
        /// <seealso cref="RL.Color.ToRGBString()"/>
        /// <seealso cref="RL.Color.ToCMYKString()"/>
        /// <returns>string</returns>
        public string ToRGBAString()
        {
            return string.Format(CultureInfo.InvariantCulture, "rgba({0}, {1}, {2}, {3:0.##})", this.R, this.G, this.B, (double)this.A / 255.0);
        }

        /// <summary>
        /// Returns the color as cmyk value.
        /// </summary>
        /// <example>
        /// <code>
        /// var redColor = new RL.Color("red");
        /// Console.WriteLine("red-cmyk: " + redColor.ToCMYKString());
        /// </code>
        /// </example>
        /// <seealso cref="RL.Color.ToHEXString()"/>
        /// <seealso cref="RL.Color.ToRGBString()"/>
        /// <seealso cref="RL.Color.ToRGBAString()"/>
        /// <returns>string</returns>
        public string ToCMYKString()
        {
            var r = (int)this.R / 255.0;
            var g = (int)this.G / 255.0;
            var b = (int)this.B / 255.0;
            var black = 1.0 - Math.Max(Math.Max(r, g), b);
            
            var cyan = Math.Round((1.0 - r - black) / (1.0 - black) * 100.0);
            var magenta = Math.Round((1.0 - g - black) / (1.0 - black) * 100.0);
            var yellow = Math.Round((1.0 - b - black) / (1.0 - black) * 100.0);
            if (double.NaN.Equals(cyan)) {
                cyan = 0;
            }
            if (double.NaN.Equals(magenta)) {
                magenta = 0;
            }
            if (double.NaN.Equals(yellow)) {
                yellow = 0;
            }

            return string.Format("cmyk({0}%, {1}%, {2}%, {3}%)", cyan, magenta, yellow, Math.Round(black * 100.0));
        }

        private static bool TryParseHexColor(string hexColor, ref Color color)
        {
            var colorHexMatch = Regex.Match(hexColor, "^#?([0-9A-Fa-f]{2})?([0-9A-Fa-f]{2})([0-9A-Fa-f]{2})([0-9A-Fa-f]{2})$", RegexOptions.Compiled);
            if (!colorHexMatch.Success) {
                return false;
            }

            var alpha = 255;
            if (colorHexMatch.Groups[1].Value != string.Empty) {
                alpha = short.Parse(colorHexMatch.Groups[1].Value, NumberStyles.HexNumber);
            }
            
            var red = short.Parse(colorHexMatch.Groups[2].Value, NumberStyles.HexNumber);
            var green = short.Parse(colorHexMatch.Groups[3].Value, NumberStyles.HexNumber);
            var blue = short.Parse(colorHexMatch.Groups[4].Value, NumberStyles.HexNumber);
            var colorFromArgb = System.Drawing.Color.FromArgb(alpha, red, green, blue);
            if (color == null) {
                color = new Color();
            }
            color.A = colorFromArgb.A;
            color.R = colorFromArgb.R;
            color.G = colorFromArgb.G;
            color.B = colorFromArgb.B;

            return true;
        }

        private static bool TryParseRgbColor(string rgbColor, ref Color color)
        {
            var colorRgbMatch = Regex.Match(rgbColor, @"\s*rgb\s*\(\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*\)\s*", RegexOptions.Compiled);
            if (!colorRgbMatch.Success) {
                return false;
            }

            var red = short.Parse(colorRgbMatch.Groups[1].Value, CultureInfo.InvariantCulture);
            var green = short.Parse(colorRgbMatch.Groups[2].Value, CultureInfo.InvariantCulture);
            var blue = short.Parse(colorRgbMatch.Groups[3].Value, CultureInfo.InvariantCulture);
            var colorFromArgb = System.Drawing.Color.FromArgb(red, green, blue);
            if (color == null) {
                color = new Color();
            }
            color.R = colorFromArgb.R;
            color.G = colorFromArgb.G;
            color.B = colorFromArgb.B;

            return true;
        }

        private static bool TryParseRgbaColor(string rgbaColor, ref Color color)
        {
            var colorRgbaMatch = Regex.Match(rgbaColor, @"\s*rgba\s*\(\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*,\s*([0-9]{1,3})\s*,\s*([0-9]+(\.[0-9]+)?)\s*\)\s*", RegexOptions.Compiled);
            if (!colorRgbaMatch.Success) {
                return false;
            }

            var red = short.Parse(colorRgbaMatch.Groups[1].Value, CultureInfo.InvariantCulture);
            var green = short.Parse(colorRgbaMatch.Groups[2].Value, CultureInfo.InvariantCulture);
            var blue = short.Parse(colorRgbaMatch.Groups[3].Value, CultureInfo.InvariantCulture);
            var alpha = double.Parse(colorRgbaMatch.Groups[4].Value, CultureInfo.InvariantCulture);
            var colorFromArgb = System.Drawing.Color.FromArgb((int)Math.Floor(alpha * 255), red, green, blue);
            if (color == null) {
                color = new Color();
            }
            color.A = colorFromArgb.A;
            color.R = colorFromArgb.R;
            color.G = colorFromArgb.G;
            color.B = colorFromArgb.B;

            return true;
        }

        private static bool TryParseCmykColor(string cmykColor, ref Color color)
        {
            var colorCmykMatch = Regex.Match(cmykColor, @"\s*cmyk\s*\(\s*([0-9]+(\.[0-9]+)?)\s*%?\s*,\s*([0-9]+(\.[0-9]+)?)\s*%?\s*,\s*([0-9]+(\.[0-9]+)?)\s*%?\s*,\s*([0-9]+(\.[0-9]+)?)\s*%?\s*\)\s*", RegexOptions.Compiled);
            if (!colorCmykMatch.Success) {
                return false;
            }

            var cyan = double.Parse(colorCmykMatch.Groups[1].Value, CultureInfo.InvariantCulture);
            var magenta = double.Parse(colorCmykMatch.Groups[3].Value, CultureInfo.InvariantCulture);
            var yellow = double.Parse(colorCmykMatch.Groups[5].Value, CultureInfo.InvariantCulture);
            var black = double.Parse(colorCmykMatch.Groups[7].Value, NumberStyles.Float);

            var red = (int)Math.Round(255.0 * (1.0 - cyan / 100.0) * (1.0 - black / 100.0));
            var green = (int)Math.Round(255.0 * (1.0 - magenta / 100.0) * (1.0 - black / 100.0));
            var blue = (int)Math.Round(255.0 * (1.0 - yellow / 100.0) * (1.0 - black / 100.0));
            
            var colorFromArgb = System.Drawing.Color.FromArgb(red, green, blue);
            if (color == null) {
                color = new Color();
            }
            color.A = colorFromArgb.A;
            color.R = colorFromArgb.R;
            color.G = colorFromArgb.G;
            color.B = colorFromArgb.B;

            return true;
        }

        /// <summary>
        /// Resets the color (black).
        /// </summary>
        public void Reset() {
            this.A = 255;
            this.R = 0;
            this.G = 0;
            this.B = 0;
            this.originalString = string.Empty;
        }

        private static byte[] GetRGBFromHSV(double h, double s, double v)
        {
            if (h < 0.0 || h > 360.0) {
                h = ((h % 360.0) + 360.0) % 360.0;
            }
            if (s < 0.0) {
                s = 0.0;
            } else if (s > 1.0) {
                s = 1.0;
            }
            if (v < 0.0) {
                v = 0.0;
            } else if (v > 1.0) {
                v = 1.0;
            }

            var c = v * s;
            var x = c * (1.0 - Math.Abs((h / 60.0) % 2.0 - 1.0));
            var m = v - c;

            var r1 = 0.0;
            var g1 = 0.0;
            var b1 = 0.0;
            if ((h >= 0.0 && h < 60.0) || h == 360.0) {
                r1 = c;
                g1 = x;
            } else if (h >= 60.0 && h < 120.0) {
                r1 = x;
                g1 = c;
            } else if (h >= 120.0 && h < 180.0) {
                g1 = c;
                b1 = x;
            } else if (h >= 180.0 && h < 240.0) {
                g1 = x;
                b1 = c;
            } else if (h >= 240.0 && h < 300.0) {
                r1 = x;
                b1 = c;
            } else if (h >= 300.0 && h < 360.0) {
                r1 = c;
                b1 = x;
            }

            var r = (byte)Math.Round((r1 + m) * 255.0);
            var g = (byte)Math.Round((g1 + m) * 255.0);
            var b = (byte)Math.Round((b1 + m) * 255.0);

            return new byte[] { r, g, b };
        }

        private double[] GetHSVA()
        {
            var min = 1.0;
            var max = 0.0;

            var red = (double)this.R / 255.0;
            var green = (double)this.G / 255.0;
            var blue = (double)this.B / 255.0;
            var alpha = Math.Round((double)this.A / 255.0, 2);

            if (red < min) {
                min = red;
            }
            if (green < min) {
                min = green;
            }
            if (blue < min) {
                min = blue;
            }
            if (red > max) {
                max = red;
            }
            if (green > max) {
                max = green;
            }
            if (blue > max) {
                max = blue;
            }

            if (max == 0.0) {
                return new double[] { 0.0, 0.0, 0.0, alpha };
            }

            var v = max;
            var delta = max - min;
            var s = delta / max;
            var h = 0.0;
            if (delta != 0.0) {
                if (red == max) {
                    h = (green - blue) / delta;
                } else if (green == max) {
                    h = 2.0 + (blue - red) / delta;
                } else {
                    h = 4.0 + (red - green) / delta;
                };

                h *= 60.0;
                if (h < 0.0) {
                    h += 360.0;
                }
            }

            return new double[] { h, s, v, alpha };
        }

        private void GetHSLValue(out double h, out double s, out double l) {
            h = 0.0;
            s = 0.0;

            var min = 1.0;
            var max = 0.0;

            var red = this.R / 255.0;
            var green = this.G / 255.0;
            var blue = this.B / 255.0;

            if (red < min) {
                min = red;
            }
            if (green < min) {
                min = green;
            }
            if (blue < min) {
                min = blue;
            }
            if (red > max) {
                max = red;
            }
            if (green > max) {
                max = green;
            }
            if (blue > max) {
                max = blue;
            }

            l = (max + min) / 2.0;

            if (max != min) {
                s = (l < 0.5) ? (max - min) / (max + min) : (max - min) / (2.0 - max - min);
            }

            if (red == max) {
                h = (green - blue) / (max - min);
            } else if (green == max) {
                h = 2.0 + (blue - red) / (max - min);
            } else if (blue == max) {
                h = 4.0 + (red - green) / (max - min);
            }

            h*= 60.0;
            if (h < 0) {
                h+= 360.0;
            }
        }

        private void SetHSLValue(double h, double s, double l) {
            if (h < 0.0 || h > 360.0) {
                throw new ArgumentException("The argument for h[hue] (" + h + ") is out of range. It must be between 0.0 and 360.0.", nameof(h));
            }
            if (s < 0.0 || s > 1.0) {
                throw new ArgumentException("The argument for s[saturation] (" + s + ") is out of range. It must be between 0.0 and 1.0.", nameof(s));
            }
            if (l < 0.0 || l > 1.0) {
                throw new ArgumentException("The argument for l[lightness] (" + l + ") is out of range. It must be between 0.0 and 1.0.", nameof(l));
            }

            this.Reset();

            if (s == 0) {
                this.R = (byte)Math.Round(l * 255.0);
                this.G = (byte)Math.Round(l * 255.0);
                this.B = (byte)Math.Round(l * 255.0);
            } else {
                var t3 = new double[3] { 0, 0, 0 };
                var c = new double[3] { 0, 0, 0 };
                var t2 = (l < 0.5) ? l * (1.0 + s) : l + s - l * s;
                var t1 = 2.0 * l - t2;
                h/= 360.0;
                t3[0] = h + 1.0 / 3.0;
                t3[1] = h;
                t3[2] = h - 1.0 / 3.0;
                for(var i = 0; i < 3; i++) {
                    if (t3[i] < 0.0) {
                        t3[i]+= 1.0;
                    }
                    if (t3[i] > 1.0) {
                        t3[i]-= 1.0;
                    }
                    if (6.0 * t3[i] < 1.0) {
                        c[i] = t1 + (t2 - t1) * 6.0 * t3[i];
                    } else if (2.0 * t3[i] < 1.0) {
                        c[i] = t2;
                    } else if (3.0 * t3[i] < 2.0) {
                        c[i] = t1 + (t2 - t1) * ((2.0 / 3.0) - t3[i]) * 6.0;
                    } else {
                        c[i] = t1;
                    }
                }

                this.R = (byte)Math.Round(c[0] * 255.0);
                this.G = (byte)Math.Round(c[1] * 255.0);
                this.B = (byte)Math.Round(c[2] * 255.0);
            }
        }

        /// <summary>
        /// Grayscales the current color and returns a new instance.
        /// </summary>
        /// <returns>A new RL.Color instance.</returns>
        public Color Grayscale()
        {
            var grayValue = (int)Math.Floor((double)this.R * 0.299 + (double)this.G * 0.587 + (double)this.B * 0.114);
            return new Color(this.A, grayValue, grayValue, grayValue);
        }

        /// <summary>
        /// Interpolates the current color and returns a new instance.
        /// </summary>
        /// <returns>A new RL.Color instance.</returns>
        public Color Interpolate(Color color, double interpolation)
        {
            interpolation = Math.Max(Math.Min(interpolation, 1.0), 0.0);

            var a = (int)Math.Round((double)this.A + (double)((int)color.A - (int)this.A) * interpolation);
            var r = (int)Math.Round((double)this.R + (double)((int)color.R - (int)this.R) * interpolation);
            var g = (int)Math.Round((double)this.G + (double)((int)color.G - (int)this.G) * interpolation);
            var b = (int)Math.Round((double)this.B + (double)((int)color.B - (int)this.B) * interpolation);

            return new Color(a, r, g, b);
        }

        /// <summary>
        /// Interpolates the current color by hsv colorspace and returns a new instance.
        /// </summary>
        /// <returns>A new RL.Color instance.</returns>
        public Color InterpolateHSV(Color color, double interpolation)
        {
            interpolation = Math.Max(Math.Min(interpolation, 1.0), 0.0);

            var hsva = this.GetHSVA();
            var first_h = hsva[0];
            var first_s = hsva[1];
            var first_v = hsva[2];

            var second_hsva = color.GetHSVA();
            var second_h = second_hsva[0];
            var second_s = second_hsva[1];
            var second_v = second_hsva[2];

            var new_h = first_h + (second_h - first_h) * interpolation;
            var new_s = first_s + (second_s - first_s) * interpolation;
            var new_v = first_v + (second_v - first_v) * interpolation;
            var new_a = (double)this.A + (double)((int)color.A - (int)this.A) * interpolation / 255.0;
            new_a = Math.Max(Math.Min(new_a, 1.0), 0.0);

            var a = (int)Math.Round(new_a * 255.0);
            var rgb = Color.GetRGBFromHSV(new_h, new_s, new_v);

            return new Color(a, rgb[0], rgb[1], rgb[2]);
        }

        /// <summary>
        /// Inverts the current color and returns a new instance.
        /// </summary>
        /// <returns>A new RL.Color instance.</returns>
        public Color Invert()
        {
            return new Color(this.A, 255 - this.R, 255 - this.G, 255 - this.B);
        }

        /// <summary>
        /// Inverts the current color with the respect of the luminescence and returns a new instance.
        /// </summary>
        /// <returns>A new RL.Color instance.</returns>
        public Color InvertLuminescence()
        {
            this.GetHSLValue(out double h, out double s, out double l);
            var newColor = new Color();
            newColor.SetHSLValue(h, s, 1.0 - l);
            newColor.A = this.A;
            return newColor;
        }

        /// <summary>
        /// Colorizes the current color and returns a new instance.
        /// </summary>
        /// <param name="color">A color.</param>
        /// <returns>A new RL.Color instance.</returns>
        public Color Colorize(System.Drawing.Color color)
        {
            return this.Colorize(new Color(color));
        }

        /// <summary>
        /// Colorizes the current color and returns a new instance.
        /// </summary>
        /// <param name="color">A color.</param>
        /// <returns>A new RL.Color instance.</returns>
        public Color Colorize(Color color)
        {
            return new Color((int)Math.Round(this.A * color.A / 255.0), (int)Math.Round(this.R * color.R / 255.0), (int)Math.Round(this.G * color.G / 255.0), (int)Math.Round(this.B * color.B / 255.0));
        }
        
        /// <summary>
        /// Colorizes the current color and returns a new instance.
        /// </summary>
        /// <param name="color">A color.</param>
        /// <returns>A new RL.Color instance.</returns>
        public Color Colorize(string color)
        {
            return this.Colorize(new Color(color));
        }
    }
}
