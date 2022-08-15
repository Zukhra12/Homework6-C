/* TASK1 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    Console.Write("Quantity of numbers you want to enter: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int num = 0;
    int count = 0;
    for(int i=0; i<n; i++)
    {   
        Console.Write("Enter number:  ");
        int c = Convert.ToInt32(Console.ReadLine());
        num = c;
        if (num > 0)  count++;
    }    
    Console.WriteLine($"Quantity number greater than zero: {count} "); */ 

/* TASK1 
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;

Console.Write($"The intersection point of two straight lines is equal to ({x};{y}) ");*/