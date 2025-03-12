namespace Practicum;

public class Second
{
    public static void g()
    {
// List<int> arr = [1, 3, 2, 5, 7, 4, 2, 7, 1];
// arr = arr.Select(x => x == arr.Max() ? 99 : x == arr.Min() ? 0 : x).ToList();
// Console.WriteLine(string.Join(", ", arr));

        var arr = GetRandomArray(10, 1, 10);
        PrintArray(arr);
        arr = ReplaceMin(arr, 0);
        arr = ReplaceMax(arr, 99);
        PrintArray(arr);

        static int GetMax(int[] arr)
        {
            //return arr.Max();
            var max = arr.First();
            foreach (var elem in arr)
            {
                if (elem > max)
                {
                    max = elem;
                }
            }

            return max;
        }

        static int GetMin(int[] arr)
        {
            //return arr.Max();
            var min = arr.First();
            foreach (var elem in arr)
            {
                if (elem < min)
                {
                    min = elem;
                }
            }

            return min;
        }

        static int[] ReplaceMax(int[] arr, int newMax)
        {
            var arrCopy = new int[arr.Length];
            arr.CopyTo(arrCopy, 0);
            var max = GetMax(arrCopy);
            for (var i = 0; i < arrCopy.Length; i++)
            {
                if (arrCopy[i] == max)
                {
                    arrCopy[i] = newMax;
                }
            }

            return arrCopy;
        }

        static int[] ReplaceMin(int[] arr, int newMin)
        {
            var arrCopy = new int[arr.Length];
            arr.CopyTo(arrCopy, 0);
            var min = GetMin(arrCopy);
            for (var i = 0; i < arrCopy.Length; i++)
            {
                if (arrCopy[i] == min)
                {
                    arrCopy[i] = newMin;
                }
            }

            return arrCopy;
        }

        static int[] GetRandomArray(int count, int min, int max)
        {
            var arr = new int[count];
            var rnd = new Random();
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }

            return arr;
        }

        static void PrintArray(int[] arr) => Console.WriteLine(string.Join(", ", arr));
    }
}