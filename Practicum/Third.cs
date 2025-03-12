namespace Practicum;

public class Third
{
    public static void x()
    {
// var a = ReadArray();
// Console.WriteLine(Task11(a));
        Console.WriteLine("Task 11");
        TestTask11();
        Console.WriteLine("Task 12");
        TestTask12();
        Console.WriteLine("Task 13");
        Console.WriteLine(Task13([1]));
        Console.WriteLine("Task 15");
        TestTask15();
        return;

        int[] ReadArray()
        {
            var line = Console.ReadLine();
            return line?.Split(' ').Select(int.Parse).SkipLast(1).ToArray() ?? [];
        }

        int Task11(int[] arr)
        {
            var count = 0;
            for (var i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    count++;
                }
            }

            return count;
        }

        void TestTask11()
        {
            var passed = 0;
            const int total = 3;
            if (Task11([1, 2, 3]) == 2)
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task11([3, 2, 1]) == 0)
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task11([3, 2, 3]) == 1)
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            Console.WriteLine($"\nPassed {passed}/{total}");
        }

        string Task12(int a, int b)
        {
            if (a == 0 && b == 0) return "many solutions";
            if ((a == 0 && b != 0) || b % a != 0) return "no solution";
            return (b / a).ToString();
        }

        void TestTask12()
        {
            var passed = 0;
            const int total = 9;
            if (Task12(1, -2) == "-2")
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task12(2, -1) == "no solution")
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task12(0, 0) == "many solutions")
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task12(5, 0) == "0")
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task12(2, 1) == "no solution")
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task12(10, 11) == "no solution")
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task12(1, 30000) == "30000")
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task12(-15000, 15000) == "-1")
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            if (Task12(-29999, 24999) == "no solution")
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            Console.WriteLine($"\nPassed {passed}/{total}");
        }


        int Task13(int[] arr) 
            => arr.Where(x => x % 2 == 0).DefaultIfEmpty(0).Min();
        
        string Task14(int[] arr, int find)
        {
            var index = Array.BinarySearch(arr, find);
            return index < 0 ? "NO" : index.ToString();
        }
        
        int[] Task15(int a, int b)
        {
            List<int> primes = [];
            for (var i = a; i < b; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes.Count == 0 ? [0] : primes.ToArray();

            bool IsPrime(int num)
            {
                for (var j = 2; j < Math.Ceiling(Math.Sqrt(num)) + 1; j++)
                {
                    if (num % j == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        void TestTask15()
        {
            var passed = 0;
            var total = 1;

            if (Task15(20, 30).SequenceEqual([23, 29]))
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            total++;
            if (Task15(24, 28).SequenceEqual([0]))
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            total++;
            if (Task15(139, 216).SequenceEqual([139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211]))
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            Console.WriteLine($"\nPassed {passed}/{total}");
        }

    }
}