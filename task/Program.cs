// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = { "Russia", "Denmark", "Kazan"};
int num = 3;

int[] StringArrayLengths(string[] array)
{
    int[] arrayLengths = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayLengths[i] = array[i].Length;
    }
    return arrayLengths;
}

int ArrayCutLength(string[] array, int cutNum)
{
    int[] arrayLengths = StringArrayLengths(array);
    int count = 0; // Переменная для подсчета количества строк, удовлетворяющих условию
    for (int i = 0; i < array.Length; i++)
    {
        if (arrayLengths[i] <= cutNum)
        {
            count++; // Увеличиваем счетчик
        }
    }
    return count;
}
void ArrayCut(string[] array, int cutNum)
{
    int[] arrayLengths = StringArrayLengths(array);
    string[] cuttedArray = new string[ArrayCutLength(array, num)];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (arrayLengths[i] <= cutNum)
        {
            cuttedArray[index] = array[i];
            index++;
        }
    }
    Console.WriteLine($"[{string.Join(", ", array)}] => [{string.Join(", ", cuttedArray)}]");
}

ArrayCut(array, num);