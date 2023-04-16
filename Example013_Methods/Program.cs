// первый тип методов 
void Method1()
{
    Console.WriteLine("Автор записи AVA");
}
Method1()

// второй тип методов
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
// //Пример
// void Method2_1(string msgю, int count)
// {
//     int i = 0 
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++ // (count++) <- инкримент (count--) <- декримент
//     }
// }
// Method2_1("Текст", 4); // именнованая запись: Method2_1(msg: "Text", count: 4)
// // именнованную запись можно менять местами(!): Method2_1(count: 4, msg: "Text")

// третий тип методов
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// четвёртый тип методов
string Method4(int count, string text)
{
    int i = 0;
    string result = ""; // подразумевает запись: string result = String.Empty
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Автор текста...");
Console.WriteLine(res);