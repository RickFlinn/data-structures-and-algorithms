using System;
using Xunit;
using Animal_Shelter_Challenge.Classes;

namespace Animal_Shelter_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueuesDogs()
        {
            AnimalShelter shelter = new AnimalShelter();
            Assert.True(shelter.Enqueue(new Dog()));
        }

        [Fact]
        public void EnqueuesCats()
        {
            AnimalShelter shelter = new AnimalShelter();
            Assert.True(shelter.Enqueue(new Cat()));
        }

        [Fact]
        public void EnqueuesOnlyDogOrCat()
        {
            AnimalShelter shelter = new AnimalShelter();
            Assert.False(shelter.Enqueue(new Animal()));
        }

        [Fact]
        public void DequeuePrefDog()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            Assert.Equal("Dog", shelter.Dequeue("dog").ToString());
        }

        [Fact]
        public void DequeuePrefCat()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            Assert.Equal("Dog", shelter.Dequeue("dog").ToString());
        }

        [Fact]
        public void DequeuePrefInvalid()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            Assert.Null(shelter.Dequeue("parrot"));
        }

        [Fact]
        public void DogFIFO()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            Assert.Equal("Dog", shelter.Dequeue().ToString());
        }

        [Fact]
        public void CatFIFO()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Dog());
            shelter.Enqueue(new Cat());
            shelter.Enqueue(new Dog());
            Assert.Equal("Cat", shelter.Dequeue().ToString());
        }

        [Fact]
        public void NullFIFO()
        {
            AnimalShelter shelter = new AnimalShelter();
            Assert.Null(shelter.Dequeue());
        }
    }
}
