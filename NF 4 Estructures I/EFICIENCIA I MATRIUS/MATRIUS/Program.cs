using System.Text;

namespace MATRIUS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[,] t2 = new int[N, N];

            OmplirMatriu(t2);
            MostrarMatriu(t2);
        }

        static void OmplirMatriu(int[,] matriu)
        {
            int files = matriu.GetLength(0);
            int columnes = matriu.GetLength(1);

            int num = 1;

            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < columnes; j++)
                {
                    matriu[i, j] = num;
                    num++;
                }
            }
        }

        public static void OmplirMatriuRandom(int[,] matriu)
        {
            Random rand = new Random();

            int files = matriu.GetLength(0);
            int columnes = matriu.GetLength(1);

            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < columnes; j++)
                {
                    matriu[i, j] = rand.Next(0, 101);
                }
            }
        }

        public static void MostrarMatriu(int[,] matriu)
        {
            int files = matriu.GetLength(0);
            int columnes = matriu.GetLength(1);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < files; i++)
            {
                for (int j = 0; j < columnes; j++)
                {
                    sb.Append(matriu[i, j]).Append('\t');
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }

        public static long SumaColumna(int[,] matriu2D, int columna)
        {
            long suma = 0;
            for (int i = 0; i < matriu2D.GetLength(0); i++)
            {
                suma = suma + matriu2D[i, columna];
            }
            return suma;
        }

        public static long SumarElements(int[,] matriu2D)
        {
            long suma = 0;
            for (int i = 0; i < matriu2D.GetLength(0); i++)
            {
                for (int j = 0; j < matriu2D.GetLength(1); j++)
                {
                    suma = suma + matriu2D[i, j];
                }
            }
            return suma;
        }

    }
}
