using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Method
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Syntax
            //접근제한자 반환타입 메서드이름()
            //접근제한자 : public(어디서나 접근 가능), private(클래스 내부에서만 접근 가능_접근제한자를 명시하지 않을 경우 기본은 private)
            //반환타입 : 값을 반환하지 않으면 void
            //메서드이름 : 식별하기 위한 고유한 이름
            //{
            //실행할 명령문
            //}
            
            SayHello(); //main 메소드안에서 SayHello 메서드를 호출하는 방식
                        //메서드 함수에 오류가 날경우 메소드 정의부에 static 키워드를 넣을 것 (이유는 30rkd 클래스와 new 연산자에서 확인필요)
        }

        //클래스 내부에 선언해야 하면 Main 메서드 아래에 메서드 정의함
        static void SayHello( )
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hi");
            Console.WriteLine("Good Day");
        }
        
    }
}
