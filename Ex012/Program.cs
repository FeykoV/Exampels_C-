// Виды методов:
// 1 тип (ничего не принимает и ничего не возвращает)

void Method1() 
{
    Console.WriteLine("Автор ...");
} 
Method1();


// 2 тип (что-то принимает и ничего не возвращает)

void Method2(string msg) 
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

//или 

Method2(msg: "Текст сообщения");

void Method21(string msg, int count) 
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);
// или
Method21(msg: "Текст", count: 4);
// или переставить именнованые переменные местами (от этого работа метода не поменяется)
Method21(count: 4, msg: "новый текст");


// 3 тип (что-то возвращает и ничего не принимает)

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);


// 4 й вид. Это методы, которые что-то принимают и что-то возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //где String.Empty = ""  - это значит пустая строка.
    while (i < count)
    {
        result = result  + text;
        i++;
    }
    return result;
}

string res = Method4(10, "qwerty");
Console.WriteLine(res);