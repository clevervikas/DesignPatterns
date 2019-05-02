﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
    class Singlton
    {
        static void Main(string[] args)
        {
            Singleton instance = Singleton.Instance;

        }
    }
}
