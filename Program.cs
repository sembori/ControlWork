using static System.Console;
Clear();
string[] massive = { "-2", "Moscow", "Boo", "24313", "88", "Stop", "98", "youp", "00", "dsdfv" }; ;
PrintArray(SearchElementOfMassive(massive,SearchLenghtOfNewMassive(massive)));


int SearchLenghtOfNewMassive(string[] array)
{
    int count = 0;
    // string[] newArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

String[] SearchElementOfMassive(string[] array, int LenghtNewArray)
{
    int j=0;
    string[] newArray = new string[LenghtNewArray];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}
