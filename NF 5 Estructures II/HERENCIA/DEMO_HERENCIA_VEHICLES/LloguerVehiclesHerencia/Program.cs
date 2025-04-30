using System;
using System.Text;

namespace LloguerVehiclesHerencia
{
    public abstract class Vehicle : IComparable
    {
        protected static int codiBase = 0;
        public enum Categoria { Cotxe=1, Moto, Patinet, Bici };
        protected string codi;
        protected Categoria categoria;
        private string descripcio;
        private string matricula;
      

        public Vehicle(string desc,string mat)
            {
            
            this.descripcio = desc;
            this.matricula = mat;
            
            }
        public Categoria Category
        {
            get { return this.categoria; }
        }
        public abstract double CostDiari
        {
            get;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Descripcio { get => descripcio; set => descripcio = value; }
        public int CompareTo(object obj)
        {
            int resultat;
            if (!(obj is Vehicle)) throw new Exception("NO ES POT COMPARAR");
            Vehicle vParam = (Vehicle)obj;
            resultat = this.categoria.CompareTo(vParam.Category);
            if (resultat == 0) resultat = CostDiari.CompareTo(vParam.CostDiari);
            return resultat;
        }
        protected string NextCodi(char c)
        {
            int codiNum;
            string codiStr ;
            StringBuilder codi = new StringBuilder();
            codi.Append(c+"-");
            codiNum = ++codiBase;
            codiStr = "" + codiNum;
            codi.Append(codiStr.PadLeft(3, '0'));
            return codi.ToString();
        }
        public override string ToString()
        {
            return "CODI -->" + this.codi + "\nDESCRIPCIÓ-->" + this.descripcio +
                "\nCATEGORIA -->" + this.categoria;
        }

    }
    public class VehicleC : Vehicle  
    { 
        public enum TipusCarburant { Diesel=1, Benzina};
        private TipusCarburant carburant;
        private int capacitat;

        public override double CostDiari
        {
            get { return 50; }        
        }
        
        public TipusCarburant Carburant { get => carburant;  }

        public VehicleC(Categoria cat, string desc, string mat, TipusCarburant carbu, int capa)
            :base(desc,mat)
        {
            if (cat == Categoria.Bici || cat == Categoria.Patinet)
                throw new Exception("BICIS O PATINETS NO PODEN PORTAR MOTOR DE COMBUSTIÓ");
            this.categoria = cat;
            this.carburant = carbu;
            this.capacitat = capa;
            this.codi = NextCodi('C');
        }

        
        public override string ToString()
        {
            return base.ToString() + "\nCAPACITAT-->" + this.capacitat + "\nCARBURANT-->" + this.carburant;
        }
    }
    public class VehicleE : Vehicle
    {
        
        private int minutsAutonomia;
        private int minutsCarrega;
        public VehicleE( Categoria cat,string desc, string mat,  int autonomia,int carrega)
            : base( desc, mat)
        {
            this.categoria = cat;
            this.minutsAutonomia =autonomia;
            this.minutsCarrega=carrega;
            this.codi = NextCodi('E');
        }
        public override double CostDiari
        {
            get { return 23; }
        }
        public int MinutsAutonomia { get => minutsAutonomia;  }
        public override string ToString()
        {
            
            return base.ToString() + "\nAUTONOMIA-->" + this.MinutsAutonomia ;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle tesla = new VehicleE(Vehicle.Categoria.Cotxe, "TESLA X2", "2322KLM", 400, 200);
            Console.WriteLine(tesla.Category.ToString());
            Console.WriteLine(tesla);
            Vehicle seatElectric = new VehicleE(Vehicle.Categoria.Cotxe, "SEAT LEON ELECTRIC", "4332-FGS", 500, 300);
            Console.WriteLine(seatElectric);
            Vehicle patinetElectric = new VehicleE(Vehicle.Categoria.Patinet, "PATINET XIAOMI", "XXX",80, 60);
            Console.WriteLine(patinetElectric);
            Vehicle peugeot = new VehicleC(Vehicle.Categoria.Cotxe, "PEUGEOT 506 D", "5678-FCT", VehicleC.TipusCarburant.Diesel, 5);
            Console.WriteLine(peugeot);
        }
    }
}
