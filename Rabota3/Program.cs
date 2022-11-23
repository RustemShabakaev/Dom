// 1.Напишите программу, которая принимает на вход координаты двух точек и 
// 2.находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты первой точки X1 и Y1 и Z2");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки X2 и Y2 и Z2");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double Quarter(double xa, double ya, double xb, double yb, double za, double zb)
{
    double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    return distance;
}

double square = Quarter(x1, y1, x2, y2, z1, z2);
double result = Math.Round(square, 2, MidpointRounding.ToZero);
Console.WriteLine(result);
