// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["Hello", "2", "world", ";-)"] -> ["2", ";-)"]
// ["1234", "1567", "-2", "computer sciense"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
 
Console.Write("array size = ");
int arraySize = Int32.Parse(Console.ReadLine());
if (arraySize <= 0)
{
    Console.WriteLine("Error. The value of array size is incorrect.");
    return;
}
string[] firstArray = new string[arraySize];
Console.WriteLine("Enter array:");
for (int i = 0; i < firstArray.Length; i++)
{
    Console.Write("string [{0}] = ", i);
    firstArray[i] = Console.ReadLine();
}

string[] secondArray;
secondArray = new string[arraySize];
int j = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    int length = firstArray[i].Length;
    if (length <= 3)
    {
        secondArray[j] = firstArray[i];
        j++;
    }
}
for (int i = 0; i < secondArray.Length; i++)
{
    Console.Write($"{secondArray[i]}  ");
}
Console.WriteLine();