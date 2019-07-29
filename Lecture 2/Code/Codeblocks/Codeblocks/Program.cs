using System;

namespace Codeblocks
{
    class Program
    {
        static void Main(string[] args)
        {

           

        }
        public void pascalsTriangle()
        {
            int rows = 8, val = 1, blank, i, j;
            Console.WriteLine("Pascal's triangle");

            //loop for rows
            for (i = 0; i < rows; i++)
            {
                //put blank spaces in
                for (blank = 1; blank <= rows - i; blank++)
                {
                    Console.Write("  ");
                }
                //put numbers in
                for (j = 0; j <= i; j++)
                {
                    //if numbers = 0 make them = 1;
                    //else number = val * (i - j + 1) / j;
                    _ = ((j == 0) || (i == 0)) ? val = 1 : val = val * (i - j + 1) / j;

                    Console.Write(val + "   ");
                }
                Console.WriteLine();
            }
        }
        public void diamond()
        {
            int num, space;

            while (true)
            {
                //ask for a number
                Console.WriteLine("Please enter a number between 1 and 9 : ");
                num = Convert.ToInt16(Console.ReadLine());
                space = num - 1;
                //convert space to the write value

                //loop every line
                for (int i = 1; i <= num; i++)
                {
                    //loop for spaces before the values
                    for (space = 1; space <= (num - i); space++)
                    {
                        Console.Write(" ");
                    }
                    //loop for the values in order
                    //start from 1 and count up
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("X");
                    }
                    //loop for the values reversed
                    //count from i-1 and count down so that a number is in the middle only once
                    for (int k = (i - 1); k >= 1; k--)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
                for (int i = num; i >= 0; i--)
                {
                    //loop for spaces before the values
                    for (space = (num - i); space >= 1; space--)
                    {
                        Console.Write(" ");
                    }
                    //loop for the values in order
                    //start from 1 and count up
                    for (int j = i; j >= 1; j--)
                    {
                        Console.Write("X");
                    }
                    //loop for the values reversed
                    //count from i-1 and count down so that a number is in the middle only once
                    for (int k = 1; k <= (i - 1); k++)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void xPyramid()
        {
            int num, space;

            while (true)
            {
                //ask for a number
                Console.WriteLine("Please enter a number between 1 and 9 : ");
                num = Convert.ToInt16(Console.ReadLine());
                space = num - 1;
                //convert space to the write value

                //loop every line
                for (int i = 1; i <= num; i++)
                {
                    //loop for spaces before the values
                    for (space = 1; space <= (num - i); space++)
                    {
                        Console.Write(" ");
                    }
                    //loop for the values in order
                    //start from 1 and count up
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("X");
                    }
                    //loop for the values reversed
                    //count from i-1 and count down so that a number is in the middle only once
                    for (int k = (i - 1); k >= 1; k--)
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void invertedSlantedTriangle()
        {
            int size = 4;
            for (int i = size; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
        public void slantedTriangle()
        {
            int size = 4;
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
        public void fibonacci()
        {
            int num1 = 0, num2 = 1, num3 = 0, i, n;
            Console.WriteLine("Please enter a number between 6 and 12");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Fibonacci:");

            Console.Write(num1 + " " + num2 + " ");
            for (i = 2; i < n; ++i)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
        public void backwards()
        {
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        public void tens()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void evens()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void blocks()
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("**********");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void pyramid()
        {
            int num, space;

            while (true)
            {
                //ask for a number
                Console.WriteLine("Please enter a number between 1 and 9 : ");
                num = Convert.ToInt16(Console.ReadLine());
                space = num - 1;
                //convert space to the write value

                //loop every line
                for (int i = 1; i <= num; i++)
                {
                    //loop for spaces before the values
                    for (space = 1; space <= (num - i); space++)
                    {
                        Console.Write(" ");
                    }
                    //loop for the values in order
                    //start from 1 and count up
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    //loop for the values reversed
                    //count from i-1 and count down so that a number is in the middle only once
                    for (int k = (i - 1); k >= 1; k--)
                    {
                        Console.Write(k);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
