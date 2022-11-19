string ReadString()
{
    Console.WriteLine("Введите слова через пробел:");
    return Console.ReadLine();
}
// Метод преобразования строки в массив
string[] StringToArray(string array)
{
    string[] stringArray = array.Split(" ");
    return stringArray;
}
// Метод создания массива из менее, чем трёх символов
string[] CreateNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    count = 0;
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
// Метод печати массива
void PrintArray(string[] array)
{
    if (array.Length != 0)
    {
        Console.WriteLine("Новый массив из не более трех символов:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
    else
    {
        Console.WriteLine("Таких значений нет!");
    }
}

string str = ReadString();
string[] array = StringToArray(str);
string[] newArray = CreateNewArray(array);
Console.WriteLine();
PrintArray(newArray);
