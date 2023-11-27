// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {N} , M = {M} -> ");
if (M > N)
{
for (int i = N; i <= M; i++)
{
Console.Write($" {i}");
}
}
else
{
    for (int i = M; i <= N; i++)
    {
         Console.Write($" {i}");
     }
 }



// Console.WriteLine(PrintNumbers(1, N));


// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{sum(m,n)}");
// int sum(int m,int n)
// {
//     if (m == n) return n; 
// else 
// return m + sum(m+1,n);
// }


// // // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // // M = 1; N = 15 -> 120
// // // M = 4; N = 8. -> 30

Console.Write("Введите N: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {m} ; M = {n} -> {sum(m,n)} ");
int sum(int m,int n)
{
    if (m == n) return n; 
else 
return m + sum(m+1,n);
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0)
{
 return akkerman(m - 1, 1);
} 
else
{
 return akkerman(m - 1, akkerman(m, n - 1));
 }
}

Console.Write($"A(m,n) = {akkerman(m, n)} ");