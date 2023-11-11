// JAKUB STRUGAŁA - 14646
class Program
{
    static void Main()
    {
        SolveCryptarithmetic();
    }

    static void SolveCryptarithmetic()
    {
        for (int a = 0; a <= 9; a++)
        {
            for (int b = 0; b <= 9; b++)
            {
                for (int c = 0; c <= 9; c++)
                {
                    for (int d = 0; d <= 9; d++)
                    {
                        for (int e = 0; e <= 9; e++)
                        {
                            for (int f = 0; f <= 9; f++)
                            {
                                for (int g = 0; g <= 9; g++)
                                {
                                    for (int h = 0; h <= 9; h++)
                                    {
                                        int multiplicand = 10000 * a + 1000 * b + 100 * c + 10 * d + e;
                                        int multiplier = 100 + 10 * f + g;
                                        int product = multiplicand * multiplier;

                                        if (IsValidAssignment(a, b, c, d, e, f, g, h, product))
                                        {
                                            Console.WriteLine($"       {a} {b} {c} {d} {e}");
                                            Console.WriteLine($"  x        {f} {g} {a}");
                                            Console.WriteLine("    -------------");
                                            Console.WriteLine($"    * * {h} * * *");
                                            Console.WriteLine($"    {b} {b} * * *");
                                            Console.WriteLine($" * * {h} * * *");
                                            Console.WriteLine("-----------------");
                                            Console.WriteLine($" * {f} * * * {d} * *");
                                            Console.WriteLine();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    static bool IsValidAssignment(int a, int b, int c, int d, int e, int f, int g, int h, int product)
    {
        int[] digitCount = new int[10];

        CountDigits(a, digitCount);
        CountDigits(b, digitCount);
        CountDigits(c, digitCount);
        CountDigits(d, digitCount);
        CountDigits(e, digitCount);
        CountDigits(f, digitCount);
        CountDigits(g, digitCount);
        CountDigits(h, digitCount);
        CountDigits(product, digitCount);

        // Sprawdzanie, czy dla każdej litery przypisana jest inna cyfra
        for (int i = 0; i < digitCount.Length; i++)
        {
            if (digitCount[i] > 1)
                return false;
        }

        // Sprawdzanie, czy liczby się sumują
        int sum = a + b + c + d + e + f + g + h;
        return sum % 10 == 0 && sum / 10 == g;
    }

    static void CountDigits(int number, int[] digitCount)
    {
        while (number > 0)
        {
            int digit = number % 10;
            digitCount[digit]++;
            number /= 10;
        }
    }
}

/* WYNIKI:
       0 0 0 0 0
  x        0 0 0
    -------------
    * * 0 * * *
    0 0 * * *
 * * 0 * * *
-----------------
 * 0 * * * 0 * *

       0 0 0 0 0
  x        0 1 0
    -------------
    * * 9 * * *
    0 0 * * *
 * * 9 * * *
-----------------
 * 0 * * * 0 * *

       0 0 0 0 0
  x        2 1 0
    -------------
    * * 7 * * *
    0 0 * * *
 * * 7 * * *
-----------------
 * 2 * * * 0 * *

       0 0 0 0 0
  x        3 1 0
    -------------
    * * 6 * * *
    0 0 * * *
 * * 6 * * *
-----------------
 * 3 * * * 0 * *

       0 0 0 0 0
  x        4 1 0
    -------------
    * * 5 * * *
    0 0 * * *
 * * 5 * * *
-----------------
 * 4 * * * 0 * *

       0 0 0 0 0
  x        5 1 0
    -------------
    * * 4 * * *
    0 0 * * *
 * * 4 * * *
-----------------
 * 5 * * * 0 * *

       0 0 0 0 0
  x        6 1 0
    -------------
    * * 3 * * *
    0 0 * * *
 * * 3 * * *
-----------------
 * 6 * * * 0 * *

       0 0 0 0 0
  x        7 1 0
    -------------
    * * 2 * * *
    0 0 * * *
 * * 2 * * *
-----------------
 * 7 * * * 0 * *

       0 0 0 0 0
  x        9 1 0
    -------------
    * * 0 * * *
    0 0 * * *
 * * 0 * * *
-----------------
 * 9 * * * 0 * *

       0 0 0 0 3
  x        7 2 0
    -------------
    * * 8 * * *
    0 0 * * *
 * * 8 * * *
-----------------
 * 7 * * * 0 * *

       0 0 0 0 3
  x        8 2 0
    -------------
    * * 7 * * *
    0 0 * * *
 * * 7 * * *
-----------------
 * 8 * * * 0 * *

       0 0 0 0 4
  x        5 2 0
    -------------
    * * 9 * * *
    0 0 * * *
 * * 9 * * *
-----------------
 * 5 * * * 0 * *

       0 0 0 0 4
  x        9 2 0
    -------------
    * * 5 * * *
    0 0 * * *
 * * 5 * * *
-----------------
 * 9 * * * 0 * *

       0 0 0 0 5
  x        4 2 0
    -------------
    * * 9 * * *
    0 0 * * *
 * * 9 * * *
-----------------
 * 4 * * * 0 * *

       0 0 0 0 5
  x        6 2 0
    -------------
    * * 7 * * *
    0 0 * * *
 * * 7 * * *
-----------------
 * 6 * * * 0 * *

       0 0 0 0 8
  x        3 2 0
    -------------
    * * 7 * * *
    0 0 * * *
 * * 7 * * *
-----------------
 * 3 * * * 0 * *

       0 0 0 0 9
  x        5 2 0
    -------------
    * * 4 * * *
    0 0 * * *
 * * 4 * * *
-----------------
 * 5 * * * 0 * *

       0 0 0 0 9
  x        6 2 0
    -------------
    * * 3 * * *
    0 0 * * *
 * * 3 * * *
-----------------
 * 6 * * * 0 * *

       0 0 0 1 8
  x        9 2 0
    -------------
    * * 0 * * *
    0 0 * * *
 * * 0 * * *
-----------------
 * 9 * * * 1 * *

       0 0 0 3 0
  x        7 2 0
    -------------
    * * 8 * * *
    0 0 * * *
 * * 8 * * *
-----------------
 * 7 * * * 3 * *

       0 0 0 3 0
  x        8 2 0
    -------------
    * * 7 * * *
    0 0 * * *
 * * 7 * * *
-----------------
 * 8 * * * 3 * *

       0 0 0 4 0
  x        9 2 0
    -------------
    * * 5 * * *
    0 0 * * *
 * * 5 * * *
-----------------
 * 9 * * * 4 * *

       0 0 0 5 4
  x        9 2 0
    -------------
    * * 0 * * *
    0 0 * * *
 * * 0 * * *
-----------------
 * 9 * * * 5 * *

       0 0 0 5 9
  x        0 2 0
    -------------
    * * 4 * * *
    0 0 * * *
 * * 4 * * *
-----------------
 * 0 * * * 5 * *

       0 0 0 9 0
  x        5 2 0
    -------------
    * * 4 * * *
    0 0 * * *
 * * 4 * * *
-----------------
 * 5 * * * 9 * *

       0 0 0 9 0
  x        6 2 0
    -------------
    * * 3 * * *
    0 0 * * *
 * * 3 * * *
-----------------
 * 6 * * * 9 * *

       0 0 1 8 0
  x        9 2 0
    -------------
    * * 0 * * *
    0 0 * * *
 * * 0 * * *
-----------------
 * 9 * * * 8 * *
 */
