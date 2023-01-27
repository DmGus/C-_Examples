﻿//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
             +"ежели бы вас послали вместо нашего милого Винценгероде,"
             +"вы бы взяли приступом согласие прусского короля."
             +"Вы так красноречивы. Вы дадите мне чаю?";

Console.WriteLine(text);
string newText=StringReplace(text, ' ', '_');
Console.WriteLine(newText);
newText=StringReplace(newText, 'к', 'К');
Console.WriteLine(newText);
newText=StringReplace(newText, 'С', 'с');
Console.WriteLine(newText);


// Методы

string StringReplace(string text, char oldValue, char newValue)
{
string result = String.Empty;
int length = text.Length;
for (int i = 0; i < length; i++)
{
    if (text[i] == oldValue) result=result+newValue;
    else result=result+text[i];
}

return result;
}
