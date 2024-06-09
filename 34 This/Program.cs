using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this 는 클래스의 현재 인스턴스를 가리키는 키워드를 의미
            Character hong = new Character("Hong gil dong", 3, 10);
            Character lim = new Character("Lim guk jung", 2, 12);

            Console.WriteLine("name:{0},damage:{1}, hp:{2}/{3}", hong.name, hong.damage, hong.hp, hong.maxHp);
            Console.WriteLine("name:{0},damage:{1}, hp:{2}/{3}", lim.name, lim.damage, lim.hp, lim.maxHp);

            hong.Attack(lim);
            Console.WriteLine("name:{0},damage:{1}, hp:{2}/{3}", lim.name, lim.damage, lim.hp, lim.maxHp);
        }
    }
}
