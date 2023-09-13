using System;
using Uppgift_arv;


Console.WriteLine("Skriv 1 för rätvinklig triangel och 2 för rektangel");
int val = int.Parse(Console.ReadLine());


if (val == 2)
{
    Console.WriteLine("Skriv höjd och bredd på var enda linje");
    Shape p1 = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())); //

    Console.WriteLine("Area är: " +p1.Area()+ ".");
    Console.WriteLine("Omkrets är: " +p1.Circumferance()+ ".");
}
else if(val== 1)
{
    Console.WriteLine("Skriv höjd och bredd på var enda linje");
    Triangle p2 = new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

    Console.WriteLine("Area är: " +p2.Area()+ ".");
    Console.WriteLine("Omkrets är: " +p2.Circumferance()+ ".");
}
else
{
    Console.WriteLine("Välj mellan 1 eller 2");
}