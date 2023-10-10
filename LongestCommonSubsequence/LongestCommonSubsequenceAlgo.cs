using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubsequence
{
    public class LongestCommonSubsequenceAlgo
    {
        public static void LongestCommonSubsequence(string text1, string text2)
        {
            int columns = text1.Length;
            int rows = text2.Length;

            text1 = " " + text1; // to solve the part of the first row and column = zeros
            text2 = " " + text2;

            int[][] Matrix = new int[rows + 1][];
            for (int i = 0; i <= rows; i++)
            {
                Matrix[i] = new int[columns + 1];
            }

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    if (text2[i] == text1[j])
                    {
                        Matrix[i][j] = 1 + Matrix[i - 1][j - 1];
                    }
                    else
                    {
                        Matrix[i][j] = Math.Max(Matrix[i][j - 1], Matrix[i - 1][j]);
                    }
                }
            }

            GetLCS(Matrix, text2, columns,rows);
        }
        private static void GetLCS(int[][] Matrix, string text2, int columns, int rows)
        {
            string result = "";
            int i = rows;
            int j = columns;

            while (i > 0 && j > 0)
            {
                if (Matrix[i][j] > Matrix[i][j - 1])
                {
                    if (Matrix[i][j] == Matrix[i - 1][j])
                    {
                        i--;
                    }
                    else
                    {
                        result = text2[i] + result;
                        i--;
                        j--;
                    }
                }
                else
                {
                    j--;
                }
            }

            Console.WriteLine(Matrix[rows][columns]);
            Console.WriteLine(result);
        }

    }
}

