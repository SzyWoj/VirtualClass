namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Sound();
            cat.Sound();

        }
    }

    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }

    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("The cat goes *miau*");

        }
    }
}