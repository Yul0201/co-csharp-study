using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _19_MethodReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pi = GetPI();
            Console.WriteLine(pi);
        }

        static float GetPI() // 반환 값의 타입이 소수점이므로 float 로 변경
        {
            return 3.14f; // return 문은 값을 반환하고 메서드를 즉시 종료함
        }
    }
}
