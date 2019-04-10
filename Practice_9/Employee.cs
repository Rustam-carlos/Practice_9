using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    public struct Employee
    {
        public string Name { get; set; }
        public Vacancies Vacancy { get; set; }
        public int Salary { get; set; }
        public int[] DateOfBegin { get; set; }

        public Employee(string name, Vacancies vacancy, int salary, int[] date)
        {
            Name = name;
            Vacancy = vacancy;
            Salary = salary;
            DateOfBegin = date;
        }
        public void Show()
        {
            Console.Write($"Name: {Name}" +
                $"\nVacancy: {Vacancy}" +
                $"\nSalary: {Salary}" +
                $"\nDateOfEngagement: ");
            foreach (var i in DateOfBegin)
            {
                Console.Write(i + ".");
            }
        }
    }
