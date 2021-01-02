using System;
using System.Collections.Generic;
using System.Text;

namespace P01._Square_Before
{
    public class Square : Shape
    {
        public override double Area => this.Height * this.Width;
        public double Width
        {
            get { return this.Width; }
            set
            {
                this.Width = value;
                this.Height = value;
            }
        }

        public double Height
        {
            get { return this.Height; }
            set
            {
                this.Height = value;
                this.Width = value;
            }
        }
    }
}
