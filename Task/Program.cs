void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] FinalArray(string[] FirstArray)
{
    int count = 0;
    string[] SecondArray = new string[FirstArray.Length];
    for (int i = 0; i < FirstArray.Length; i++)
    {
    if(FirstArray[i].Length <= 3)
        {
        SecondArray[count] = FirstArray[i];
        count++;
        }
    }
    return SecondArray;
}

Console.Clear();
Console.Write("Введите через пробел элементы массива: ");
string[] FirstArray = Console.ReadLine().Split(" ").ToArray();
Console.Write("Новый массив с длинной элементов меньше 3-х: ");
PrintArray(FinalArray(FirstArray));