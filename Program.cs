// string text = "Код 2026";
// Console.WriteLine(text.Length);
// Console.WriteLine(text[0]);
// Console.WriteLine(text[text.Length - 1]);
// if (text.Length > 0)
// {
//     Console.WriteLine($"Первый символ: {text[0]}");
// }

// foreach (char symbol in text)
// {
//     Console.WriteLine(symbol);
// }

// for (int i = 0; i < text.Length; i++)
// {
//     Console.WriteLine($"{i}: {text[i]}");
// }

// int CountCharacter(string text, char target)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (symbol == target)
//         {
//             count++;
//         }
//     }

//     return count;
// }
// Console.WriteLine(CountCharacter("мама", 'м'));
// Console.WriteLine(CountCharacter("Код 2026", ' '));
// Console.WriteLine(CountCharacter("", 'а'));


int CountCharacter(string text, char target)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            count++;
        }
    }

    return count;
}

// int CountDigits(string text)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (char.IsDigit(symbol))
//         {
//             count++;
//         }
//     }

//     return count;
// }

int CountLetters(string text){
    int count = 0;
    foreach (char symbol in text) {
        if (char.IsLetter(symbol)) {
            count ++;
        }
    }
    return count;
}
// Console.WriteLine(CountDigits("Код 2026!"));
// Console.WriteLine(CountLetters("Код 2026!"));

int CountDigits(string text)
{
    int count = 0;

    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count ++;;
        }
    }

    return count;
}

// Console.WriteLine(CountDigits("A2B3"));

// int FindCharacterIndex(string text, char target)
// {
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == target)
//         {
//             return i;
//         }
//     }

//     return -1;
// }
// Console.WriteLine(FindCharacterIndex("banana", 'a'));
// Console.WriteLine(FindCharacterIndex("banana", 'b'));
// Console.WriteLine(FindCharacterIndex("banana", 'z'));
// Console.WriteLine(FindCharacterIndex("", 'a'));

int FindCharacterIndex(string text, char target)
{
    int index = -1;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            index = i;
            break;
        }
    }

    return index;
}

// string sample = "  Привет, C#!  ";
// string trimmed = sample.Trim();
// string upper = sample.ToUpper();
// string lower = sample.ToLower();
// string replaced = sample.Replace(' ', '_');
// Console.WriteLine($"Исходная: [{sample}]");
// Console.WriteLine($"Без пробелов по краям: [{trimmed}]");
// Console.WriteLine($"Верхний регистр: [{upper}]");
// Console.WriteLine($"Нижний регистр: [{lower}]");
// Console.WriteLine($"Замена пробелов: [{replaced}]");

// string sample = "  кот  ";
// string trimmed = sample.Trim();
// Console.WriteLine($"[{trimmed}]");

int CountWords(string text)
{
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}
// Console.WriteLine(CountWords("Я изучаю C#"));
// Console.WriteLine(CountWords("  кот  дом  "));
// Console.WriteLine(CountWords(""));
// Console.WriteLine(CountWords("   "));

Console.Write("Введите строку: ");
string text = Console.ReadLine() ?? "";
Console.WriteLine("   >>> Анализ строки <<<");
Console.WriteLine($"Исходная строка: [{text}]");
int letters = CountLetters(text);
int digits = CountDigits(text);
int spaces = CountCharacter(text, ' ');
int words = CountWords(text);
string trimmed = text.Trim();
string upper = text.ToUpper();
string replace = text.Replace(' ', '_');
Console.WriteLine($"Длина: {text.Length}");
Console.WriteLine($"Букв: {letters}");
Console.WriteLine($"Цифр: {digits}");
Console.WriteLine($"Пробелов: {spaces}");
Console.WriteLine($"Слов: {words}");
Console.WriteLine($"Без пробелов по краям: [{trimmed}]");
Console.WriteLine($"Верхний регистр: [{upper}]");
Console.WriteLine($"Замена пробелов: [{replace}]");

Console.Write("Введите один символ для поиска: ");
char target = Convert.ToChar(Console.ReadLine());
int index = FindCharacterIndex(text, target);
if (index == -1){
    Console.WriteLine("Символ не найден");
}
else{
    Console.WriteLine($"Первый индекс: {index}");
}

