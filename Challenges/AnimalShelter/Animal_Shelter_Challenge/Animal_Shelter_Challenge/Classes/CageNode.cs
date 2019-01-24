using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Shelter_Challenge.Classes
{
    public class CageNode
    {
        public CageNode Next { get; set; }
        public Animal Holds { get; set; }
        public int Serial { get; set; }

        public CageNode(Animal animal, int serial)
        {
            Holds = animal;
            Serial = serial;
        }
    }

    
}
