﻿void FillArray(int[] collection) //void - метод без return
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
       collection[index] =  new Random().Next(1, 10);
       index++; //index = index + 1;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемента не будет в массиве, то выдаст -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай массив с 10 элементами

FillArray(array); // заполнение массива
PrintArray(array); //распечатали массив рандомный
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);