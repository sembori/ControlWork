using static System.Console;
Clear();
string[] massive = { "-2", "Moscow", "Boo", "24313", "88", "Stop", "98", "youp", "00", "dsdfv" };;
PrintArray(SearchElementOfMassive(massive));


string[] SearchElementOfMassive(string[] array)
{
    int j = 0;
    int count = 0;
    string[] newArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
         count ++;
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
