using System;

namespace Lab_1;
public class Rectangle
{ 
    private double x1, y1, x2, y2;

    public Rectangle(double x1, double y1, double x2, double y2)
    {
        this.x1 = Math.Min(x1, x2);
        this.y1 = Math.Min(y1, y2);
        this.x2 = Math.Max(x1, x2);
        this.y2 = Math.Max(y1, y2);

    }
    private double Width() => x2 - x1;
    private double Height() => y2 - y1;

    public double Area() => Width() * Height();
    public double Perimeter() => 2 * (Width() + Height());

    public string GetInfo()
    {
        return $"Прямокутник: Вершини ({x1}, {y1}), ({x2}, {y2})\n" +
              $"Ширина: {Width()}, Висота: {Height()}\n" +
              $"Площа: {Area()}, Периметр: {Perimeter()}";
    }
}