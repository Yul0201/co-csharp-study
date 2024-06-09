using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_classNew
{
    class Car
    {
        public string name; //속성 또는 필드 또는 멤버 변수 설정

        public void MoveForward() //멤버 메서드
        //멤버 변수와 멤버 메서드를 합쳐서 멤버라고 일컬음
        {
            Console.WriteLine("{0}이 전진 합니다", name);
        }
    }
}
