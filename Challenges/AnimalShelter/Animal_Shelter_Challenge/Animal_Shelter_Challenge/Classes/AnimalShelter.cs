using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Shelter_Challenge.Classes
{
    public class AnimalShelter
    {
        public CageQueue Cats { get; set; }
        public CageQueue Dogs { get; set; }
        public int NextSerial { get; set; }

        public AnimalShelter ()
        {
            Cats = new CageQueue();
            Dogs = new CageQueue();
            NextSerial = 1;
        }

        /// <summary>
        ///     Takes in an Animal object, and checks if it is a Cat or Dog. If it is a Cat or Dog, it places it into a new CageNode with the current
        ///      serial number, adds the CageNode to the Cats or Dogs Queue respectively, and iterates the NextSerial number, then returns true.
        ///     If the given Animal isn't a Cat or Dog, does nothing and returns false.
        /// </summary>
        /// <param name="animal"></param>
        /// <returns> Boolean indicating whether given animal was added to the Animal Shelter </returns>
        public bool Enqueue(Animal animal)
        {
            if (animal is Dog)
            {
                CageNode newCage = new CageNode(animal, NextSerial);
                Dogs.Enqueue(newCage);
                NextSerial++;
                return true;
            } else if (animal is Cat)
            {
                CageNode newCage = new CageNode(animal, NextSerial);
                Cats.Enqueue(newCage);
                NextSerial++;
                return true;
            } else
            {
                return false;
            }
        }

        public Animal Dequeue(string pref)
        {

            if (pref.ToLower() == "cat")
            {
                if (Cats.Peek() != null)
                {
                    return Cats.Dequeue().Holds;
                } 
            } else if (pref.ToLower() == "dog")
            {
                if (Dogs.Peek() != null)
                {
                    return Cats.Dequeue().Holds;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Animal Dequeue()
        {
            if (Dogs.Peek() != null && Cats.Peek() != null)
            {
                return Dogs.Peek().Serial > Cats.Peek().Serial ? Dogs.Dequeue().Holds : Cats.Dequeue().Holds;
            } else if (Dogs.Peek() == null && Cats.Peek() == null)
            {
                return null;
            } else if (Dogs.Peek() != null)
            {
                return Dogs.Dequeue().Holds;
            } else
            {
                return Cats.Dequeue().Holds;
            }
        }
    }
}
