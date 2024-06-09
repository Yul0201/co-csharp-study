using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_MethodParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSum(3, 7); // 메서드 호출, 3과 7은 인자값(=인수)으로 int a는 3, int b 에는 7이 할당
        }

        static void PrintSum(int a, int b) //메서드 정의, int a와 int b 는 매개변수
        {
            Console.WriteLine(a + b);
        }
    }
}
