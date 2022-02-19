﻿// Программа из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символам.
void PrintArrayString(string[] array)
{
    foreach (var element in array)
    {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}

string[] arrayString = { "123", "0457", ":-)", "мир", "0", "world" };
PrintArrayString(arrayString);
int size = arrayString.Length;
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
PrintArrayString(arrayStringNew);