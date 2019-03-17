using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KLoveHomework.Models;

namespace KLoveHomework.Data
{
    public class DbInitializer
    {
        public static void Initialize(CompanyContext context)
        {
            context.Database.EnsureCreated();

            // Check to see if there are any Employees.
            if (context.Employees.Any())
            {
                return;   // There is already data available.
            }

            /* *******************************************************
             * *******************************************************
             * Please Note all information used in this project was
             * taken by public profiles from LinkedIn. Please let me
             * know if you'd like me to remove this from the code:
             * mau.nicholas@gmail.com
             * -03/17/2019
             * *******************************************************
             * *******************************************************
             */
            var deparments = new Department[]
            {
            new Department{DepartmentName="Information Technology"},
            new Department{DepartmentName="Human Resources"},
            new Department{DepartmentName="Finance"},
            new Department{DepartmentName="Sales"},
            new Department{DepartmentName="Broadcasting"},
            new Department{DepartmentName="Donor Services"},
            new Department{DepartmentName="Facilities"},
            };
            foreach (Department d in deparments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();

            var employees = new Employee[]
            {
            new Employee{FirstMidName="Paul",LastName="Swagerty",StartDate=DateTime.Parse("2007-04-01"), DepartmentID=1},
            new Employee{FirstMidName="Anthony",LastName="Huscher",StartDate=DateTime.Parse("2019-01-01"), DepartmentID=1},
            new Employee{FirstMidName="Matt",LastName="Bauman",StartDate=DateTime.Parse("2018-05-01"), DepartmentID=1},
            new Employee{FirstMidName="David",LastName="Atkinson",StartDate=DateTime.Parse("1998-03-01"), DepartmentID=3},
            new Employee{FirstMidName="Tanya",LastName="Wolf",StartDate=DateTime.Parse("2013-04-01"), DepartmentID=2},
            new Employee{FirstMidName="Stephanie",LastName="Bohannan",StartDate=DateTime.Parse("2006-03-01"), DepartmentID=2},
            new Employee{FirstMidName="Tami",LastName="Tactacan",StartDate=DateTime.Parse("2003-09-01"), DepartmentID=5},
            new Employee{FirstMidName="Kathy",LastName="Johnson",StartDate=DateTime.Parse("2011-11-01"), DepartmentID=6}
            };
            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();
        }
    }
}
