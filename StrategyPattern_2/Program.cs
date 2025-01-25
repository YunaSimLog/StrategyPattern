
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 컨텍스트 생성
            Context context = new Context();

            // 2. 전략 설정
            context.SetStrategy(new ConcreteStrategyA());

            // 3. 전략 실행
            context.DoSomething();

            // 4. 다른 전략 설정
            context.SetStrategy(new ConcreteStrategyB()); 

            // 5. 다른 전략 실행
            context.DoSomething();  
        }
    }

    /// <summary>
    /// 전략 (추상화된 알고리즘)
    /// </summary>
    interface IStrategy
    {
        void DoSomething();
    }

    /// <summary>
    /// 전략 알고리즘 A
    /// </summary>
    class ConcreteStrategyA : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("전략 알고리즘 A의 행동");
        }
    }

    /// <summary>
    /// 전략 알고리즘 B
    /// </summary>
    class ConcreteStrategyB : IStrategy
    {
        public void DoSomething()
        {
            Console.WriteLine("전략 알고리즘 B의 행동");
        }
    }

    /// <summary>
    /// 컨텍스트 (전략 등록/실행)
    /// </summary>
    class Context
    {
        IStrategy _strategy; // 전략 인터페이스를 합성(Composition)

        // 전략 교체 메서드
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // 전략 실행 메소드
        public void DoSomething()
        {
            _strategy.DoSomething();
        }
    }
}
