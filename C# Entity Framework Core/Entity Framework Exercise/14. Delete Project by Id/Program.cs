using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._Delete_Project_by_Id
{
    class Program
    {
        const int projectIdToDelete = 2;
        static void Main(string[] args)
        {
            SoftUniContext dbContext = new SoftUniContext();
            Console.WriteLine(DeleteProjectById(dbContext));
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();
            

            context.Projects.Remove(RemoveProjectRelationFromEmployeeProjects(context, projectIdToDelete));

            context.SaveChanges();

            List<Project> projects = context.Projects.Take(10).ToList();

            foreach(Project project in projects)
            {
                result.AppendLine(project.Name);
            }

            return result.ToString().TrimEnd();
        }

        public static Project RemoveProjectRelationFromEmployeeProjects(SoftUniContext context, int projectId)
        {
            Project projectWithId2 = context.Projects.SingleOrDefault(pr => pr.ProjectId == projectIdToDelete);

            List<EmployeeProject> employeeProjects = context.EmployeesProjects.Where(ep => ep.ProjectId == projectIdToDelete).ToList();

            foreach (EmployeeProject employeeProject in employeeProjects)
            {
                employeeProject.Project = null;
            }

            context.SaveChanges();

            return projectWithId2;
        }
    }
}
