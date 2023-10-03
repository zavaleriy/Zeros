internal class Program
{
    static string Reverse(string input)
    {
        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    static bool countZeros(string input, int K)
    {
        int sum = 0;
        char[] arr = input.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '0')
            {
                sum++;
            }
        }

        if (sum == K) return true;

        return false;
    }

    static void Main(string[] args)
    {
        Console.Write("N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("K: ");
        int K = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        int zeros = 0;

        for (int i = 1; i <= N; i++)
        {
            // Перевод в двоичную систему

            int temp = i;
            string res = "";
            Console.Write($"{i}: ");
            while (temp > 0)
            {
                res += temp % 2;

                temp /= 2;
            }
            if (countZeros(res, K))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(Reverse(res));
                Console.BackgroundColor = ConsoleColor.Black;
                zeros++;
            }
            else
            {
                Console.WriteLine(Reverse(res));
                Console.BackgroundColor = ConsoleColor.Black;
            }

        }

        Console.WriteLine($"\nНоликов: {zeros}");

    }
}