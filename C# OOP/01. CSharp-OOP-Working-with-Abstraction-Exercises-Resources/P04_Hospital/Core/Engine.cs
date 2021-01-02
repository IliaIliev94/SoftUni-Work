using P04_Hospital.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using P04_Hospital.Repositories;

namespace P04_Hospital.Core
{
    public class Engine : IEngine
    {
        private IDepartmentRepository departmentRepository;
        private IDoctorRepository doctorRepository;

        public Engine(IDepartmentRepository departmentRepository, IDoctorRepository doctorRepository)
        {
            this.departmentRepository = departmentRepository;
            this.doctorRepository = doctorRepository;
        }
    public void Run()
        {

            string command = Console.ReadLine();
            while(!command.Equals("End"))
            {
                while (!command.Equals("Output"))
                {
                    string[] data = command.Split();
                    Department department = new Department(data[0]);
                    Doctor doctor = new Doctor(data[1], data[2]);
                    Patient patient = new Patient(data[3]);

                    this.departmentRepository.Add(department, patient);
                    this.doctorRepository.Add(doctor, patient);
                    command = Console.ReadLine();
                }
                command = Console.ReadLine();
                string[] printData = command.Split();
                List<Patient> patients = this.GetPatients(printData);
                foreach(var patient in patients)
                {
                    Console.WriteLine(patient.Name);
                }
                command = Console.ReadLine();
            }
            
        }

        private List<Patient> GetPatients(string[] printData)
        {
            List<Patient> result = new List<Patient>();
            if (printData.Length == 2 && printData[1].All(char.IsLetter))
            {
                result = this.doctorRepository.Doctors.FirstOrDefault(doctor => doctor.FirstName == printData[0] && doctor.LastName == printData[1]).Patients.OrderBy(person => person.Name).ToList();
            }
            else
            {
                switch (printData.Length)
                {
                    case 1:
                        this.departmentRepository.Departments.FirstOrDefault(department => department.Name == printData[0]).Rooms.ForEach(room => room.People.ForEach(patient => result.Add(patient)));
                        break;
                    default:
                        result = this.departmentRepository.Departments.FirstOrDefault(department => department.Name == printData[0]).Rooms.FirstOrDefault(room => room.Number == int.Parse(printData[1])).People.OrderBy(person => person.Name).ToList();
                        break;
                }
            }
            return result;
        }
    }
}
