using P04_Hospital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public List<Department> Departments { get; private set; } = new List<Department>();

        public void Add(Department department, Patient patient)
        {
            if (this.Departments.Any(x => x.Name == department.Name))
            {
                Departments.FirstOrDefault(x => x.Name == department.Name).AddPatient(patient);
            }
            else
            {
                department.AddPatient(patient);
                Departments.Add(department);
            }
        }
    }
}
