using System; // дз урок 4 Функции


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int raiseToAPower()
{
    int number;
    int pow;
    int Sum = 1;
    
    while (true)
    {  
        System.Console.WriteLine("Функция возведения в степень"+'\n'+"Введите число: " );
        string numberString = Console.ReadLine();
        bool isNumber = int.TryParse(numberString, out number);
        if(isNumber)
        break;
        else
        System.Console.WriteLine("Ошибка ввода, попробуйте заново!"+'\n');
    }
    while (true)
    {
        System.Console.WriteLine("На какую степень возвести: ");
        string powString = Console.ReadLine();
        bool isPow = int.TryParse(powString, out pow);
        if(isPow)
        break;
        else
        System.Console.WriteLine("Ошибка ввода, попробуйте заново!"+'\n');
    
    }
        
    for(int i = 0; i < pow; i++)   
    {
        Sum = Sum * number;
    } 

    return Sum;

}
System.Console.WriteLine(raiseToAPower());








// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumOfNumbers(int number)
{
   
     
    int sum = 0;
    int result = 0;
    while(number > 0)
    {
        sum = number % 10;
        number /= 10;
        result += sum;
    }
    return result;
}


// System.Console.WriteLine(sumOfNumbers(0567890));






// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] GetArray(int size)
{
    
    int[] array = new int[size];
    
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(10, 101); 
        
    }
    return array;
}

int[] result = GetArray(8); 
// Console.WriteLine($"[{String.Join("; ", result)}]");