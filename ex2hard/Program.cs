// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, 
// найти максимальное число и его индекс. Вывести эту информацию на экран.

int[,] fillAndPrintMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();    
    }
    return matrix;
}

int[] FindMinMax(int[,] array)
{
    int[] result = new int[6];
    result[0] = array[0, 0]; //максимальный элемент
    result[1] = 0; //номер строки максимального элемента
    result[2] = 0; //номер столбца максимального элемента
    result[3] = array[0, 0]; //минимальный элемент
    result[4] = 0; //номер строки минимального элемента
    result[5] = 0; //номер столбца минимального элемента
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > result[0])
            {
                result[0] = array[i, j];
                result[1] = i;
                result[2] = j;
            }
            else if (array[i, j] < result[3])
                 {
                    result[3] = array[i, j];
                    result[4] = i;
                    result[5] = j;
                 }
        }    
    }
    return result;
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[] ArrayInfo = FindMinMax(fillAndPrintMatrix(m, n));

Console.WriteLine($"Максимальный элемент массива {ArrayInfo[0]}");
Console.WriteLine($"Номер строки максимального элемента массива {ArrayInfo[1]}");
Console.WriteLine($"Номер столбца максимального элемента массива {ArrayInfo[2]}");
Console.WriteLine($"Манимальный элемент массива {ArrayInfo[3]}");
Console.WriteLine($"Номер строки минимального элемента массива {ArrayInfo[4]}");
Console.WriteLine($"Номер столбца минимального элемента массива {ArrayInfo[5]}");
