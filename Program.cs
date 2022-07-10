/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

MaxNumber();

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