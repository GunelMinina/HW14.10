// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N, которое больше M");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(PrintSum(M, N, 0));

int PrintSum(int from, int to, int Sum){
    Sum += from;
    if(from != to){
        from++;
    return PrintSum(from, to, Sum);
    }

    return Sum;
}