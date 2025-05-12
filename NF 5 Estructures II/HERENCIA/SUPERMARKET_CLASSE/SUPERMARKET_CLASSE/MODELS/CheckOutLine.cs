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
    }
}
