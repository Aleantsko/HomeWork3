// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Clear();
// Console.WriteLine("Введите пятизначное число:");

// string? number = Console.ReadLine();
// if (number.Length == 5)
// {
//     for (int i = 0; i < 2; i++)
//     {
//         if (number[i] == number[number.Length - ++i])
//         {
//             if (i == 1)
//             {
//                 Console.WriteLine("Да");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Нет");
//             break;
//         }
//     }
// }
// else
// {
//     Console.WriteLine("Нужно пятизначное число!!!");
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// System.Console.WriteLine("Введите координаты первой точки:");
// int[] a = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
// System.Console.WriteLine("Введите координаты второй точки:");
// int[] b = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
// System.Console.Clear();
// System.Console.Write("Расстояние между точками ");
// System.Console.Write("A (" + String.Join(", ", a) + ")");
// System.Console.Write(" и ");
// System.Console.Write("B (" + String.Join(", ", b) + ")");
// System.Console.Write(" равно ");
// System.Console.Write(Math.Round(Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + Math.Pow(a[2] - b[2], 2)), 2));

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 1; i <= n; i++)
{
    a[i - 1] = (int)Math.Pow(i, 3);
}
System.Console.WriteLine("Ответ: " + String.Join(", ", a));