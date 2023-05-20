﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Cackle : IQuackBehavior
    {
        public void Quak()
        {
            Console.WriteLine("꽥꽥");
        }
    }

    public class BeepBeep : IQuackBehavior
    {
        public void Quak()
        {
            Console.WriteLine("삑삑");
        }
    }

    public class NoSound : IQuackBehavior
    {
        public void Quak()
        {
            Console.WriteLine("...");
        }
    }
}
