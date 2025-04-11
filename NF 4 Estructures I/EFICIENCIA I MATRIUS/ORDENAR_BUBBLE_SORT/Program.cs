using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORDENAR_BUBBLE_SORT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10000;

            DateTime date1, date2;

            int[] nums = GeneraArray(N);

            date1 = DateTime.Now;
            BubbleSort(nums);
            date2 = DateTime.Now;

            MostrarTemps($"TEMPS AMB N = {N}", date1, date2);



        }

        public static int[] GeneraArray(int n)
        {
            int[] t = new int[n];
            for (int i = 0; i < n; i++)
            {
                t[i] = i + 1;
            }

            return t;
        }

        public static void BubbleSort(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    //if (nums[j] > nums[j + 1])
                    if (nums[j].CompareTo(nums[j + 1]) > 0)
                    {
                        int tempVar = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tempVar;
                    }
                }

            }
        }

        static void MostrarTemps(string title, DateTime tInici, DateTime tFinal)
        {
            Console.WriteLine(title + "\n---");
            TimeSpan interval = tFinal - tInici;
            Console.WriteLine("{0} - {1} = {2}", tFinal, tInici, interval.ToString());
            Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);
        }


    }
}
