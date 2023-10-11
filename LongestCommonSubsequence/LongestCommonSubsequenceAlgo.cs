using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonSubsequence
{
    public class LongestCommonSubsequenceAlgo
    {
        /// <summary>
        /// Complexity==> O(m^n) because of nested loop rows*columns
        /// 1- topcell=matrix[i-1,j], leftcell=matrix[i][j-1], topleftcorner=matrix[i-1][j-1]
        /// 2- if not match:
        ///    2.1- cellvalue= max(topcell, leftcell)
        /// 3- if match:
        ///    3.1- cellvalue= 1+ topleftcornercell
        /// </summary>
        /// <param name="text1">the string</param>
        /// <param name="text2">the acutal chars </param>
        public static void LongestCommonSubsequence(string text1, string text2)
        {
            int columns = text1.Length;
            int rows = text2.Length;

            text1 = " " + text1; // to solve the part of the first row and column = zeros
            text2 = " " + text2;

            int[][] Matrix = new int[rows + 1][];
            for (int i = 0; i <= rows; i++) //construct table matrix each row has array of columns+1
            {
                Matrix[i] = new int[columns + 1];
            }
            //rows=> n
            for (int i = 1; i <= rows; i++) //start from 1 because 0 is a workaround to the start of left ad top zeros
            {
                for (int j = 1; j <= columns; j++) //columns=>m
                {
                    if (text2[i] == text1[j]) // if match
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
        /// <summary>
        /// 1- from the bottom right
        /// 2- if currentvalue > leftvalue
        ///    2.1- if currentvalue == topvalue //currentvalue inherited from top
        ///        2.1.1- move to top row
        ///    2.2- else //currentvalue is origin of match
        ///        2.2.1- add the char to the solution 
        ///        2.2.2- move to top row
        ///        2.2.3- move o left column
        /// 3- move to left column
        /// </summary>
        /// <param name="Matrix">the constructed Matrix</param>
        /// <param name="text2">the acutal chars</param>
        /// <param name="columns"></param>
        /// <param name="rows"></param>
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

