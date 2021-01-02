using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Birthday_Celebrations
{
    public class Robot : ICitizen
    {
        public string Model { get; private set; }
        public string Id { get; private set; }


        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public bool EndsWith(string id)
        {
            return this.Id.Substring(this.Id.Length - id.Length, id.Length).Equals(id);
        }
    }
}
