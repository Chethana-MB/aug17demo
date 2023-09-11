using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Customer
    {
        public int CustomerId { set; get; }
        public string CustomerName { set; get; }
    }
     class Program
    {
        static void printarray(int[] aa)
        {
            for(int i = 0;i<aa.Length;i++)
            {
                Console.WriteLine("{0,4}", aa[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int i, j, sum = 0;
            //reading array
            for(i=0;i<a.Length;i++)
            {
                Console.Write("enter element {0} : ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            //print the array
            printarray(a);
            Console.WriteLine("\n finding sum of elements in array..");
            for(i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("the sum of elements is " + sum);
            Console.WriteLine("\n enter the element to be searched in array");
            int elementsearch = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(i=0;i<a.Length;i++)
            {
                if (a[i]==elementsearch)
                {
                    Console.WriteLine("the ele {0} is found at position {1}", elementsearch, i + 1);
                    flag = 1;
                    break;

                }
            }
            if(flag==0)
            {
                Console.WriteLine("the element is not there in array");
            }
            Console.WriteLine("\n sorting the array");
            for(i=0;i<a.Length-1;i++)
                for(j=i+1;j<a.Length;j++)
                {
                    for(j=i+1;j<a.Length;j++)
                    {
                        if (a[i] > a[j])
                        {
                            int temp;
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
            Console.WriteLine("after sorting printing the array...");
            printarray(a);
            Customer[] clist = new Customer[3];
            Console.WriteLine("\n reading customers..");
            for(i=0;i<clist.Length;i++)
            {
                Console.Write("\n enter customer {0} details:", i + 1);
                Customer cc = new Customer();
                Console.Write("\n enter customer id :");
                cc.CustomerId = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n enter customer name :");
                cc.CustomerName = Console.ReadLine();
                clist[i] = cc;


            }
            Console.WriteLine("\n printing customers...");
            foreach(Customer cc in clist)
            {
                Console.WriteLine("{0}--{1}", cc.CustomerId, cc.CustomerName);
            }
            
            Console.ReadLine();
            
            

        }
    }
}
