using System;

namespace InheritancePrac32
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        public new void Eat()
        {
            Console.WriteLine("허겁지겁 먹습니다.");
        }

        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다.");
        }

        public void TestB()
        {
            //Private();
            Protected();
            Public();
        }
    }
}