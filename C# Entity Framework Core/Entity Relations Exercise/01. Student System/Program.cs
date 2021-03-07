using P01_StudentSystem.Data;
using System;

namespace Student_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new StudentSystemContext();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }
    }
}
