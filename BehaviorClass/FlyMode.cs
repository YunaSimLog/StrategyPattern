using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CanFlyMode : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("날다");
        }
    }

    public class CanNotFlyMode:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("못 난다");
        }
    }
}
