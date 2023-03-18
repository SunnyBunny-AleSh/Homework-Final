// Урок 9.Рекурсия (Итоговое домашнее задание)
//Задача 64. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Выполнить с помощью рекурсии.
int ReadInt()
{
    Console.WriteLine("input number");
    int a = int.Parse(Console.ReadLine());
    return a;
}
void PrintNumbers(int m, int n)
{
    if (m > n)
    {
        Console.Write(n + ", ");
        PrintNumbers(m, n + 1);
    }
    else
    {
        Console.WriteLine(n);
    }
}
PrintNumbers(ReadInt(), ReadInt());

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Задайте значение N:");
int a = int.Parse(Console.ReadLine());

PrintNumbers(a);
void PrintNumbers(int n)
{
    if (1 < n)
    {
        Console.Write(n + ", ");
        PrintNumbers(n - 1);
    }
    else
    {
        Console.WriteLine(n);
    }
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.Write("Задайте значение M (меньшее число):");
int a = int.Parse(Console.ReadLine());
Console.Write("Задайте значение N (большое число):");
int b = int.Parse(Console.ReadLine());
int sum = 0;
PrintNumbers(a, b);
void PrintNumbers(int m, int n)
{
    if (m <= n)
    {
        sum = sum + m;
        PrintNumbers(m + 1, n);
    }
}
Console.Write(sum);

*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int Akkerman = num(m, n);

Console.Write($"Функция Аккермана = {Akkerman} ");

int num(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return num(m - 1, 1);
    else return num(m - 1, num(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}