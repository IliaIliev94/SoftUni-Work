using P04_Hospital.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Repositories
{
    public interface IDoctorRepository
    {
        List<Doctor> Doctors { get; }
        void Add(Doctor department, Patient patient);
    }
}
