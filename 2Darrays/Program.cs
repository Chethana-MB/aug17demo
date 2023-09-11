using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darrays
{
     class Program
    {
        static void Main(string[] args)
        {
            //printing right angled triangle
            int i, j;
            for(i=1;i<=5;i++)
            {
                for(j=1;j<i;j++)
                {
                    Console.Write("{0,5}", j);
                }
                Console.WriteLine();
                    
            }
            int[,] aa = new int[3, 3]; // 3x3 matrix 22d array
            int[,,] aaa = new int[3, 3, 3];//3 dimensional array..
            //reading 2d array means aa
            Console.WriteLine("\n reading 2d array..");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("enter [{0},{1}] element :  ", i + 1, j + 1);
                    aa[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n printing 2d array..");
            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    Console.Write("{0,4}", aa[i, j]);

                }
                Console.WriteLine();
            }
            Console.ReadLine();




        }
    }
}
