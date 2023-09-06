using System;
using Uppgift_arv;


Console.WriteLine("Skriv 1 för rätvinklig triangel och 2 för rektangel");
Console.WriteLine("Skriv höjd och bredd på var enda linje");

Rectangle p1 = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Triangle p2 = new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));