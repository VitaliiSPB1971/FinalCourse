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
