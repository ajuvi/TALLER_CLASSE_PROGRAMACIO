using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPERMARKET_CLASSE.MODELS
{
    internal class Item:IComparable<Item>
    {

        public enum Category
        { BEVERAGE = 1, FRUITS, VEGETABLES, BREAD, MILK_AND_DERIVATES, GARDEN, MEAT, SWEETS, SAUCES, FROZEN, CLEANING, FISH, OTHER };
        public enum Packaging { Unit='U', Kg='K', Package='P' };

        public int CompareTo(Item? other)
        {
            throw new NotImplementedException();
        }

    }
}
