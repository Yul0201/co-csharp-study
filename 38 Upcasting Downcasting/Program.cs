using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Upcasting_Downcasting

{

    internal class Program

    {

        static void Main(string[] args)

        {

            //업캐스팅(암시적) : 인스턴스의 타입을 파생 클래스 타입에서 기본 클래스 타입으로 변환

            //다운캐스팅(명시적) : 인스턴스의 타입을 기본 클래스 타입에서 파생 클래스 타입으로 변환(부모 타입의 인스터스 생성 후 자식 타입으로 다운캐스팅 하면 안됨)

            //is 연산자 : 식의 런타임 형식이 지정된 형식과 호환되는지 확인

            //as 연산자 : 런타임 형식이 지정된 형식과 호환되는 경우 식을 해당 형식으로 명시적으로 변환. 변환할 수 없는 경우 as 연산자가 null 반환. 캐스트 식과 달리 as 연산자는 예외를 throw 하지 않음


            //Marine marine = new Marine();

            //marine.Attack();

            //marine.StimPack();



            //업캐스팅(암시적)
            //TerranUnit unit = new Marine();
            //unit.Attack();
            //unit.StimPack(); TerranUnit 클래스에는 StimPack 메서드가 정의되어 있지 않음. 호출불가


            //업캐스팅(명시적) - 다음과 같이 캐스트 식을 사용해서 명시적으로 업캐스팅 가능
            //TerranUnit unit = (TerranUnit)new Marine();
            //unit.Attack();
            //unit.StimPack();StimPack 메서드 호출 불가


            //다운태스팅(명시적)
            //TerranUnit unit = new Marine(); //암시적 업캐스팅
            //Marine marine = (Marine)unit; //unit 의 변수값을 marine의 변수값에 할당하며 이것이 다운 캐스팅. 캐스트 식으로 변환. 명시적 다운캐스팅
            //marine.Attack();
            //marine.StimPack(); //호출 가능

            //주의사항
            //부모 클래스의 인스턴스 생성 후 자식 클래스 타입으로 다운캐스팅 할 수 없습니다.
            //Marine marine = (Marine)new TerranUnit(); //다운캐스팅은 명시적이어야 함
            //marine.Attack();
            //marine.StimPack();

            //is연산자를 사용해서 형식 변환이 가능한지 테스트 할 수 있음
            //TerranUnit unit = new TerranUnit();
            //bool canDownCast = unit is Marine;
            //Console.WriteLine(canDownCast);  //false

            //Marine marine = new Marine();
            //bool canUpCast = marine is TerranUnit;
            //Console.WriteLine(canUpCast); //true
            //TerranUnit unit = marine; //암시적 업캐스팅

            //TerranUnit unit = new Marine();
            //bool canDownCast = unit is Marine;
            //Console.WriteLine(canDownCast); //true
            //Marine marine = (Marine)unit; //명시적 다운 캐스팅

            //as 연산자를 사용해 명시적으로 캐스팅 하기
            //Marine marine = new Marine;
            //TerranUnit unit = marine as TerranUnit; //명시적 업캐스팅
            //Console.WriteLine(unit); //성공

            TerranUnit unit = new TerranUnit();
            Marine marine = unit as Marine;
            Console.WriteLine("marine: {0}", marine); //변환 실패 하면 결과값은 null. 예외 발생시키지 않음

        }

    }

}