/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

//MaxNumber();
//MaxNumber2();
//EvenNumberOr();
EvenNumbers();

static void MaxNumber()
{
    int bullet = 1; // Точка входа/выхода из цикла
    while (bullet == 1)
    {
        Console.Write("Введите первое число: ---> ");
        int number_a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ---> ");
        int number_b = Convert.ToInt32(Console.ReadLine());

        if (number_a == number_b)
            {
                Console.WriteLine($"Первое число: ---> |{number_a}| равно второму числу ---> |{number_b}|");
            }
        else if (number_a > number_b)
            {
                Console.WriteLine($"Первое число: ---> |{number_a}| больше чем второе число ---> |{number_b}|");
            }
        else if (number_a < number_b)
            {
                Console.WriteLine($"Первое число: ---> |{number_a}| меньше чем второе число ---> |{number_b}|");
            }
        else
            {
                Console.WriteLine("Неверный ввод. Попробуйде ввести еще раз");
            }
         Console.WriteLine($"Завершить выполнение программы введите |{0}|, для продолжения введите |{1}|");
         bullet = Convert.ToInt32(Console.ReadLine()); 
    }

}

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

static void MaxNumber2()
{
    Console.Write("Введите первое число: ---> ");
    int number_a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ---> ");
    int number_b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ---> ");
    int number_c = Convert.ToInt32(Console.ReadLine());
    int maxNumber = number_a;

    if (maxNumber < number_b)
    {
        maxNumber = number_b;
    }
    if (maxNumber < number_c)
    {
        maxNumber = number_c;
    }
    Console.WriteLine($"Максимальное из трех чисел равно ---> {maxNumber}");
}

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

void EvenNumberOr()
{
    Console.Write("Введите число для проверки на чётность: ---> ");
    int number_a = Convert.ToInt32(Console.ReadLine());
    if ((number_a % 2) == 0)
    {
        Console.WriteLine($"Число {number_a} чётное, так как это число делится на число 2 без остатка");
    }
    else
    {
        Console.WriteLine($"Число {number_a} не чётное, так как это число не делится на число 2 без остатка");
    }
    
}

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

void EvenNumbers()
{
    Console.Write("Введите число для проверки на чётность от 1 до N: ---> ");
    int number_a = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    Console.Write($"Все чётные числа от ( 1 до {number_a} ) = ");
    while (count <= number_a)
    {
        if ((count % 2) == 0)
            {
                Console.Write($"[{count}] | ");
            }
        count++;

    }
}