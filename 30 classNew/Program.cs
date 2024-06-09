using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_classNew
{ //클래스는 사용자 정의 형식이며 객체를 생성하기 위해 변수와 메서드를 정의하는 틀
    
    class Program
    {
        
        static void Main(string[] args)
        {
            //Car 인스턴스를 담는 변수 선언
            //변수타입 변수명
            //자동차 (Car) 인스턴스를 할당할 예정이므로 변수 타입은 Car임

            //변수 선언
            Car car;

            //변수에 값(Car 클래스의 인스턴스) 할당
            // = 는 같다라는 뜻이 아니라 오른쪽 값을 왼쪽 변수에 할당하는 연산자
            Car car = new Car();

            //car 변수의 name 속성(멤버변수)에 값 할당
            //자동차 이름 설정하기
            //car 변수이름을 적고 속성명(name)을 적어줍니다.
            //다음과 같이 에러 메시지가 보이면 커서 활용해서 확인
            //보호 수준 때문에 액세스를 할수 없다라고 나오면 class 의 private 확인할 것
            //name 속성의 접근 제한자를 public 으로 변셩하고 문자열 값을 할당 합니다.
            car.name = "싼타페";

            //car 변수에 . 을 찍고 클래스에 정의되어 있는 메서드를 호출합니다.
            car.MoveForward();


            //새로운 Car 객체를 생성하고 새 변수에 할당 합니다.
            Car car2 = new Car();
            //속성을 설정하고 
            car2.name = "쏘렌토";
            //메서드를 호출
            car2.MoveForward();

            //클래스로부터 생성된 인스턴스(객체)는 독립적임
        }
    }
}
