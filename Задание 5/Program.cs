//int i = Convert.ToInt32(Console.ReadLine());
//int j = Convert.ToInt32(Console.ReadLine());
//int[,] matrix = new int[i, j];
//int[] output = new int[i * j];
//int top = 0, bottom = i - 1, left = 0, right = j - 1;
//int direction = 0;
//int index = 0;
//for (int row = 0; row < i; row++)
//{
//    for (int col = 0; col < j; col++)
//    {
//        matrix[row, col] = Convert.ToInt32(Console.ReadLine());
//    }
//}

//while (top <= bottom && left <= right)
//{
//    if (direction == 0) // Traverse from left to right
//    {
//        for (int k = left; k <= right; k++)
//        {
//            output[index++] = matrix[top, k];
//        }
//        top++;
//    }
//    else if (direction == 1) // Traverse from top to bottom
//    {
//        for (int l = top; l <= bottom; l++)
//        {
//            output[index++] = matrix[l, right];
//        }
//        right--;
//    }
//    else if (direction == 2) // Traverse from right to left
//    {
//        for (int k = right; k >= left; k--)
//        {
//            output[index++] = matrix[bottom, k];
//        }
//        bottom--;
//    }
//    else if (direction == 3) // Traverse from bottom to top
//    {
//        for (int l = bottom; l >= top; l--)
//        {
//            output[index++] =  matrix[l, left];
//        }
//        left++;
//    }
//    direction = (direction + 1) % 4;
//}

//for (int o = 0; o < i * j; o++)
//{
//    Console.Write(output[o] + " ");
//}



//using System;

//class Program
//{
//    public static void Main()
//    {
//        Console.Write("Введите уровни треугольника: ");
//        int height = Convert.ToInt32(Console.ReadLine());
//        treygolinklogic(height);
//    }

//    private static void treygolinklogic(int N)
//    {
//        for (int line = 0; line < N; line++)
//        {
//            int value = 1;  
//            for (int j = 0; j < line + 1; j++)
//            {
//                Console.Write(value + " ");
//                value = value * (line - j) / (j + 1);
//            }
//            Console.WriteLine();  
//        }
//    }
//}



//public class Solution
//{
//    static void Main() 
//    {
//        int[] prices = { 2, 5, 1, 6, 7, 1 };
//        Solution solution = new Solution();
//        int result = solution.bisness(prices);
//        Console.WriteLine(result);
//    }

//    public int bisness(int[] prices)
//    {
//        if (prices.Length == 0)
//        {
//            return 0;
//        }

//        int maxProfit = 0;
//        int minPrice = prices[0];

//        for (int i = 1; i < prices.Length; i++)
//        {
//            if (prices[i] < minPrice)
//            {
//                minPrice = prices[i];
//            }
            
//            else
//            {
//                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
//            }
//        }

//        return maxProfit;
//    }
//}