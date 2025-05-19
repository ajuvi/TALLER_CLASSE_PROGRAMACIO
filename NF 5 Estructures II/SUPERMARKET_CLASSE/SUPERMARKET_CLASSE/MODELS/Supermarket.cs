using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPERMARKET_CLASSE.MODELS
{
    public class Supermarket
    {
        const int MAXLINES = 5;

        private string name;
        private string address;
        private int activeLines;
        private CheckOutLine[] linies;
        private Dictionary<string, Person> staff;
        private Dictionary<string, Person> customers;
        private SortedDictionary<int, Item> warehouse;

        public Supermarket(String name, String address, String fileCashiers, String fileCustomers, String fileItems, int activeLines)
        {
            this.name = name;
            this.address = address;
            this.activeLines = 0;

            customers = LoadCustomers(fileCustomers);
            staff = LoadCashiers(fileCashiers);
            warehouse = LoadWarehouse(fileItems);

            linies = new CheckOutLine[MAXLINES];

            for(int i = 0; i < linies.Length; i++)
            {
                linies[i] = new CheckOutLine(i+1);
                if (i < activeLines) OpenCheckOutLine(i+1);
            }
        }

        public void OpenCheckOutLine(int line2Open)
        {
            line2Open--;
            if (line2Open < 0 || line2Open >= MAXLINES) throw new Exception("NUMERO DE LINIA INCORRECTE.");
            if (!linies[line2Open].Active)
            {
                linies[line2Open].Active = true;
                linies[line2Open].Cashier = GetAvailableCashier();
                linies[line2Open].Cashier.Active = true;

                activeLines++;
            }
        }

        private void OpenCheckoutLine(int numnLinia)
        {
            throw new NotImplementedException();
        }

        public SortedSet<Item> GetItemByStock()
        {
            SortedSet<Item> items;
            items = new SortedSet<Item>(warehouse.Values, new Item.ComparerStock());
            return items;
        }

        public List<CheckOutLine> GetLines { get => linies.ToList<CheckOutLine>(); }
        public Dictionary<string, Person> Staff { get => staff; }
        public Dictionary<string, Person> Customers { get => customers; }
        public SortedDictionary<int, Item> Warehouse { get => warehouse; }
        public int ActiveLines { get => activeLines; }

        public Person GetAvailableCustomer()
        {
            Person client = null;
            int pos = 0; bool trobat = false;

            //buscar el client
            while(!trobat && pos < customers.Count)
            {
                client = customers.ElementAt(pos).Value;
                if (client.Active) pos++;
                else trobat = true; 
            }

            //retornar el client
            if (!trobat) client = null;
            return client;
        }

        public Person GetAvailableCashier()
        {
            return null;
        }

        private Dictionary<string, Person> LoadCashiers(string fileName)
        {
            return null;
        }
        private Dictionary<string, Person> LoadCustomers(string fileName)
        {
            return null;
        }
        private SortedDictionary<int, Item> LoadWarehouse(string fileName)
        {
            return null;
        }

        public SortedSet<Item> GetItemsByStock()
        {
            SortedSet<Item> itemsByStock = new SortedSet<Item>(warehouse.Values, new Item.ComparerStock());
            return itemsByStock;
        }

    }

}
