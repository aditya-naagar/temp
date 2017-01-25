using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIT_OCW_6._006
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Wrold !");
            int[] arr = { 3, 4, 2, 8, 0, 7, 6, 0, 10, 12, 13, 3 };
            int start = 0, end = arr.Length, mid = arr.Length / 2;
            while (true)
            {
                mid = (start + end) / 2;
                if (mid == 0 || mid == arr.Length)
                {
                    System.Console.WriteLine("Mid: " + mid + " Element: " + arr[mid]);
                    break;
                }
                if (arr[mid - 1] > arr[mid])
                {
                    end = mid;
                    if (end < 0)
                    {
                        System.Console.WriteLine("First Element.");
                        break;
                    }
                }
                else if (arr[mid + 1] > arr[mid])
                {
                    start = mid;
                    if (start >= arr.Length)
                    {
                        System.Console.WriteLine("Last Element.");
                        break;
                    }
                }
                else
                {
                    System.Console.WriteLine("Ans position:" + mid);
                    break;
                }
            }

            System.Console.ReadLine();
        }
    }
}
