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