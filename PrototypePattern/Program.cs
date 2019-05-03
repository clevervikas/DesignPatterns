﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Prototype Pattern Demo***\n");
            //Base or Original Copy
            BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };

            BasicCar ford_base = new Ford("Ford Yellow") { Price = 500000 };
            BasicCar bc1;
            //Nano

            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.setPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", bc1.ModelName, bc1.Price);
            //Ford

            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.setPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}",
           bc1.ModelName, bc1.Price);
            Console.ReadLine();
        }
    }
}
