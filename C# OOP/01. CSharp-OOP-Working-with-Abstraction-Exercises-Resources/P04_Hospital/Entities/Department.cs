using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Entities
{
    public class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Rooms = new List<Room>();
            CreateRooms();
        }
        public string Name { get; private set; }
        public List<Room> Rooms { get; private set; }

        public void AddPatient(Patient Patient)
        {
            for(int i = 0; i < this.Rooms.Count; i++)
            {
                if(this.Rooms[i].People.Count < 3)
                {
                    this.Rooms[i].People.Add(Patient);
                    break;
                }
            }
        }

        private void CreateRooms()
        {
            for(int i = 1; i <= 20; i++)
            {
                this.Rooms.Add(new Room(i));
            }
        }
    }
}
