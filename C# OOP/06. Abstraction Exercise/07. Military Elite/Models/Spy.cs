﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; private set; }

        public Spy(int id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} {Environment.NewLine} Code Number: {this.CodeNumber}";
        }
    }
}
