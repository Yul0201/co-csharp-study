using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수가 선언된 후에 다시 선언되거나 다른 형식 값 할당 불가
            //형식이 변수의 형식으로 암시적으로 변환되는 경우는 예외
            //예를 들어 string은 int로 암시적으로 변환 불가
            //암시적 변환- 변환은 항상 성공하고 특수 구문 필요없음
            //명시적 변환-  캐스트 식이 필요

            

            int n = 10; //정수형 변수에는 정수값만 할당 가능
            string name = "홍길동";
            n = "임꺽정";


            int hp = 12;
            float damage = 12.3f;

            hp = (int)12.3f; //명시적 변환, (int)-> 캐스트 식
            damage = 23;     //암시적 변환

            //정수를 실수로 변환
            int hp = 12;
            float temp = Convert.ToSingle(hp); //(hp) 정수값이고 Convert.ToSingle(hp) = 12.0f 로 변환

            //실수를 정수로 변환
            float damage = 12.3f
            int myDamage = Convert.ToInt32(damage); //반올림해서 값을 생성, 짝수로 반환
            Console.WriteLine(myDamage);

            //정수를 문자열로 변환
            int hp = 10;
            string strHp = Convert.ToString(hp);
            Console.WriteLine(strHp);
            
            //문자열을 정수로 변환
            string str = "123"; // "123hong" -> error 발생
            int num = Convert.ToInt32(str); //문자열에 포함되어 잇는 숫자형식만 가능

            //실수를 문자열로 변환
            float damage = 5.4f;
            string temp = damdage.ToString(); //Convert.ToString(damage); 와 동일

            //문자열을 실수로 변환
            string str = "12.3"; //숫자형식 문자열이 아니면 error 발생
            float num = Convert.ToSingle(str);

            //정수를 문자로 변환
            int a = 65; //아스키코드표 참고 필요
            char word =Convert.ToChar(a);
            Console.WriteLine(word);

            //문자를 정수로 변환
            char word = '홍';                //유니코드표 참고
            int num = word;                  //암시적 변환
            int num =Convert.ToInt32(num);   //명시적 변환
            Console.WriteLine(num) ;
        }
    }
}
