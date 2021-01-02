using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public class Mission : IMission
    {
        private string state;
        public string CodeName { get; private set; }
        public string State
        {
            get
            {
                return this.state;
            }
            private set
            {
                if(value != "Finished" && value != "inProgress")
                {
                    throw new ArgumentException();
                }
                this.state = value;
            }
        }

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }

        public void CompleteMission()
        {
            this.State = "Finished";
        }
    }
}
