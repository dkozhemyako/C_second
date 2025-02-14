using System;

namespace Lab_1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть координати чотирьох вершин прямокутника:");

        Console.Write("x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("x3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y3: ");
        double y3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("x4: ");
        double x4 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y4: ");
        double y4 = Convert.ToDouble(Console.ReadLine());

        Rectangle rect = new Rectangle(x1, y1, x2, y2, x3, y3, x4, y4);

        Console.WriteLine("\nІнформація про прямокутник:");
        Console.WriteLine(rect.GetInfo());
    }
}
