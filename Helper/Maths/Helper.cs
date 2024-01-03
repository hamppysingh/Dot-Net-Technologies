using Mathematics;

namespace Handlers;
public static partial class Helper{
    public static  void DisplayNames(params string[]  names){ 
        foreach(string s in names){
            Console.WriteLine(s);
        }
    }
    public  static void Swap(ref int num1, ref  int num2){
        int temp=num1;
        num1=num2;
        num2=temp;
    }
    public static  void Calculate(int radius, out float area, out float circumference){
        const float PI=3.14f;
        area=PI* radius*radius;
        circumference=2* PI * radius;
    }


    public static int Multiplication(this MathEngine m,int op1, int op2){
        return op1*op2;
    }

    public static int Division(this MathEngine m, int op1, int op2){
        return op1/op2;
    }
}