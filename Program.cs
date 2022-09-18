Console.Clear();
Console.WriteLine("Greetings user! Let's see how many word in this array has 3 letters or less.");
string[] arrayWords = { "Hello", "How", "are", "you", "today", "I", "hope", "well" };

int Count(string[] array)
{
    int x = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        x = array[i].Length;
        if (x <= 3)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"In this array {Count(arrayWords)} word(s) has/have 3 letters");
Console.WriteLine($"Now let's put them in a seperate array.");
int size = Count(arrayWords);
string[] newWords = new string[size];
void Merge(string[] oldArray, string[] newArray)
{
    int y = 0;
    int x = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        x = oldArray[i].Length;
        if (x <= 3)
        {
            newArray[y] = oldArray[i];
            y++;
        }
    }
}

void ShowArray(string[] array)
{
    Console.Write("So your new array is going to look something like this. newArray = {");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("}.");
}
Merge(arrayWords, newWords);
ShowArray(newWords);