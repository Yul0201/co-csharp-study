using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07boolcharobject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //데이터 타입 bool(참거짓), char(문자열 '' 로 할당), object(어떤 값이든 넣을 수 있다)
            //bool 형식 변수 선언 및 값 할당
            bool isLucky = true;

            //변수에 값 할당
            isLucky = false;

            //출력
            Console.WriteLine(isLucky); //변수에 값을 넣으면 이전에 있던 값(true)는 사라집니다.


            //char 형식 변수 선언
            char word;
            //값 할당
            word = 'a';
            //출력
            Console.WriteLine(word);


            //object 형식 변수 선언
            object obj;
            //모든 값을 넣을 수 있다 (할당 가능)
            obj = 100;       //정수 int
            obj = 12.3f;     //소수점 float
            obj = "홍길동";   //문자열 string
            obj = true;      //논리형 bool
            obj = '김';      //문자영식 char       

            //출력
            Console.WriteLine(obj);
        }
    }
}
