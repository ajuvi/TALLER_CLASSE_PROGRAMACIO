using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPERMARKET_CLASSE.MODELS
{
    public class CheckOutLine
    {
        private int number;
        private Queue<ShoppingCart> queue;
        private Person cashier;
        private bool active;

        public int Number { get => number; set => number = value; }
        public Person Cashier { get => cashier; set => cashier = value; }
        public bool Active { get => active; set => active = value; }

        public CheckOutLine(Person responsible, int number, bool active)
        {
            queue = new Queue<ShoppingCart>();
            this.cashier = responsible;
            this.number = number;
            this.active = active;
        }

        public CheckOutLine(int number) : this(null, number, false)
        { }


    }
}
