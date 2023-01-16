int GetNumber (string message)
{
    System.Console.Write(message);
    int userNumber = int.Parse(Console.ReadLine());
    System.Console.WriteLine();
    return userNumber;
}

int [] CreateArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array [i] = rnd.Next(minValue, maxValue);
    }

    return array;
}

int CountNegativeElement (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

int SumNegativeElements (int [] array, int size )
{
    int sum = 0;

    for (int i = 1; i < size; i++)
    {
        if(i % 2 == 1)
            sum += array [i];
    }
    return sum;
}

int GapBetweenValues (int [] array)
{
    int max = array.Max();
    int min = array.Min();

    int gap = max - min;
    return gap;
}

// 1 - Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
System.Console.WriteLine("Alexey Pan'shin homework!");
System.Console.WriteLine();
System.Console.WriteLine("Задайте массив и напишите программу, которая покажет количество чётных чисел в массиве.");
System.Console.WriteLine();

int size = GetNumber("Введите размер массива: ");
int minValue = GetNumber("Введите минимальное значение: ");
int maxValue = GetNumber("Введите максимальное значение: ");

int [] array = CreateArray(size, minValue, maxValue);

System.Console.WriteLine("[ " + string.Join(", ", array) + " ]");
System.Console.WriteLine();

int count = CountNegativeElement(array);

System.Console.WriteLine($"Колличество = {count}");
Console.ReadKey();


// 2 - Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
System.Console.WriteLine("Найдите сумму элементов, стоящих на нечётных позициях.");
System.Console.WriteLine();

size = GetNumber("Введите размер массива: ");
minValue = GetNumber("Введите минимальное значение: ");
maxValue = GetNumber("Введите максимальное значение: ");

array = CreateArray(size, minValue, maxValue);

System.Console.WriteLine("[ " + string.Join(", ", array) + " ]");
System.Console.WriteLine();

int sum = SumNegativeElements(array, size);

System.Console.WriteLine();
System.Console.WriteLine("Сумма = " + sum);
Console.ReadKey();


// 3 - Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
System.Console.WriteLine("Найдите разницу между максимальным и минимальным элементами массива.");
System.Console.WriteLine();

size = GetNumber("Введите размер массива: ");
minValue = GetNumber("Введите минимальное значение: ");
maxValue = GetNumber("Введите максимальное значение: ");

array = CreateArray(size, minValue, maxValue);

System.Console.WriteLine("[ " + string.Join(", ", array) + " ]");
System.Console.WriteLine();

int gapValues = GapBetweenValues(array);

System.Console.WriteLine("Разница между значениями = " + gapValues);