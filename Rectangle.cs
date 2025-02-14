using System;

namespace Lab_1;
public class Rectangle
{
    private double x1, y1, x2, y2, x3, y3, x4, y4;

    public Rectangle(double x1, double y1, double x2, double y2,
                     double x3, double y3, double x4, double y4)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
        this.x4 = x4;
        this.y4 = y4;
    }

    private double Distance(double x1, double y1, double x2, double y2) =>
        Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    private double Width() => Distance(x1, y1, x2, y2);
    private double Height() => Distance(x2, y2, x3, y3);

    public double Area() => Width() * Height();
    public double Perimeter() => 2 * (Width() + Height());

    public string GetInfo()
    {
        return $"Прямокутник: Вершини ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3}), ({x4}, {y4})\n" +
              $"Ширина: {Width()}, Висота: {Height()}\n" +
              $"Площа: {Area()}, Периметр: {Perimeter()}";
    }
}
