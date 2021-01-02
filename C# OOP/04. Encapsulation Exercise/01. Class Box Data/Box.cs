using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Class_Box_Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double SurfaceArea { get; private set; }
        public double LateralSurfaceArea { get; private set; }
        public double Volume { get; private set; }
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if(!IsValid(value))
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if(!IsValid(value))
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if(!IsValid(value))
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.Volume = this.Length * this.Width * this.Height;
            this.LateralSurfaceArea = 2 * (this.Length * this.Height) + 2 * (this.Width * this.Height);
            this.SurfaceArea = 2 * (this.Length * this.Height) + 2 * (this.Width * this.Height) + 2 * (this.Length * this.Width);
        }
        private bool IsValid(double side)
        {
            return side > 0;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Surface Area - {this.SurfaceArea:F2}");
            result.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea:F2}");
            result.Append($"Volume - {this.Volume:F2}");
            return result.ToString();
        }
    }
}
