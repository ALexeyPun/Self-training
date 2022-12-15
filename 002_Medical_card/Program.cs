Console.Write("Введите имя: ");
string nameUser = Console.ReadLine();

Console.Write("Ведите фамилию: ");
string surnameUser = Console.ReadLine();

Console.Write("Введите возраст: ");
int age = Int32.Parse(Console.ReadLine());

Console.Write("Введите вес: ");
int weight = Int32.Parse(Console.ReadLine());

Console.Write("Введите пол <муж> или <жен>: ");
string genderEnter = Console.ReadLine();
bool gender = false;
if(genderEnter == "муж") gender = true;

