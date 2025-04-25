namespace CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<School> escoles = CarregarEscoles("SCHOOLS1.csv");
            escoles.AddRange(CarregarEscoles("SCHOOLS2.csv"));

            Dictionary<string, School> dictEscoles = new Dictionary<string, School>();
            foreach (var escola in escoles)
                dictEscoles[escola.Codi] = escola;

            //FER EL MENU
        }

        public static List<School> CarregarEscoles(string fileName)
        {
            List<School> llista = new List<School>();
            string linia;

            StreamReader sr = new StreamReader(fileName);

            sr.ReadLine();
            linia = sr.ReadLine();

            while (linia != null)
            {
                School escola = new School(linia);
                llista.Add(escola);

                linia = sr.ReadLine();
            }

            return llista;
        }

    }
}
