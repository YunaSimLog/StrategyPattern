using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class RubberDuck:Duck
    {
        public RubberDuck()
        {
            flyBehavior = new CanNotFlyMode();
            quackBehavior = new BeepBeep();

            PerformFly();
            PerformQuack();
        }
    }
}
