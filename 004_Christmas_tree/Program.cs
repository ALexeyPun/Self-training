Console.Clear();

System.Console.WriteLine("Christmas tree!");
System.Console.WriteLine();

System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int [] array = new int [number];

byte size = (byte)number;
byte arrayCenter = (byte)((number - number / 2) - 1);

array[arrayCenter] = 1;

Console.ForegroundColor = ConsoleColor.DarkGreen;
System.Console.WriteLine();
System.Console.WriteLine();


for(byte i = 0; i <= arrayCenter; i++)
{
    for(byte b = 0; b < number; b++)
    {
        if(array[b] == 0)
            System.Console.Write(" ");
        else
            System.Console.Write("#");    
    }

    System.Console.WriteLine();

    if(i == arrayCenter) break;

    array[arrayCenter + (1 + i)] = 1;
    array[arrayCenter - (1 + i)] = 1;
}


System.Console.WriteLine();

for(int i = 0; i < size; i++) 
{
    System.Console.Write("_");
}
Console.ResetColor();

