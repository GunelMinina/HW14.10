// Задача 68: Задайте значения M и N. Напишите программу, 
// которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

GetNod(M, N, M);

void GetNod(int Num1, int Num2, int Del){ // Функция поиска делителей
    if(Num1 % Del == 0 && Num2 % Del == 0){
    Console.WriteLine(Del);   
    return;     
    }
    Del--;
    GetNod(Num1, Num2, Del);
    return;
    }
    