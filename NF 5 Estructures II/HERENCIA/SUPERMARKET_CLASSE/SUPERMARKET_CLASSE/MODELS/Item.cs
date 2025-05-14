using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPERMARKET_CLASSE.MODELS
{
    public class Item:IComparable<Item>
    {
        public enum Category
        { BEVERAGE = 1, FRUITS, VEGETABLES, BREAD, MILK_AND_DERIVATES, GARDEN, MEAT, SWEETS, SAUCES, FROZEN, CLEANING, FISH, OTHER };
        public enum Packaging { Unit='U', Kg='K', Package='P'};

        private char currency = '\u20AC';
        private int code;
        private string description;
        private bool onSale;
        private double price;
        private Category category;
        private Packaging packaging;
        private double stock;
        private double minStock;

        public Item(int code, string description, bool onSale, double price, Category category, Packaging packaging, double stock, double minStock)
        {
            this.code = code;
            this.description = description;
            this.onSale = onSale;
            this.price = price;
            this.category = category;
            this.packaging = packaging;
            this.stock = stock;
            this.minStock = minStock;
        }

        public int Code { get => code; }
        public string Description { get => description; }

        public bool OnSale { get => onSale; }

        public Category GetCategory { get => category; }

        public double Price
        {
            get
            {
                if (OnSale) return 0.9 * this.price;
                else return this.price;
            }
        }

        public int CompareTo(Item? other)
        {
            throw new NotImplementedException();
        }

        public class ComparerStock : IComparer<Item>
        {
            public int Compare(Item x, Item y)
            {
                int result = 0;

                if (x == null && y == null) result = 0;
                else if (x == null) result = -1;
                else if (y == null) result = 1;
                else
                {
                    result = x.stock.CompareTo(y.stock);
                    if (result == 0) result = x.code.CompareTo(y.code);
                }
                return result;
            }
        }
    }
}
