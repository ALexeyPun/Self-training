
// СТАРТ ПРОГРАММЫ
System.Console.Write("Enter number: ");
string entrNumber = Console.ReadLine();

int amountElements = entrNumber.Length;
int[] array = new int[amountElements--];
long userNumber = Convert.ToInt32(entrNumber);//конвертирую строку в лонг

byte temporary = 0;

for (int i = 0; 10 < userNumber; i++)
{
    temporary = (byte)(userNumber % 10);//явное преобразование в тип byte
    userNumber /= 10;
    array[amountElements - i] = temporary;
    
}


System.Console.WriteLine("Amount = " + string.Join(",", array));