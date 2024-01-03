using Maths;
using HR;
using GDI;
using System.Runtime.CompilerServices;

Person p1=new Person();
p1.Name="Happy";
p1.Age=22;
p1.Id=131;
Person p2=new Person(100,"Suyog",27);

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine("Hello,World!!");

var c1=new Complex(64,34);
var c2 = new Complex(12, 33);

var c3 = c1 + c2;
var c4 = c1 - c2;
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);
Console.WriteLine(c4);
Point po1 = new Point(34, 45);

Point po2 = new Point(77, 56);

Line l = new Line(po1,po2, 3, "dash", "red");
Shape shape = l;
shape.Draw();