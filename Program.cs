/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите элементы(через пробел): ");
int[] arrayN = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Array.convetAll - конвертирует Всё(Принимает тип данных Console.ReadLine().Split(), Выводит тип данных int.Parse)
int count = 0;

for (int i = 0; i < arrayN.Length; i++)
{
    if (arrayN[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(arrayN);
Console.WriteLine($"Вы ввели {count} чисела больше 0");
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double ConvertTextIsNumber(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    int output = Convert.ToInt32(input);
    return output;
}


double b1 = ConvertTextIsNumber("Введите координаты отрезка k1");
double k1 = ConvertTextIsNumber("Введите координаты отрезка b1");
double b2 = ConvertTextIsNumber("Введите координаты отрезка k1");
double k2 = ConvertTextIsNumber("Введите координаты отрезка b2");

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"точки пересечени по Х: {x}, по Y: {y}");