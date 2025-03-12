namespace Practicum;

public class Fourth
{
    void x()
    {
        TestTask21();

        IEnumerable<int> Task21(int n)
        {
            for (var i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    n /= i;
                    yield return i;
                }
            }
        }

        void TestTask21()
        {
            var passed = 0;
            var total = 1;
            if (Task21(5).SequenceEqual([5]))
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            total++;
            if (Task21(12).SequenceEqual([2, 2, 3]))
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            total++;
            if (Task21(1001).SequenceEqual([7, 11, 13]))
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            total++;
            if (Task21(904).SequenceEqual([2, 2, 2, 113]))
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            total++;
            if (Task21(15470).SequenceEqual([2, 5, 7, 13, 17]))
            {
                passed++;
                Console.Write(". ");
            }
            else Console.Write("x ");

            Console.WriteLine($"\nPassed {passed}/{total}");
        }
    }
}