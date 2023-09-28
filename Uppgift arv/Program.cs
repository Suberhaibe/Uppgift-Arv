using System;
using Uppgift_arv;


Console.WriteLine("Skriv 1 för rätvinklig triangel och 2 för rektangel");
int val = int.Parse(Console.ReadLine());
Shape shape = null;

if (val == 2)
{
    Console.WriteLine("Skriv höjd och bredd på var enda linje");
    shape = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())); //
}
else if(val== 1)
{
    Console.WriteLine("Skriv höjd och bredd på var enda linje");
    shape = new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
}
else
{
    Console.WriteLine("Välj mellan 1 eller 2");
}

    Console.WriteLine("Area är: " +shape.Area()+ ".");
    Console.WriteLine("Omkrets är: " +shape.Circumferance()+ "."); //theba