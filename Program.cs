// See https://aka.ms/new-console-template for more information
// using System;

// public class Vegetable
// {
//    public Vegetable(string name) => Name = name;

//    public string Name { get; }

//    public override string ToString() => Name;
// }

// public class Program
// {
//    public enum Unit { item, kilogram, gram, dozen };

//    public static void Main()
//    {
//       var item = new Vegetable("eggplant");
//       var date = DateTime.Now;
//       var price = 1.99m;
//       var unit = Unit.item;
//       Console.WriteLine($"On {date:d}, the price of {item} was {price:c2} per {unit}.");
//    }
// }

// using System;
// using System.Collections.Generic;

// public class Example
// {
//    public static void Main()
//    {
//       var titles = new Dictionary<string, string>()
//       {
//           ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
//           ["London, Jack"] = "Call of the Wild, The",
//           ["Shakespeare, William"] = "Tempest, The"
//       };

//       Console.WriteLine("Author and Title List");
//       Console.WriteLine();
//       Console.WriteLine($"|{"Author",-25}|{"Title",30}|");
//       foreach (var title in titles)
//       Console.WriteLine($"|{title.Key,-25}|{title.Value,30}|");
//       Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
//    }
// }

// double a = 3;
// double b = 4;
// Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
// Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateHypotenuse(a, b)}");

// double CalculateHypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);

// Expected output:
// Area of the right triangle with legs of 3 and 4 is 6
// Length of the hypotenuse of the right triangle with legs of 3 and 4 is 5

// var date = new DateTime(1731, 11, 25);
// Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:F5} in a letter to Christian Goldbach.");

// Expected output:
// On Sunday, November 25, 1731 Leonhard Euler introduced the letter e to denote 2.71828 in a letter to Christian Goldbach.

// const int NameAlignment = -9;
// const int ValueAlignment = 7;

// double a = 3;
// double b = 4;
// Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
// Console.WriteLine($"|{"Arithmetic",NameAlignment}|{0.5 * (a + b),ValueAlignment:F3}|");
// Console.WriteLine($"|{"Geometric",NameAlignment}|{Math.Sqrt(a * b),ValueAlignment:F3}|");
// Console.WriteLine($"|{"Harmonic",NameAlignment}|{2 / (1 / a + 1 / b),ValueAlignment:F3}|");

// Expected output:
// Three classical Pythagorean means of 3 and 4:
// |Arithmetic|  3.500|
// |Geometric|  3.464|
// |Harmonic |  3.429|

// var xs = new int[] { 1, 2, 7, 9 };
// var ys = new int[] { 7, 9, 12 };
// Console.WriteLine($"Find the intersection of the {{{string.Join(", ",xs)}}} and {{{string.Join(", ",ys)}}} sets.");

// var userName = "Jane";
// var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
// var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
// Console.WriteLine(stringWithEscapes);
// Console.WriteLine(verbatimInterpolated);

// Expected output:
// Find the intersection of the {1, 2, 7, 9} and {7, 9, 12} sets.
// C:\Users\Jane\Documents
// C:\Users\Jane\Documents

// var rand = new Random();
// for (int i = 0; i < 7; i++)
// {
//     Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : "tails")}");
// }

var cultures = new System.Globalization.CultureInfo[]
{
    System.Globalization.CultureInfo.GetCultureInfo("en-US"),
    System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
    System.Globalization.CultureInfo.GetCultureInfo("nl-NL"),
    System.Globalization.CultureInfo.InvariantCulture
};

var date = DateTime.Now;
var number = 31_415_926.536;
FormattableString message = $"{date,20}{number,20:N3}";
foreach (var culture in cultures)
{
    var cultureSpecificMessage = message.ToString(culture);
    Console.WriteLine($"{culture.Name,-10}{cultureSpecificMessage}");
}

// Expected output is like:
// en-US       5/17/18 3:44:55 PM      31,415,926.536
// en-GB      17/05/2018 15:44:55      31,415,926.536
// nl-NL        17-05-18 15:44:55      31.415.926,536
//            05/17/2018 15:44:55      31,415,926.536

string messageInInvariantCulture = FormattableString.Invariant($"Date and time in invariant culture: {DateTime.Now}");
Console.WriteLine(messageInInvariantCulture);

// Expected output is like:
// Date and time in invariant culture: 05/17/2018 15:46:24