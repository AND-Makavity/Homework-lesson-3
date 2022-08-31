/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.WriteLine();
int Number = 12821;//new Random().Next(10000, 100000);
if (Number / 10000 == Number % 10)
{
    if (Number % 10000 / 1000 == Number % 100 / 10) Console.WriteLine($"Число {Number} является полиндромом");
    else Console.WriteLine($"Число {Number} не является полиндромом");
}
else Console.WriteLine($"Число {Number} не является полиндромом");
Console.WriteLine();


/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int[] A = { new Random().Next(-10, 10), new Random().Next(-10, 10) };
int[] B = { new Random().Next(-10, 10), new Random().Next(-10, 10) };

double DistanceAB(int[] a, int[] b)
{
    return Math.Sqrt(Math.Pow((a[0] - b[0]), 2) + Math.Pow((a[1] - b[1]), 2));
}
Console.WriteLine($"Точка А: {A[0]}, {A[1]}, \nТочка В:{B[0]}, {B[1]}");
Console.Write($"Расстояние между точками А и В равно {DistanceAB(A, B)}");
Console.WriteLine();

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void CubSquaresLine()
{
    Console.Write($"\nВведите число N: ");
    int.TryParse(Console.ReadLine(), out int N);
    for (int i = 1; i <= N; i++) Console.Write($"{i * i * i} ");
}

CubSquaresLine();