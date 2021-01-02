using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parking
    {
        public List<Car> Data { get; set; }
        public string Type { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.Data.Count;
            }
        }
        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.Data = new List<Car>();
        }

        public void Add(Car car)
        {
            if(this.Count < Capacity)
            {
                this.Data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            bool contains = false;
            foreach(var car in this.Data)
            {
                if(car.Manufacturer == manufacturer && car.Model == model)
                {
                    contains = true;
                    this.Data.Remove(car);
                    break;
                }
            }
            return contains;
        }

        public Car GetLatestCar()
        {
            if(this.Data.Count < 1)
            {
                return null;
            }
            Car result = this.Data[0];
            for(int i = 0; i < this.Data.Count; i++)
            {
                if(this.Data[i].Year > result.Year)
                {
                    result = this.Data[i];
                }
            }
            return result;
        }

        public Car GetCar(string manufacturer, string model)
        {

            Car result = null;
            foreach(var car in this.Data)
            {
                if(car.Manufacturer == manufacturer && car.Model == model)
                {
                    result = car;
                    break;
                }
            }
            return result;
        }

        public string GetStatistics()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The cars are parked in {this.Type}:");
            for(int i = 0; i < this.Data.Count; i++)
            {
                if(i == this.Data.Count - 1)
                {
                    result.Append(this.Data[i].ToString());
                }
                else
                {
                    result.AppendLine(this.Data[i].ToString());
                }
            }
            return result.ToString();
        }
    }
}
