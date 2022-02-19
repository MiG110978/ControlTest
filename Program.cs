// Программа из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символам.
void PrintArrayString(string[] array)
{
    foreach (var element in array)
    {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}

void FillingArrayString(String[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива - ");
        array[i] = Console.ReadLine();
    }
}

Console.WriteLine("Заполниет исходный массив со строковыми элементами");
Console.Write("Введите количество элементов исходного массива - ");
int size = int.Parse(Console.ReadLine());
string[] arrayString = new string[size];
FillingArrayString(arrayString);
Console.Write("Проверьте, вы ввели массив - \t \t");
PrintArrayString(arrayString);
string[] arrayStringNew = new string[0];
int sizeNew = 0;
foreach (var element in arrayString)
{
    if (element.Length <= 3)
    {
        Array.Resize(ref arrayStringNew, sizeNew + 1);
        arrayStringNew[sizeNew] = element;
        sizeNew++;
    }
}
Console.Write("Исходный массив был преобразован в \t");
PrintArrayString(arrayStringNew);