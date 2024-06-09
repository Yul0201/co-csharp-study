using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수 선언 또는 변수 정의
            //정수형 체력 변수를 정의해 봅시다
            int hp; // 같은 이름의 변수를 다시 정의할 수 없다
            //변수에 값 할당하는 방법 : = 연산자를 사용하며 같다라는 뜻이 아니라 오른쪽 값을 왼쪽 변수에 넣는 연산자 이다.
            hp = 10;

            //다음과 같이 변수를 정의하고 할당하는 것을 한번에 할 수도 있습니다.
            int damage = 5;
            // 변수에 할당된 값을 출력하는 방법
            Console.WriteLine(hp);
            Console.WriteLine(damage);

            //소수점 형식 변수 방어도를 선언 합니다
            float armor;
            armor = 3.5f; // 변수에 값을 할당. 소수점 형식은 접미사 f 를 값 뒤에 붙여줘야 합니다.
            //변수에 값을 출력하는 방법
            Console.WriteLine(armor);

            //문자열 형식 변수 이름을 정의합니다
            string name;
            //name 변수에 값을 할당
            name = "홍길동"; //문자열 형식 값은 " " 로 감싸준다
            // 변수의 값을 출력 해봅시다
            Console.WriteLine(name);

        }
    }
}
