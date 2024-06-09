using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //홍길동님 안녕하세요 출력
            //Console.WriteLine("홍길동님 안녕하세요");
            //이름이 변경될 수 있으므로 "홍길동" 문자열 값을 변수에 할당
            //문자열 변수 name 선언


            //string name; //변수정의
            //name = "홍길동"; //변수에 값 할당
            //Console.WriteLine(name); //변수 값 출력

            //출력문 하나로 "홍길동님 안녕하세요" 출력하기
            //Console.WriteLine($"{name}님 안녕하세요."); //$와{ 사이에 공백 불가

            //여러 변수의 있는 값도 가능
            //출력문으로 33세 홍길동님 안녕하세요 출력하기
            //나이는 변하므로 변수할당
            //정수형 age 변수 선언
            //int age;
            //age = 33;
            //Console.WriteLine($"{age}세 {name}님 안녕하세요");

            //다른 방법
            string name = "홍길동";  //변수 선언 및 초기화
            int age = 33;           //변수 선언 및 초기화
            Console.WriteLine("{0}세 {1}님 안녕하세요", age, name);



        }    
    }
}
