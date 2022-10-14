/// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*

double Degree(double x, double y)
{
    double result = Math.Pow(x, y);
    
    return result;
}

Console.WriteLine("input first number: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input second number: ");
double y = Convert.ToDouble(Console.ReadLine());

double degree = Degree(x, y);
Console.WriteLine ($"Число в {x} в степени {y} равно {degree}");

*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int n)
{
   int s = 0;
   
   while(n > 0)
    { 
        s = s + n % 10;
        n = n/10;
        
    }
    return s;
    
}

Console.WriteLine("input positive number: ");
int n = Convert.ToInt32(Console.ReadLine());
int s = Sum(n);

Console.WriteLine($"Сумма цифр в числе равна {s}");
*/

/// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


int [] CreateArray(int size) /// Массив
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(size);

    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

}

Console.Write("input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);


