TestTask20();
return;

IEnumerable<int> Task20(int[] arr)
{
    for (var i = 1; i < arr.Length - 1; i++)
    {
        if (arr[i - 1] + arr[i + 1] == arr[i])
        {
            yield return arr[i];
        }
    }
}

void TestTask20()
{
    var passed = 0;
    var total = 1;
    if (Task20([1, 2, 1, 4, 3, 5]).SequenceEqual([2, 4]))
    {
        passed++;
        Console.Write(". ");
    }
    else Console.Write("x ");

    total++;
    if (Task20([1, 2, 3, 4, 5]).SequenceEqual([]))
    {
        passed++;
        Console.Write(". ");
    }
    else Console.Write("x ");

    Console.WriteLine($"\nPassed {passed}/{total}");
}