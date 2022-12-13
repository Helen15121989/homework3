//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

// √ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2


Console.WriteLine("Введите координаты точек X1, Y1, Z1");

int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точек X2, Y2, Z2");
int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());
int Z2 = int.Parse(Console.ReadLine());


double Сoordinates = GetDistanceBetweenPoints (X1, Y1, X2, Y2, Z1, Z2);


 
 double GetDistanceBetweenPoints (int X1, int Y1, int Z1, int X2, int Y2, int Z2)

{
    double decision = (((X2 -X1)+ (X2 -X1)) + ((Y2 -Y1) +(Y2 -Y1)) + ((Z2 -Z1) + (Z2 -Z1)));

    double result = Math.Sqrt ((double) decision);
    Console.WriteLine (result);
    return (result);
}







