// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Решим задачу с применением массива длиной М, значение
// которой запрашиваем у пользователя.
// Длина массива есть натуральное число от 1 до +бесконечности.

bool IsNatural(int number)
{
    // Метод определяет, является ли число number натуральным.
    if (number >= 1) return true;
    else return false;
}

int LengthInput()
{
    // Метод пользовательского ввода количества анализируемых чисел.
    Console.Write("Введите количество чисел: ");
    int result = int.Parse(Console.ReadLine());
    while (!IsNatural(result))
    {
        Console.Write("Для сравнения должно быть по меньшей мере одно число. Повторите ввод: ");
        result = int.Parse(Console.ReadLine());
    }
    return result;
}

void FillArray(int[] array)
{
    // Метод заполняет массив array.
    Console.WriteLine($"Введите {array.Length} чисел:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i + 1}) ");
        array[i] = int.Parse(Console.ReadLine());
    }
}

int GetNumOfNumsMoreThanZero(int[] array)
{
    // Метод подсчитывает количество элементов массива
    // больших нуля.
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) result++;
    return result;
}

int[] arrOfNums = new int[LengthInput()];
FillArray(arrOfNums);
int numOfNumsMoreThanZero = GetNumOfNumsMoreThanZero(arrOfNums);
Console.WriteLine($"Количество чисел больше нуля равно {numOfNumsMoreThanZero}");