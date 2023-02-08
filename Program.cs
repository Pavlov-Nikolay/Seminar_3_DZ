// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



System.Console.WriteLine("Введите пятизначное число");

int.TryParse(Console.ReadLine(), out int number); // Ввели пятизначное число и присвоили его переменной number.

int firstNumber = number;

int[] arrayPolindrom = new int[5]; // Организовали массив для полиндрома.

int count = arrayPolindrom.Length; // Присвоили счетчику начальное значение равное длине массива arrayPolindrom.

for (count = arrayPolindrom.Length; count > 0; count--)
{
    int i = 10;
    arrayPolindrom[count-1] = number % i; //Получили остаток от деления который занесли в массив
    number = (number - arrayPolindrom[count-1])/10;
    i = i * 10; // Увеличение счетчика для получения остатка от деления
}

if (arrayPolindrom[0] == arrayPolindrom[4] && arrayPolindrom[1] == arrayPolindrom[3])
{
    System.Console.WriteLine($"Число {firstNumber} является полиндромным.");
}
else
{
    System.Console.WriteLine($"Число {firstNumber} не является полиндромным.");
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

System.Console.WriteLine("Введите координату Х1");
int.TryParse(Console.ReadLine(), out int x1);

System.Console.WriteLine("Введите координату Y1");
int.TryParse(Console.ReadLine(), out int y1);

System.Console.WriteLine("Введите координату Z1");
int.TryParse(Console.ReadLine(), out int z1);

System.Console.WriteLine("Введите координату Х2");
int.TryParse(Console.ReadLine(), out int x2);

System.Console.WriteLine("Введите координату Y2");
int.TryParse(Console.ReadLine(), out int y2);

System.Console.WriteLine("Введите координату Z2");
int.TryParse(Console.ReadLine(), out int z2);

System.Console.WriteLine("Расстояние между точками равно " +  Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

System.Console.WriteLine("Введите число N");

int.TryParse(Console.ReadLine(), out int a);

int b = 1;

while (b <= a)
{
    System.Console.WriteLine(Math.Pow(b, 3));
    b++;
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////