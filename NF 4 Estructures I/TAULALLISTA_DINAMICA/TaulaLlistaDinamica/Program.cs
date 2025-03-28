namespace TaulaLlistaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaulaLlistaD<int> taula = new TaulaLlistaD<int>();

            Console.WriteLine(taula);
            
            taula.Add(5);
            taula.Add(7);
            taula.Add(3);
            taula.Add(4);

            Console.WriteLine(taula);

            Console.WriteLine();

            foreach(int num in taula)
            {
                Console.Write($"[{num}] ");
            }


            /*TaulaLlistaD<int> nums = new TaulaLlistaD<int>();
            for (int i = 0; i < 20; i++)
                nums.Add(i%10);

            Console.WriteLine("\nMOSTRAR LA LLISTA INICIAL AMB EL TOSTRING");
            Console.WriteLine(nums);

            Console.WriteLine("\nMOSTRAR LA LLISTA INICIAL AMB UN FOREACH");
            foreach(int num in nums) Console.Write(num + " ");

            Console.WriteLine("\n\nMOSTRAR LA LLISTA INICIAL AMB ITERADOR");
            IEnumerator<int> iterador = nums.GetEnumerator();
            while(iterador.MoveNext()) Console.Write(iterador.Current + " ");

            Console.WriteLine("\n\nELIMINAR UN 0");
            nums.Remove(0);
            Console.WriteLine(nums);

            Console.WriteLine("\nELIMINAR UN ALTRE 0");
            nums.Remove(0);
            Console.WriteLine(nums);

            Console.WriteLine("\nELIMINAR EL PRIMER ELEMENT");
            nums.RemoveAt(0);
            Console.WriteLine(nums);

            Console.WriteLine("\nELIMINAR L'ULTIM ELEMENT");
            nums.RemoveAt(nums.Count-1);
            Console.WriteLine(nums);

            Console.WriteLine("\nELIMINAR LA LLISTA");
            nums.Clear();
            Console.WriteLine(nums);*/
        }
    }
}
