using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPERMARKET_CLASSE.MODELS
{
    public class ShoppingCart
    {
        private Dictionary<Item, double> shoppingList;
        private Customer customer;
        private DateTime dateOfPurchase;

        public ShoppingCart(Customer customer, DateTime dateOfPurchase)
        {
            shoppingList = new Dictionary<Item, double>();
            customer.Active = true;
            this.customer = customer;
            this.dateOfPurchase = dateOfPurchase;
        }

        public void AddOne(Item item, double qty)
        {
            //if(Math.Floor(qty)==qty)  //implica que no té decimals
            //falta acabar

            //shoppingList.Add(item, qty);

            //millor mirar si el producte està a llista
            if (shoppingList.Keys.Contains(item))
                shoppingList[item] += qty;
            else
                shoppingList[item] = qty;
        }

        public void AddAllRandomly(SortedDictionary<int, Item> warehouse)
        {
            Random rand = new Random();
            int nProductes = rand.Next(10) + 1;

            for (int i = 0; i < nProductes; i++)
            {
                //seleccionar un producte aleatori
                int posItem = rand.Next(warehouse.Count);
                Item item = warehouse.ElementAt(posItem).Value;

                //seleccionar una quantitat aleatoria
                int quantitat = rand.Next(5) + 1;

                //afegir el nou producte
                AddOne(item, quantitat);

            }
        }

        public int RawPointsObtainedAtCheckout(double totalInvoiced)
        {
            //easy
            return 0;
        }

        public static double ProcessItems(ShoppingCart cart)
        {
            //fer un foreach per cada producte
            //falta acabar

            return 0;
        }


        public override string ToString()
        {
            StringBuilder carrito = new StringBuilder("*********\nINFO CARRITO DE COMPRA CLIENT->" + customer.FullName + "\n");
            foreach (KeyValuePair<Item, double> kvp in shoppingList)
            {
                carrito.Append($"{kvp.Key.Description,-20} - CAT-->{kvp.Key.GetCategory,-15} - QTY-->{kvp.Value,-3} - UNIT PRICE-->{kvp.Key.Price,-6}");
                if (kvp.Key.OnSale) carrito.Append("€(*)\n");
                else carrito.Append("€\n");
            }
            carrito.Append("*****FI CARRITO COMPRA****\n");
            return carrito.ToString();
        }

    }
}
