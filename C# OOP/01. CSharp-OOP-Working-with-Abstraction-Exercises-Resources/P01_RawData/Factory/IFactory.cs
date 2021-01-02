using P01_RawData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData.Factory
{
    public interface IFactory
    {
        Car Create(string[] parameters);
    }
}
