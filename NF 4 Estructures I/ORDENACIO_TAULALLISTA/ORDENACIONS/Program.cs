using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORDENACIONS
{
    public class Program
    {
        static void Main(string[] args)
        {

            //ORDENAR UN ARRAY AMB EL MÈTODE BUBBLE SORT
            Console.WriteLine("ORDENAR ARRAY DE NUMEROS AMB BUBBLE SORT");
            Console.WriteLine("----------------------------------------");
            int[] nums = { 2, 1, 88, 3, 4, 55, 6, 7, 89 };

            MostrarArray(nums); 
            //Array.Sort(nums);
            BubbleSort(nums);
            MostrarArray(nums);

            //ORDENAR LA TAULA LLISTA AMB EL SEU MÈTODE SORT
            Console.WriteLine("ORDENAR UNA TAULA LLISTA AMB EL SEU SORT");
            Console.WriteLine("----------------------------------------");
            TaulaLlista<int> taula = new TaulaLlista<int>();
            taula.AddRange(new int[] { 2, 1, 88, 3, 4, 55, 6, 7, 89 });
            Console.WriteLine(taula);
            taula.Sort();
            Console.WriteLine(taula);





        }

        private static void BubbleSort(int[] nums)
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

        static void MostrarArray(int[] items)
        {
            Console.Write("[");
            for(int i = 0; i < items.Length;i++) {
                if(i==items.Length-1)
                    Console.Write(items[i]);
                else
                    Console.Write(items[i] + ", ");
            }
            Console.WriteLine("]");
        }
    }
}
