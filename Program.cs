// Домашняя работа 4
/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.*/
/*
Console.Clear();
double PowerOfNumber(double A, double B)
{
    int count=0;
    double proiz=1;
    if (B>=0)
    {
        while (count <B)
        {
            proiz = proiz * A;
            count++;
        }
    }
    else
    {
         while (count >B)
        {
            proiz = proiz * (1/ A);
            count--;
        }
    }
    return Math.Round(proiz,4);
}
Console.WriteLine("Input basis of the degree");
double A=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input degree indicator");
double B=Convert.ToDouble(Console.ReadLine());
double result = PowerOfNumber(A,B);
Console.WriteLine($"Number {A} in the {B} is {result}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Clear();
int SumOfDigits(int num)
{
    int sum=0;
    while (num!=0)
    {
        sum+=num%10;
        num/=10;
    }
    return sum;
}
Console.WriteLine("Input a number ");
int num=Convert.ToInt32(Console.ReadLine());
int result = SumOfDigits(num);
Console.WriteLine($"The sum of the digits of the {num} is {result} .");
*/
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
Console.Clear();
int [] CreatArray(int size)
{
    int [] array=new int [size];
    for (int i=0; i<size; i++)
    {
        Console.Write($"Input a Array[{i+1}] = ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int [] array)
{
    Console.Write("[");
    for (int i=0; i<array.Length; i++)
        if (i==array.Length-1)
            Console.Write(array[i] +"" );
        else Console.Write(array[i] +", " );
    Console.Write("]");
}
Console.Write("Input a size array");
int size =Convert.ToInt32(Console.ReadLine());
int [] array = CreatArray(size);
ShowArray(array);
*/
