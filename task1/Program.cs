int Searching(string text, char any)
{
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == any)
        {
            count++;
        }

    }
    return count;
}

string Checking(string text)
{
    string newText = string.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        bool check = false;
        for (int j = i + 1; j < text.Length; j++)
        {
            if (text[i] == text[j]) check = true;
        }
        if (!check) newText = newText + $"{text[i]}"; 
    }
    return newText;
}

Console.WriteLine("text");
string text = "Частотный анализ – это один из методов криптоанализа,";
text = text.ToLower();
double size = text.Length;
double percent = 0;
string newText = Checking(text);
for (int i = 0; i < newText.Length; i++)
{
    int count = Searching(text, newText[i]);
    percent = count / size * 100;
    Console.WriteLine($"{newText[i]} is in text {count} times. Percent = {Math.Round(percent, 2)} %");
}
