﻿// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1();     //вызов метода. закомментировал, чтобы тругие методы можно
// было вывести в терминал


// Вид 2
void Method2(string msg)  //ключевое слово Индефикатор(аргументы)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения"); //именованные аргументы

void Method21(string msg, int count)  
{
    int i = 0;
    while (i < count)
    {
    Console.WriteLine(msg);
    i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "new text");


//Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

//Вид 4
string Method4(int count, string text)  
{
    int i = 0;
    string result = ""; //пустая строка - ""

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "qwer");
Console.WriteLine(res);