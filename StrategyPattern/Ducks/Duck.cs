using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public void PerformFly()
        {
            flyBehavior.fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
    }
}
