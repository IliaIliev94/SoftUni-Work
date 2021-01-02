using P04_Hospital.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Repositories
{
    public interface IDepartmentRepository
    {
        List<Department> Departments { get; }
        void Add(Department department, Patient patient);
    }
}
