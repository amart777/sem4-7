// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число  в натуральную степень B.
// 3, 5 -> 243 (3?)
// 2, 4 -> 16


// Console.WriteLine("Введите число А ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В ");
// int b = Convert.ToInt32(Console.ReadLine());
// Numbers (b);
// int d = 0;
// int Numbers(int b)
// {
//     int c = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         c = c * a;
//     }
//     return c;
// }
// d = Numbers(b);
// Console.WriteLine($"Число {a} в степени {b} = {d}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());

// void SumNumbers (int n)
// {
//     int a=0;   
//     while (n%10>0 || n>0)
//     {
//         a=a+n%10;
//         n/=10;
//     }

//     Console.WriteLine($"Сумма цифр в числе {a}");    
// }

// SumNumbers (n);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.


int[]array=new int[8];
void FillArray(int[]collection)
{
    int length = 8;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine("Введите элемент массива");
        int n=Convert.ToInt32(Console.ReadLine());
        collection[index]=n;
        index++;
    }
}
void PrintArray(int[]array)
{
    int count = 8;
    for (int i=0; i<count; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);