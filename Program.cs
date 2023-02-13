using static System.Comsole;
Clear();

string[] massive = new string[10];
string[] massive = { "-2", "Moscow", "Boo", "24313", "88", "Stop", "98", "youp", "00", "dsdfv" };

string[] SearchElementOfMassive(string[] array)
{
    int count = 0;
    string[] newArray = new string[count];
    for (int i = 0; i < array.length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
        for (int j = 0; j < count; j++)
        {
            newArray[j] = array[i];
        }
    }

}