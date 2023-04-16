// Работа с текстом
// Дан текст, в тексте все пробелы надо заменить черточками,
// маленькие буквы "к" заменить на боьшие буквы "К",
// а большие "С" заменить на маленькие "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежили вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие Прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replase (string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replase(text, ' ', '_');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);

Console.WriteLine();
newText = Replase(newText, 'с', 'С');
Console.WriteLine(newText);