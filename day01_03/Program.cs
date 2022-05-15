using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using day01_03ex;

namespace day01_03ex
{
    // c#에서는 extands가 아닌 : 를 통해 상속을 받으며, 다중상속을 지원하지 않는다.
    class motherclass01
    {
        public bool power01;
        public int num01;
        public string string01;

        public void println01()
        {
            Console.WriteLine("부모함수출력");
        }
        public void Boot01()
        {
            Console.WriteLine("부모함수출력1");
        }
        public void Shutdown01()
        {
            Console.WriteLine("부모함수출력2");
        }
        public void Reset01()
        {
            Console.WriteLine("부모함수출력3");
        }
    }
    class childclass01 : motherclass01
    {
        bool fingerscan;

        public void println01()
        {
            Console.WriteLine("자식함수출력");
        }
        public void Closelid01()
        {
            Console.WriteLine("자식함수출력1");
        }
    }

    class childclass02 : motherclass01
    {

    }
}
namespace day01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            day01_03ex.motherclass01 m1 = new day01_03ex.motherclass01();
            m1.println01();

            day01_03ex.childclass01 c1 = new day01_03ex.childclass01();
            c1.println01();
            c1.Boot01();

            motherclass01 m2 = c1; //자식클래스를 부모타입으로 형변환(암시적))
            m2.println01();

            motherclass01 m3 = new motherclass01();
            Object obj3 = m3;
            motherclass01 m4 = obj3 as motherclass01;
            
        }
    }
}
