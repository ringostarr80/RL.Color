# RL.Color API

* [Constructors](#constructors)
  * [new RL.Color()](#constructor_default)
  * [new RL.Color(System.Drawing.Color color)](#constructor_system_drawing_color)
  * [new RL.Color(int argb)](#constructor_argb_color)
  * [new RL.Color(int alpha, System.Drawing.Color color)](#constructor_alpha_system_drawing_color)
  * [new RL.Color(int alpha, RL.Color color)](#constructor_alpha_color)
  * [new RL.Color(int red, int green, int blue)](#constructor_rgb)
  * [new RL.Color(int alpha, int red, int green, int blue)](#constructor_argb)
  * [new RL.Color(string color)](#constructor_string)
* [Methods](#methods)
  * [Colorize(System.Drawing.Color color): RL.Color](#colorize_system_drawing_color)
  * [Colorize(RL.Color color): RL.Color](#colorize_color)
  * [Colorize(string color): RL.Color](#colorize_string)
  * [Grayscale(): RL.Color](#grayscale)
  * [Invert(): RL.Color](#invert)
  * [InvertLuminescence(): RL.Color](#invert_luminescence)
  * [Reset(): void](#reset)
  * [ToHEXString(): string](#to_hex_string)
  * [ToRGBString(): string](#to_rgb_string)
  * [ToRGBAString(): string](#to_rgba_string)
  * [ToCMYKString(): string](#to_cmyk_string)
* [Properties](#properties)
  * [get R(): byte, set R(byte value)](#r)
  * [get G(): byte, set G(byte value)](#g)
  * [get B(): byte, set B(byte value)](#b)
  * [get A(): byte, set A(byte value)](#a)
  * [get C(): double](#c)
  * [get M(): double](#m)
  * [get Y(): double](#y)
  * [get K(): double](#k)

<a name="constructors"></a>

## Constructors

<a name="constructor_default"></a>

### new RL.Color()

```csharp
var defaultColor = new RL.Color();
Console.WriteLine("default hex-string: " + defaultColor.ToHEXString());
```

> default hex-string: #000000  

<a name="constructor_system_drawing_color"></a>

### new RL.Color(System.Drawing.Color color)

```csharp
using System.Drawing;

var redColor = new RL.Color(Color.Red);
Console.WriteLine("red hex-string: " + redColor.ToHEXString());
```

> red hex-string: #FF0000  

<a name="constructor_argb_color"></a>

### new RL.Color(int argb)

```csharp
var blueColor = new RL.Color(unchecked((int)0xFF0000FF));
Console.WriteLine("blue hex-string: " + blueColor.ToHEXString());
```

> blue hex-string: #0000FF  

<a name="constructor_alpha_system_drawing_color"></a>

### new RL.Color(int alpha, System.Drawing.Color color)

```csharp
using System.Drawing;

var redColor = new RL.Color(127, Color.Red);
Console.WriteLine("red rgba-string: " + redColor.ToRGBAString());
```

> red rgba-string: rgba(255, 0, 0, 0.5)  

<a name="constructor_alpha_color"></a>

### new RL.Color(int alpha, RL.Color color)

```csharp
var redColor = new RL.Color(127, new RL.Color("red"));
Console.WriteLine("red rgba-string: " + redColor.ToRGBAString());
```

> red rgba-string: rgba(255, 0, 0, 0.5)  

<a name="constructor_rgb"></a>

### new RL.Color(int red, int green, int blue)

```csharp
var redColor = new RL.Color(255, 0, 0);
Console.WriteLine("red rgb-string: " + redColor.ToRGBString());
```

> red rgb-string: rgb(255, 0, 0)  

<a name="constructor_argb"></a>

### new RL.Color(int alpha, int red, int green, int blue)

```csharp
var redTransparentColor = new RL.Color(127, 255, 0, 0);
Console.WriteLine("red rgba-string: " + redTransparentColor.ToRGBAString());
```

> red rgba-string: rgba(255, 0, 0, 0.5)  

<a name="constructor_string"></a>

### new RL.Color(string color)

```csharp
var redColor = new RL.Color("red");
var greenColor = new RL.Color("#00FF00");
var blueColor = new RL.Color("rgb(0, 0, 255)");
var blueTransparentColor = new RL.Color("rgba(0, 0, 255, 0.5)");
var cmykColor = new RL.Color("cmyk(0%, 55%, 100%, 0%)");
Console.WriteLine("red hex-string: " + redColor.ToHEXString());
Console.WriteLine("green hex-string: " + greenColor.ToHEXString());
Console.WriteLine("blue hex-string: " + blueColor.ToHEXString());
Console.WriteLine("blue-transparent hex-string: " + blueTransparentColor.ToHEXString());
Console.WriteLine("cmyk hex-string: " + cmykColor.ToHEXString());
```

> red hex-string: #FF0000  
> green hex-string: #00FF00  
> blue hex-string: #0000FF  
> blue-transparent hex-string: #7F0000FF  
> cmyk hex-string: #FF7300  

<a name="methods"></a>

## Methods

<a name="colorize_system_drawing_color"></a>

### Colorize(System.Drawing.Color color): RL.Color

```csharp
var whiteColor = new RL.Color("white");
var colorizedColor = whiteColor.Colorize(System.Drawing.Color.Red);
Console.WriteLine("colorized color hex-string: " + colorizedColor.ToHEXString());
```

> colorized color hex-string: #FF0000  

<a name="colorize_color"></a>

### Colorize(RL.Color color): RL.Color

```csharp
var whiteColor = new RL.Color("white");
var colorizedColor = whiteColor.Colorize(new RL.Color("red"));
Console.WriteLine("colorized color hex-string: " + colorizedColor.ToHEXString());
```

> colorized color hex-string: #FF0000  

<a name="colorize_string"></a>

### Colorize(string color): RL.Color

```csharp
var whiteColor = new RL.Color("white");
var colorizedColor = whiteColor.Colorize("red");
Console.WriteLine("colorized color hex-string: " + colorizedColor.ToHEXString());
```

> colorized color hex-string: #FF0000  

<a name="grayscale"></a>

### Grayscale(): RL.Color

```csharp
var randomColor = new RL.Color("#123456");
var grayscaledColor = randomColor.Grayscale();
Console.WriteLine("grayscaled color hex-string: " + grayscaledColor.ToHEXString());
```

> grayscaled color hex-string: #2D2D2D  

<a name="invert"></a>

### Invert(): RL.Color

```csharp
var randomColor = new RL.Color("#123456");
var invertedColor = randomColor.Invert();
Console.WriteLine("inverted color hex-string: " + invertedColor.ToHEXString());
```

> inverted color hex-string: #EDCBA9  

<a name="invert_luminescence"></a>

### InvertLuminescence(): RL.Color

```csharp
var randomColor = new RL.Color("#123456");
var invertedColor = randomColor.InvertLuminescence();
Console.WriteLine("invert-luminescenced color hex-string: " + invertedColor.ToHEXString());
```

> invert-luminescenced color hex-string: #A9CBED  

<a name="reset"></a>

### Reset(): void

```csharp
var redColor = new RL.Color("red");
Console.WriteLine("red hex-string: " + redColor.ToHEXString());
redColor.Reset();
Console.WriteLine("resetted color hex-string: " + redColor.ToHEXString());
```

> red hex-string: #FF0000  
> resetted color hex-string: #000000  

<a name="to_hex_string"></a>

### ToHEXString(): string

```csharp
var redColor = new RL.Color("red");
Console.WriteLine("red hex-string: " + redColor.ToHEXString());
```

> red hex-string: #FF0000  

<a name="to_rgb_string"></a>

### ToRGBString(): string

```csharp
var redColor = new RL.Color("red");
Console.WriteLine("red rgb-string: " + redColor.ToRGBString());
```

> red rgb-string: rgb(255, 0, 0)  

<a name="to_rgba_string"></a>

### ToRGBAString(): string

```csharp
var redColor = new RL.Color("red");
Console.WriteLine("red rgba-string: " + redColor.ToRGBAString());
```

> red rgba-string: rgba(255, 0, 0, 1)  

<a name="to_cmyk_string"></a>

### ToCMYKString(): string

```csharp
var redColor = new RL.Color("red");
Console.WriteLine("red cmyk-string: " + redColor.ToCMYKString());
```

> red cmyk-string: cmyk(0%, 100%, 100%, 0%)  

<a name="properties"></a>

## Properties

<a name="r"></a>

### get R(): byte, set R(value: byte)

```csharp
var redColor = new RL.Color("red");
Console.WriteLine("R value: " + redColor.R);
```

> R value: 255  

<a name="g"></a>

### get G(): byte, set G(value: byte)

```csharp
var greenColor = new RL.Color("green");
Console.WriteLine("G value: " + greenColor.G);
```

> G value: 127  

<a name="b"></a>

### get B(): byte, set B(value: byte)

```csharp
var blueColor = new RL.Color("blue");
Console.WriteLine("B value: " + blueColor.R);
```

> B value: 255  

<a name="a"></a>

### get A(): byte, set A(value: byte)

```csharp
var transparentColor = new RL.Color("rgba(255, 0, 0, 0.5)");
Console.WriteLine("A value: " + transparentColor.A);
```

> A value: 127  

<a name="c"></a>

### get C(): double

```csharp
var cmykColor = new RL.Color("cmyk(45%, 0%, 0%, 0%)");
Console.WriteLine("C value: " + cmykColor.C);
```

> C value: 45  

<a name="m"></a>

### get M(): double

```csharp
var cmykColor = new RL.Color("cmyk(0%, 55%, 0%, 0%)");
Console.WriteLine("C value: " + cmykColor.C);
```

> C value: 55  

<a name="y"></a>

### get Y(): double

```csharp
var cmykColor = new RL.Color("cmyk(0%, 0%, 60%, 0%)");
Console.WriteLine("Y value: " + cmykColor.Y);
```

> Y value: 60  

<a name="k"></a>

### get K(): double

```csharp
var cmykColor = new RL.Color("cmyk(0%, 0%, 0%, 10%)");
Console.WriteLine("K value: " + cmykColor.K);
```

> K value: 10  