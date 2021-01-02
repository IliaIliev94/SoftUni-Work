using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Border_Control
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
