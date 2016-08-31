using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class Calculator
{
    public static int addInt(int a, int b)
    {
        return a + b;
    }
    public static float addFloat(float a, float b)
    {
        return a + b;
    }
    public static int subInt(int a, int b)
    {
        return a - b;
    }
    public static float subFloat(float a, float b)
    {
        return a - b;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("2 + 5 = " + Calculator.addInt(2, 5));
        Console.WriteLine("2.5 + 5.5 = " + Calculator.addFloat(2.5f, 5.5f));
        Console.WriteLine("5 - 2 = " + Calculator.subInt(5, 2));
        Console.WriteLine("5.2 - 2.5 = " + Calculator.subFloat(5.2f, 2.5f));
    }

}


