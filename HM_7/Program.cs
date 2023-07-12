namespace HM_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("Generic Animal");
            Animal cat = new Cat("Whiskers");
            Animal dog = new Dog("Buddy");

            Console.WriteLine(animal1.GetName());
            animal1.MakeSound();

            Console.WriteLine(cat.GetName());
            cat.MakeSound();

            Console.WriteLine(dog.GetName());
            dog.MakeSound();
        }
    }
}