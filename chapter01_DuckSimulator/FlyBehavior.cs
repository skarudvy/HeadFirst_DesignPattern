using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter01_DuckSimulator
{
    public interface FlyBehavior
    {
        void fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("날고 있어요");
        }
    }
    
    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("저는 못 날아요");
        }
    }

    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("로켓 추진으로 날아갑니다");
        }
    }
}
