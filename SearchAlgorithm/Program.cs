using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        //array to be searched
        int[] arr = new int[20];

        //number of elements in the array
        int n;

        //get the number of elements to store in the array
        int i;

        void input()
        {
            while (true)
            {
                Console.WriteLine("enter the number of element in the array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 20 element.\n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter array element");
            Console.WriteLine("-------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + i) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //Accept the number to be searched
                Console.Write("\n Enter element want you to search:");
                int item = Convert.ToInt32(Console.ReadLine());

                //Apply binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the middle elements
                int mid = (upperbound - lowerbound) / 2;
            }
        }
    }
}
