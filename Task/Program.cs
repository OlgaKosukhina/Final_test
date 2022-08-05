

string[] InitArray(int dimension)
{
    string[] array = new string[dimension];
    Console.WriteLine("Введите строки:");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

string[] GetNewArray(string[] array)
{
    string[] newArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
    }

    return newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
        {
            Console.Write($"{array[i]} ");
        }
    }
}

Console.WriteLine("Введите размерность массива: ");
int dimension = int.Parse(Console.ReadLine());
string[] array = InitArray(dimension);
string[] newArray = GetNewArray(array);
PrintArray(newArray);
