using P04_Hospital.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        public List<Doctor> Doctors { get; private set; } = new List<Doctor>();

        public void Add(Doctor doctor, Patient patient)
        {

            if (this.Doctors.Any(x => x.FirstName == doctor.FirstName && x.LastName == doctor.LastName))
            {
                Doctors.FirstOrDefault(x => x.FirstName == doctor.FirstName && x.LastName == doctor.LastName).AddPatient(patient);
            }
            else
            {
                doctor.AddPatient(patient);
                Doctors.Add(doctor);
            }
        }
    }
}
