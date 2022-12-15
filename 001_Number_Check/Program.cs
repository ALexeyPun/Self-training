Console.Write("Введите число: ");

int userNumber = Int32.Parse(Console.ReadLine());
int result = 0;

if (userNumber < 0) Console.WriteLine("Число ниже 0!");
else if (userNumber > 10) Console.WriteLine("Число выше 10!");
else
{
    result += userNumber * userNumber;
    Console.Write("Квадрат числа " + userNumber + " равен " + result + "!");
}


