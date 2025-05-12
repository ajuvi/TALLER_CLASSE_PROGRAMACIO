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
        Dictionary<string, Person> staff;
        Dictionary<string, Person> customers;
        SortedDictionary<int, Item> warehouse;

        public Supermarket(String name, String address, String fileCashiers, String fileCustomers, String fileItems, int activeLines)
        {
            this.name = name;
            this.address = address;
            linies = new CheckOutLine[activeLines];
            customers = LoadCustomers(fileCustomers);
            staff = LoadCashiers(fileCashiers);
            warehouse = LoadWarehouse(fileItems);
        }

        public SortedSet<Item> GetItemByStock()
        {
            SortedSet<Item> items;
            items = new SortedSet<Item>(warehouse.Values, new Item.ComparerStock());
            return items;
        }

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

    }

}
