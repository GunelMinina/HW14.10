// Задача 64: Задайте значения N и M. Напишите программу, 
// которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N, которое больше M");
int N = int.Parse(Console.ReadLine());

PrintNum(M, N);

void PrintNum(int from, int to){
    if(from % 2 == 0){
        Console.Write(from + " ");
    }
    if(from != to){
        from++;
    PrintNum(from, to);
    }
}