using System;

namespace OverRiding;
class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("annimals eats food");
    }
}
    public class Dog:Animal
    {
        public override void  Eat()
        {
            Console.WriteLine("Dog eat food");
            base.Eat();
            this.Eat();
        }
    }

    public class Pomerian:Dog
    {
        public override void Eat()
        {
            Console.WriteLine("Dod eats food");
             base.Eat();
        }
    }


class Program 
{ 
    public static void Main(string[] args)
   {
    Animal animal=new Animal();
    Dog dog=new Dog();
    Pomerian pomerian=new Pomerian();

    animal.Eat();
    dog.Eat();
    pomerian.Eat();

    
   }

}

