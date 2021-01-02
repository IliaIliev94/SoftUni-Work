using P04_Hospital.Core;
using P04_Hospital.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            IDepartmentRepository departmentRepository = new DepartmentRepository();
            IDoctorRepository doctorRepository = new DoctorRepository();
            Engine engine = new Engine(departmentRepository, doctorRepository);
            engine.Run();
        }
    }
}
