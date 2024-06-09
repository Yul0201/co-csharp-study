using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_This
{
    public class Character
    {
        //멤버변수 정의
        public string name;
        public int damage;
        public int hp;
        public int maxHp;

        //생성자
        public Character(string name, int damage, int maxHp)
        {
            //동일한 이름의 매개변수와 멤버변수를 구분함
            //멤버 엑세스 연산자를 사용해 멤버에 접근할 수 있음
            this.name = name;
            this.damage = damage;
            this.hp = maxHp;
            this.maxHp = maxHp;
        } 
        
        //공격하는 메서드 정의
        public void Attack(Character target)
        {
            Console.WriteLine("{0}이(가) {1}을(를) 공격합니다", this.name, target.name);
            target.Hit(this.damage);
        }

        //피해를 받는 메서드 정의
        public void Hit(int damage)
        {
            Console.WriteLine("{0}이(가) {1}만큼 피해를 받았습니다", this.name, damage);
            this.hp -= damage;
        }
    }
}
