/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
Console.Clear();

Console.Write("Каким количеством чисел вы хотите себя помучать? Введите: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] resultArray = new int[m];
int count = 0; // Счетчик положительных чисел.

for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите {i+1}-е число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    resultArray[i] = a;
    if (a > 0) count++;
}

Console.WriteLine("У вас получается вот такой массив: ");
Console.WriteLine($"[{String.Join(";", resultArray)}]");
Console.WriteLine();
Console.WriteLine($"В нем есть {count} числа(-ел), которые больше 0. The END.");
*/






/*
Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. 
Значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
double PointX(int arg1, int arg11, int arg2, int arg22)
{
    double pointX;
    pointX = (arg2 - arg1) / (double)(arg11 - arg22); // Использовал приведение типа данных.
    return pointX;
}

Console.Clear();

Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = PointX(b1, k1, b2, k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых: x = {x}, y = {y}");
*/






/*
Задача 43 (ДОП, по желанию, на 5 нужно сделать 2 задачки): Напишите программу, которая будет 
преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

//Вариант 1. Читерское решение. 

/*
Console.Clear();

Console.WriteLine("Введите число в десятичной системе счисления: ");
int decNumber = Convert.ToInt32(Console.ReadLine());

string binNumber = Convert.ToString(decNumber, 2);
Console.WriteLine($"Число {decNumber} в двоичной системе счисления: {binNumber}");
*/



/*
Вариант 2. Математическое решение. Вывод в массив.
*/

/*
int[] DecimalToBinary(int arg) // Метод, возвращающий массив, совокупность элементов которого отображает десят-ное число в двоичной системе.
{
    int stepen = Convert.ToInt32(Math.Floor(Math.Log(arg, 2))); // Логарифм arg по основ 2 и окргуление его до наибольшего
                                                               // целого числа, которое меньше или равно указанному числу.
    
    int size = stepen + 1; // Ввел доп переменную size для простоты восприятия в массиве и цикле for.
                          // stepen + 1 - столько цифр должно быть в двоичном числе, следов-но и в массиве.

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        int exponentiation = Convert.ToInt32(Math.Pow(2, stepen)); // Вычислим значение 2 в степени stepen.
        if (exponentiation <= arg) // Если усл вып-ся, то i-тый элемент массива = 1, иначе = 0.
        {
            array[i] = 1;
            arg = arg - exponentiation;
        }
        else array[i] = 0;
        stepen--;
    }
    return array;
}

Console.Clear();

Console.Write("Введите число в десятичной системе счисления: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] resultArray = DecimalToBinary(number);
Console.Write($"Число {number} в двочной системе выглядит так: {String.Join("", resultArray)}");
*/




//Вариант 3. Через деления.


int[] DecimalToBinary(int arg) // Метод, возвращающий массив, совокупность элементов которого отображает десят-ное число в двоичной системе.
{
    int stepen = Convert.ToInt32(Math.Floor(Math.Log(arg, 2))); // Логарифм arg по основ 2 и окргуление его до наибольшего
                                                                // целого числа, которое меньше или равно указанному числу.

    int size = stepen + 1; // Ввел доп переменную size для простоты восприятия в массиве и цикле for.
                           // stepen + 1 - столько цифр должно быть в двоичном числе, следов-но и в массиве.

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[size - 1 - i] = arg % 2;
        arg = arg / 2;
    }
    return array;
}

Console.Clear();

Console.Write("Введите число в десятичной системе счисления: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] resultArray = DecimalToBinary(number);
Console.Write($"Число {number} в двочной системе выглядит так: {String.Join("", resultArray)}");
