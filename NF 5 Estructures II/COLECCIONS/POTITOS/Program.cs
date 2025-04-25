namespace POTITOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("JARS.txt");
            String linia;

            HashSet<string> si;
            SortedSet<string> no;

            linia = sr.ReadLine();
            while (linia != "0")
            {
                int numLinies = Convert.ToInt32(linia);

                si = new HashSet<string>();
                no = new SortedSet<string>();

                for(int i = 0; i < numLinies; i++)
                {
                    linia = sr.ReadLine();
                    string[] parts = linia.Split(" ");

                    for(int j = 1; j < parts.Length - 1; j++)
                    {
                        if (parts[0] == "SI:")
                            si.Add(parts[j]);
                        else
                            no.Add(parts[j]);
                    }
                }

                no.ExceptWith(si);

                foreach(string ingredient in no)
                    Console.Write(ingredient + " ");

                Console.WriteLine();

                linia = sr.ReadLine();
            }

        }
    }
}
