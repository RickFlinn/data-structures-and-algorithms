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

            Console.Write("Output : " + shelter.Dequeue().ToString());
            Console.Write(", " + shelter.Dequeue("cat").ToString());
            Console.Write(", " + shelter.Dequeue("dog").ToString());
            Console.Write(", " + shelter.Dequeue().ToString());
            Console.Write(", " + shelter.Dequeue().ToString());
            Console.WriteLine(", " + shelter.Dequeue().ToString());
            Console.WriteLine("Expected: Cat, Cat, Dog, Dog, Dog, Cat");
        }
    }
}
