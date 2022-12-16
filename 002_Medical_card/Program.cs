Console.Clear();

Console.Write("Введите имя: ");
string nameUser = Console.ReadLine();

Console.Write("Ведите фамилию: ");
string surnameUser = Console.ReadLine();

Console.Write("Введите возраст: ");
int age = Int32.Parse(Console.ReadLine());

Console.Write("Введите вес: ");
int weight = Int32.Parse(Console.ReadLine());

bool smallAge = age < 30;
bool averageAge = age > 30 && age < 40;
bool greatAge = age > 40;

bool littleWeight = weight < 90;
bool averageWeight =  weight > 90 && weight < 120;
bool bigWeight = weight > 120;



if(smallAge & littleWeight)System.Console.WriteLine("С пациентом, " + nameUser + " " + surnameUser + ", всё в порядке!");
if(smallAge & averageWeight)System.Console.WriteLine("Пациенту , " + nameUser + " " + surnameUser + ", следует сбросить вес!");
if(smallAge & bigWeight)System.Console.WriteLine("Пациенту, " + nameUser + " " + surnameUser + ", срочно нужно худеть!");

if(averageAge & littleWeight)System.Console.WriteLine("Пациенту, " + nameUser + " " + surnameUser + ", возможно, следует набрать вес!");
if(averageAge & averageWeight)System.Console.WriteLine("С пациентом , " + nameUser + " " + surnameUser + ", всё хорошо, но за здоровьем надо следить!");
if(averageAge & bigWeight)System.Console.WriteLine("Пациенту, " + nameUser + " " + surnameUser + ", нужно худеть, иначе, возможны осложнения!");

if(greatAge & littleWeight)System.Console.WriteLine("Пациент, " + nameUser + " " + surnameUser + "! В вашем возросте - это нормально!");
if(greatAge & averageWeight)System.Console.WriteLine("С пациентом , " + nameUser + " " + surnameUser + ", всё хорошо, но за здоровьем надо следить. Тем более в приклонном возрасте!");
if(greatAge & bigWeight)System.Console.WriteLine("Пациенту, " + nameUser + " " + surnameUser + ", нужно пить таблетки от похудения, иначе, ноги сломаются!");
