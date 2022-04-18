// See https://aka.ms/new-console-template for more information

Console.WriteLine("1.uzdevums");
Console.WriteLine();

Console.WriteLine("Kā Tevi sauc?");
string username = Console.ReadLine();
string usergreeting = "Sveiks " + username + "!";
Console.WriteLine(usergreeting);


Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine();
Console.WriteLine("2.uzdevums");
Console.WriteLine();

Console.WriteLine("Kāds ir Tavs vecums?");
string userage = Console.ReadLine();
int usernumber = int.Parse(userage);
int result = usernumber + 1;
Console.WriteLine("Nākamgad Tev paliks " + result);


Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine();
Console.WriteLine("3.uzdevums");
Console.WriteLine();

Console.WriteLine("Ievadi pirmo skaitli");
string number1 = Console.ReadLine();
int usernumber1 = int.Parse(number1);
Console.WriteLine("Ievadi otro skaitli");
string number2 = Console.ReadLine();
int usernumber2 = int.Parse(number2);
Console.WriteLine("Ievadi trešo skaitli");
string number3 = Console.ReadLine();
int usernumber3 = int.Parse(number3);
Console.WriteLine("Ievadi ceturto skaitli");
string number4 = Console.ReadLine();
int usernumber4 = int.Parse(number4);

int Largest1 = Math.Max(usernumber1, usernumber2);
int Largest2 = Math.Max(usernumber3, usernumber4);
int Largest3 = Math.Max(Largest1, Largest2);

Console.WriteLine("Lielākais skaitlis ir " + Largest3);


Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine();
Console.WriteLine("4.uzdevums");
Console.WriteLine();

Console.WriteLine("Ievadi pirmo skaitli");
string numberM1 = Console.ReadLine();
int usernumberM1 = int.Parse(numberM1);
Console.WriteLine("Ievadi otro skaitli");
string numberM2 = Console.ReadLine();
int usernumberM2 = int.Parse(numberM2);
Console.WriteLine("Ievadi trešo skaitli");
string numberM3 = Console.ReadLine();
int usernumberM3 = int.Parse(numberM3);
Console.WriteLine("Ievadi ceturto skaitli");
string numberM4 = Console.ReadLine();
int usernumberM4 = int.Parse(numberM4);

int SMALL1 = Math.Min(usernumberM1, usernumberM2);
int SMALL2 = Math.Min(usernumberM3, usernumberM4);
int SMALL3 = Math.Min(SMALL1, SMALL2);

Console.WriteLine("Mazākais skaitlis ir " + SMALL3);


Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine();
Console.WriteLine("5.uzdevums");
Console.WriteLine();


Console.WriteLine("Ievadi pirmo skaitli");
string number51 = Console.ReadLine();
int usernumber51 = int.Parse(number51);
Console.WriteLine("Ievadi otro skaitli");
string number52 = Console.ReadLine();
int usernumber52 = int.Parse(number52);
int leftafter = usernumber51 % usernumber52;
Console.WriteLine("Dalijuma atlikums ir " + leftafter);

Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine();
Console.WriteLine("6.uzdevums");
Console.WriteLine();


Console.WriteLine("Ievadi, lūdzu, skaitli");
int number56 = int.Parse(Console.ReadLine());
bool isEven = number56 % 2 == 0;
Console.WriteLine("Skaitlis ir pāra skaitlis " + isEven


Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine();
Console.WriteLine("7.uzdevums");


Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int Number71 = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int Number72 = int.Parse(Console.ReadLine());


int area = Number71 * Number72;
Console.WriteLine($"Taisnstūra laukums ir  {area}");


Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine();
Console.WriteLine("8.uzdevums");


Console.WriteLine("Lūdzu ievadi, taisnlenka trijstura malas garumu");
int Number75 = int.Parse(Console.ReadLine());

double area2 = Number75 * (double)Number75 / 2;
Console.WriteLine($"Taisnlenka trijstura laukums ir  {area2}");


Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine();
Console.WriteLine("9.uzdevums");
Console.WriteLine();


Console.WriteLine("Lūdzu ievadi savu vārdu");
string userName = Console.ReadLine();
Console.WriteLine("Lūdzu ievadi savu vecumu");
int userAge = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks {userName}, tavs vecums ir {userAge}.");

