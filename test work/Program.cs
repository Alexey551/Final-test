Console.Clear();
string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input number {i + 1}: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.Write("]");
}

string[] ConversionArray(string[] array)
{
    int count = 0;
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }

    }
    return newArray;
}

Console.Write("Input size: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
string[] myArray = CreateArray(a);
Console.WriteLine();
Console.Write("The input array looks like this: ");
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine();
Console.Write("The final array looks like this: ");
ShowArray(ConversionArray(myArray));
Console.WriteLine();
Console.WriteLine();