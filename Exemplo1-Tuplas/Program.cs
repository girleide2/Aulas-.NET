#region Tuples examples

using System.Data;
using System.Data.Common;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

var tuple1 = (10, 20);
Console.WriteLine($"tuple 1: {tuple1.Item1}, {tuple1.Item2}");

var tuple2 = (X: 5, Y: 50);
Console.WriteLine($"tuple 1: {tuple2.X}, {tuple2.Y}");

var tuple3 = (id: 10, name: "Girleide", born: new DateTime (1999, 10, 25));
Console.WriteLine($"tuple 1: {tuple3.id}, {tuple3.name}, {tuple3.born}");

#endregion