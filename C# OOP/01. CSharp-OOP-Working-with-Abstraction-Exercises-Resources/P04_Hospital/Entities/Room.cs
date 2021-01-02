using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Entities
{
    public class Room
    {
        public Room(int number)
        {
            this.Number = number;
            this.People = new List<Patient>();
        }
        public int Number { get; private set; }
        public List<Patient> People { get; private set; }
    }
}
