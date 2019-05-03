using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public string ModelName;
        public int Price;

        public static int setPrice()
        {
            int Price = 0;
            Random r = new Random();
            Price = r.Next(200000, 500000);
            return Price;
        }

        public abstract BasicCar Clone();
    }
}

