//Declare Variables
//Value types :

//primitive types:
//int, float, char, boolean ,double, byte,
//struct, enum

//Refernce types
//class
//interface
//delegate
//event

// class
// concrete class 
// abstract class

using Handlers;
using Mathematics;

using HR;

MathEngine mi=new MathEngine();
int result=mi.Addition(45,45);
int result2=mi.Subraction(45,45);
int result3=mi.Multiplication(45,3);
int result4=mi.Division(16,2);

Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);
Console.WriteLine(result4);

Manager mgr=new Manager(5000,1000,10000);
Employee emp=mgr;
float salary=emp.ComputePay();

Console.WriteLine("Salary= "+ salary);
