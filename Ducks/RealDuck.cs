using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class RealDuck : Duck
    {
        public RealDuck()
        {
            // 행동 정의
            flyBehavior = new CanFlyMode();
            quackBehavior = new Cackle();

            // 행동
            PerformFly();
            PerformQuack();
        }
    }
}
