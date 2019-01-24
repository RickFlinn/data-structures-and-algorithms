using System;
using Animal_Shelter_Challenge.Classes;

namespace Animal_Shelter_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            FIFOAnimalShelter();
        }

        public static void FIFOAnimalShelter()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Cat());

            Console.WriteLine(shelter.Dequeue().GetType().ToString());
            Console.WriteLine(shelter.Dequeue("cat").GetType().ToString());
            Console.WriteLine(shelter.Dequeue("dog").GetType().ToString());
            Console.WriteLine(shelter.Dequeue().GetType().ToString());
            Console.WriteLine(shelter.Dequeue().GetType().ToString());
            Console.WriteLine(shelter.Dequeue().GetType().ToString());
            Console.WriteLine("Above should be: Cat, Cat, Dog, Dog, Dog, Cat");
        }
    }
}
