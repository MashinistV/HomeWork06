//Задача 41. Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Задача 43. Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
bool isWork = true;

while(isWork)
{
    Console.Write("Выберите задачу 1 или 2: ");

    if (int.TryParse(Console.ReadLine(), out int j))
    {
        switch (j)
        {
            case 1:
            {
                int[] PrintArray(int[] array, int length)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
    return array;
}

                int Quantity(int[] array, int length)
{
    int quantity = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            quantity++;
        }
    }

    return quantity;
}

                string input;
                int[] numbers = new int[99];
                int i = 0;
                Console.WriteLine("Введите числа. Для окончания ввода наберите 'q'");

                while ((input = Console.ReadLine()) != "q")
                {
                    numbers[i] = Convert.ToInt32(input);
                    i++;
                }

                Console.WriteLine("Набранные числа:");
                PrintArray(numbers, i);
                Console.WriteLine($"Количество чисел больше нуля: {Quantity(numbers, i)}");
                break;
            }

            case 2:
            {
                int CheckNumber(string text)
                {
                    Console.Write(text);
                    int number;

                    while (!int.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Вы ввели не число");
                        Console.Write("Введите число: ");
                    }

                return number;
                }

                float k1 = CheckNumber("Введите коэффициент k1 первой прямой: ");
                float b1 = CheckNumber("Введите координату пересечения с осью b1 первой прямой: ");
                float k2 = CheckNumber("Введите коэффициент k2 второй прямой: ");
                float b2 = CheckNumber("Введите координату пересечения с осью b2 второй прямой: ");
                float x;
                float y;
                x = ((b2 - b1) / (k1 - k2));
                y = k1 * x + b1;
                Console.WriteLine($"Точка пересечения двух прямых имеет координаты: x = {x}, y = {y}");
                break;
            }

            case -1: isWork = false; break;
        }
    }
}
