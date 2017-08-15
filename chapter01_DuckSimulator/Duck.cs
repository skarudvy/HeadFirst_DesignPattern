using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter01_DuckSimulator
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public FlyBehavior SetFlyBehavior
        {
            set
            {
                this.flyBehavior = value;
            }
        }

        public QuackBehavior SetQuackBehavior
        {
            set
            {
                this.quackBehavior = value;
            }
        }

        public Duck()
        {

        }

        public abstract void display();
        
        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("모든 오리는 물에 뜹니다. 가짜 오리도 뜨죠");
        }
    }
}
