// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void PrintArray(string[]array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(array[position] + "; ");
        position++;
    }
}

string[] array = {"Hello", "2", "world", "1234", "1567", "-2", "computer science", "Russia",
"Denmark", "Kazan", ":-)"};  

Console.WriteLine("Изначальный массив: ");
PrintArray(array);
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++) // в этом цикле считаем сколько элементов подходит под наши условия
{
    if (array[i].Length <= 3)
    {
        //Console.WriteLine(array[i]); // проверял правильность работы выборки.
        count++; 
    }
}

string [] arrayNew = new string [count]; // создаём новый массив с нужной длиной

int count2 = 0;
for (int i = 0; i < array.Length; i++) // в этом цикле заполняем новый массив нужными значениями
{
    if (array[i].Length <= 3)
    {
        arrayNew[count2] = array[i];
        count2++; 
    }
}
Console.WriteLine("Новый массив: ");
PrintArray(arrayNew);
Console.WriteLine();
