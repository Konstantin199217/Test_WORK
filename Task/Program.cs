// **Задача**: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// **Пример**
// ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer scince"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


Console.WriteLine("Введите ваш массив: ");
string[] Array = Console.ReadLine().Split();
string[] NewArray = new string[Array.Length];
int word = 0;
for (int i = 0; i < Array.Count(); i++)
{ 
    if (Array[i].Length <= 3)
    {
        NewArray[word] = Array[i];
        word++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Изначальный массив: ");
PrintArray(Array);
Console.WriteLine("Редоктированный массив: ");
PrintArray(NewArray);

