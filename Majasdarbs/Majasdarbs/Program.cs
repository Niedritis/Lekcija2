// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string greeting = "Hello te Arnis";
int number = 10;
double decimalnumber = 15.5;
char symbol = '@';
bool answer = true;

int num1 = 5;
int num2 = 2;
int sum = num1 + num2;
double divide = num1 / num2;
double convertedNum2 = (double)num2;
int leftafter = num1 % num2;
int bums = num1 % num2;

Console.WriteLine(greeting);
Console.WriteLine(number);
Console.WriteLine(decimalnumber);
Console.WriteLine(symbol);
Console.WriteLine(answer);
Console.WriteLine(sum);
Console.WriteLine(divide);
Console.WriteLine(leftafter);


Console.WriteLine();
Console.WriteLine("=====================");
Console.WriteLine();

int num3 = 4;
int num4 = 9;

bool isequal = num3 == num4;
bool isNotequal = num3 != num4;
bool islarger = num3 > num4;
bool islargerequal = num3 >= num4;
bool issmalerequal = num3 <= num4;


Console.WriteLine(isNotequal);
Console.WriteLine(isequal);
Console.WriteLine(isequal);
Console.WriteLine(isequal);
Console.WriteLine(isequal);


Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();


bool isTrue = true;
bool isFalse = false;

bool isBoth = isTrue && isFalse;
bool isEither1 = isTrue || isFalse;
bool Converted = !isFalse;


Console.WriteLine(isBoth);
Console.WriteLine(isEither1);
Console.WriteLine(Converted);


Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();


int num5 = 5;


num5 += 2;

Console.WriteLine(num5);

num5 -= 2;



Console.WriteLine(num5);

Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();

//// 1. pajautāt lietotāja ievadit vārdu
//Console.WriteLine("Ievadi savu vārdu!");

//// 2. sagaidīt  ievadi

//string userName = Console.ReadLine();


////sasveicināties ar lietotāju

//string UserGreeting = "Sveiks " + userName + "!";
//Console.WriteLine(UserGreeting);


// 1. pajautāt lietotāja ievadit skaitli
// sagaidīt ievadi
// formatētā tekstā izvadīt skaitli +2


//Console.WriteLine("Ievadi savu skaitli!");
//string userNumberText = Console.ReadLine();
//int userNumber = int.Parse(userNumberText);
//int result = userNumber + 2;
//Console.WriteLine("Tavs skaitlis palielinats par 2 =   " + result);

int x = 4;
int y = 5;
int absolutnum = Math.Abs(x);
int Largest = Math.Max(x, y);
int smallest = Math.Min(x, y);
double apalot = 45.856;
double rounded = Math.Round(apalot);
double rounded2 = Math.Round(apalot, 2);

//Console.WriteLine(absolutnum);

Console.WriteLine(Largest);
Console.WriteLine(smallest);
Console.WriteLine(rounded);
Console.WriteLine(rounded2);

Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();

string name = "Arnis";
int age = 49;
Console.WriteLine("Sveiks " + name + "sveiciens tavos " + age + "!");
Console.WriteLine($"Sveiks {name}sveiciens tavos {age}!");



