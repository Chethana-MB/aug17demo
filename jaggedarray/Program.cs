using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jgarray = new int[4][];//this is jagged array
            int i, j;
            jgarray[0] = new int[2] { 12, 45 };
            jgarray[1] = new int[1] { 100 };
            jgarray[2] = new int[5] { 12, 34, 55, 66, 71 };
            jgarray[3] = new int[3] { 100, 200, 300 };
            Console.WriteLine("\n displaying jagged array..");
            for(i=0;i<jgarray.Length;i++)
            {
                Console.WriteLine("\n Row {0}", i + 1);
                for (j = 0; j < jgarray[i].Length;j++)
                {
                    Console.Write("{0,6}", jgarray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
