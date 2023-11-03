//C#变量

//整数类型:sbyte, byte, short, ushort, int , uint, long, ulog, char
//浮点型：float, double
//十进制类型:decimal
//布尔类型:true false
//空类型:可为空值的数据类型

using System;
namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b;
            double c;

            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
}