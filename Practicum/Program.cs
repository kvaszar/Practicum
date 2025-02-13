Console.WriteLine("Task 4");
Test(Task4([1, 2, 3]), 3);
Test(Task4([-1, 2, 3]), 2);
Test(Task4([0, -2, 3]), 1);
Test(Task4([1, 0, 3]), 2);
Console.WriteLine("Task 1");
Test(Task1([1, 2, 3, 1, 1, 1]), 3);
Test(Task1([1, 2, 3]), 1);
Test(Task1([1, 2, 2, 3, 1, 1]), 2);
Console.WriteLine("Task 2");
Test(Task2(13), 13);
Test(Task2(10), 2);
Test(Task2(15), 3);
Console.WriteLine("Task 6");
Test(Task6(111), true);
Test(Task6(121), false);

return;

void Test(dynamic value, dynamic result)
{
    if (value == result)
    {
        Console.WriteLine(value + " OK");
    }
    else
    {
        Console.WriteLine(value + " FAIL");
    }
}


int Task4(int[] arr) => arr.Count(x => x > 0);

bool Task6(int n)
{
    var lastNum = n % 10;
    n /= 10;
    while (n > 0)
    {
        var currNum = n % 10;
        if (lastNum != currNum)
        {
            return false;
        }

        lastNum = currNum;
        n /= 10;
    }

    return true;
}

int Task2(int n)
{
    for (var i = 2; i < Math.Sqrt(n) + 1; i++)
    {
        if (n % i == 0)
        {
            return i;
        }
    }

    return n;
}

int Task1(int[] arr)
{
    var max = 0;
    var count = 1;
    for (var i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1])
        {
            count++;
        }
        else
        {
            max = Math.Max(max, count);
            count = 1;
        }
    }
    return Math.Max(max, count);
}