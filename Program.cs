using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;
        private int n;

        void input()
        {
            while (true)
            {
                Console.Write("Masukkan Angka Di Element Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray mempunyai maskimal 20 element \n");
            }
            Console.WriteLine("\n=================");
            Console.WriteLine("Enter Array Element");
            Console.WriteLine("\n=================");

            for (int i = 0; i < n; i ++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }

        void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low < high)
                return;
            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                while ((arr[i] <= pivot) && (i <= high))
                    i++;
                cmp_count++;
                {
                }
                cmp_count++;
                if (i < j)
                {
                    swap(i, j);
                    mov_count++;
                }
            }

            q_sort(low, j - 1);

            q_sort(j + 1, high);
        }

        void display()
        {
            Console.WriteLine("\n----------------------");
            Console.WriteLine("\n Sorted array element ");
            Console.WriteLine("------------------------");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }
            Console.WriteLine("\nNumber of comparisons: " + cmp_count);
            Console.WriteLine("\nNumber of data movemenets:" + mov_count);
        }
    }
}
