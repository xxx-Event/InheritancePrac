using System;

namespace InheritancePrac32
{
    /// <summary>
    /// 고양이 클래스
    /// </summary>
    public abstract class Cat : Animal
    {
        public Cat()
        {
        }

        public Cat(int age) : base(age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("자박자박 먹습니다.");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}