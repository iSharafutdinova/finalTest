string[] inputArray = { "hello", "2", "world", "1234", "me", "1567" };

string PrintArray(string[] array)
{
    return string.Join(", ", array);
}

int CountSymbolsInArray(string[] input)
{
    int length = inputArray.Length;
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < length; i++)
    {
        if (inputArray[i].Length <= maxLengthString)
        {
            count++;
        }
    }
    return count;
}

string[] CreateArray(string[] inputArray, int countSymbols)
{
    int length = inputArray.Length;
    string[] outputArray = new string[countSymbols];
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < length; i++)
    {
        if (inputArray[i].Length <= maxLengthString)
        {
            outputArray[count] = inputArray[i];
            count++;
        }
    }

    return outputArray;
}

PrintArray(inputArray);

string[] outputArray = CreateArray(inputArray, CountSymbolsInArray(inputArray));

Console.WriteLine(PrintArray(outputArray));