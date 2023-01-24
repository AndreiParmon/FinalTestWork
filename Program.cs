string[] array8 = new string[] {"1234", "1567", "-2", "computer science", "/*-+", "a15"};
string[] result = new string[array8.Length];

void ArrayMas(string[] array8, string[] result)
{
    int count = 0;
    for (int i = 0; i < array8.Length; i++)
    {
        if (array8[i].Length <= 3)
        {   
            result[count] = array8[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

ArrayMas(array8, result);
Console.Write("Сформированный массив: ");
PrintArray(result);