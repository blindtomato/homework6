//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] fillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            result++;
    }
    return result;
}

Console.WriteLine("Введите количество чисел");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = fillArray(length);
Console.WriteLine($"Количество положительных чисел {CountPositiveNumbers(numbers)}");