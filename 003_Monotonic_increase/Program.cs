int[] Distributor(int[] array, long number, int elements)
{
    byte temporary = 0;

    for (int i = 0; 10 < number; i++)
    {
        temporary = (byte)(number % 10);//явное преобразование в тип byte
        array[elements - i] = temporary;
        number /= 10;
        if (number < 10) array[elements - 1 - i] = (int)number;
    }
    return array;
}

string Bilder(int element)
{
    string str = "";
    str = Convert.ToString(element);
    return str;
}

// СТАРТ ПРОГРАММЫ ==================================================================>
// РЕШИЛ СДЕЛАТЬ НА ВХОД ОДНО БОЛЬШОЕ ЧИСЛО! ПЕРЕДЕЛАТЬ ПОД МАССИВ МОЖНО!
// РАБОТАТЬ ТОЖЕ БУДЕТ...  теоретически =)

System.Console.Write("Enter number: ");
string entrNumber = Console.ReadLine();

int amountElements = entrNumber.Length;
int[] array = new int[amountElements--];
long userNumber = long.Parse(entrNumber);//конвертирую строку в лонг
byte count = 0;
byte space = 0;
byte pointer = 0;
string stringBilder = "";


//вызов функции сортировки числа в массив
array = Distributor(array, userNumber, amountElements);

//первые 2 условия в FOR актуальны для последней итерации
for (int i = 0; i < amountElements; i++)
{
    //pointer - выясняет какая последняя итерация(возрастающая или убывающая)
    if (i == (amountElements - 1) && pointer == 0) break;        

    if (i == (amountElements - 1) && pointer == 1)
    {
        stringBilder = stringBilder + (Bilder(array[i]) + Bilder(array[i + 1]) + "; ");
        count++;
        break;
    }

    if (array[i] < array[i + 1])
    {
        //вызов функции присвоения нового элемента в переменную string
        stringBilder = stringBilder + Bilder(array[i]);
        pointer = 1;
    }
    else
    {
        if (pointer == 1)
        {
            pointer = 0; //чтобы не заходить 2-ой раз
            stringBilder = stringBilder + (Bilder(array[i]) + "; ");
            count++;
        }
        else space++; // мусорная итерация - ни на что не влияет, но можно написать что-то полезное
        
    }
}


System.Console.WriteLine($"Amount elements in number = {amountElements};");
System.Console.WriteLine("Ascending charts - " + stringBilder + "Ascending charts, quantity - " + count + ";");