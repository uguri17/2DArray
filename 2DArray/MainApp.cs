using System;

namespace _2DArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine($"[dimension]: {arr.GetLength(0)}"); // 차원 = 형태, 구조
            Console.WriteLine($"[Length]: {arr.GetLength(1)}");

            Console.WriteLine("\narr1");
            for (int i = 0; i < arr.GetLength(0); i++) // 0,1 // 2번 반복
            {                           // 2
                for (int j = 0; j < arr.GetLength(1); j++) // 0,1,2 // 3번 반복
                {                       // 3
                    Console.WriteLine($"[{i}, {j}]: {arr[i, j]}");
                }
                Console.WriteLine();
            }

            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("arr2");
            for (int i = 0; i < arr.GetLength(0); i++) // 0,1 // 2번 반복
            {                           // 2
                for (int j = 0; j < arr.GetLength(1); j++) // 0,1,2 // 3번 반복
                {                       // 3
                    Console.WriteLine($"[{i}, {j}]: {arr[i, j]}");
                }
                Console.WriteLine();
            }

            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("arr3");
            for (int i = 0; i < arr.GetLength(0); i++) // 0,1 // 2번 반복
            {                           // 2
                for (int j = 0; j < arr.GetLength(1); j++) // 0,1,2 // 3번 반복
                {                       // 3
                    Console.WriteLine($"[{i}, {j}]: {arr[i, j]}");
                }
                Console.WriteLine();
            }

            foreach (int a in arr3)
            {
                Console.Write(a);
            }
        }
    }
}
