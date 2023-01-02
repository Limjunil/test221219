using System;

namespace WhatIsInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car();
            //myCar.Go();


            // 부모 클래스가 구체적일수록 유연하지 못한 형태가 된다.
            //Sonata mySonata = new Sonata();
            //mySonata.Go();


            //Dog myDog = new Dog();
            //myDog.Eat();
            //myDog.Yelp(); // 다중 상속이 가능하다.

            WhatIsCollection desc = new WhatIsCollection();
            desc.collectionDesc();

        }
    }
}