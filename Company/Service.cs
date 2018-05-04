using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;

namespace Company
{
    public struct Service
    {
        
        private Random rand;

        public List<Employees> emp;

        public void GenerateEmployee()
        {
            emp = new List<Employees>();
            rand = new Random();

             Generator genr = new Generator();

            for (int i = 0; i < rand.Next(1, 30); i++)
            {
                Employees employees = new Employees();
                employees.FullName = genr.GenerateDefault((Gender)rand.Next(0, 1));
                employees.StartDate = DateTime.Now.AddMonths((rand.Next(1, 60)) * -1);
                employees.Salary = rand.Next(30000, 100000) / rand.Next(1, 100);
                employees.Position = (Vacancies)rand.Next(0, 3);
                emp.Add(employees);
            }


        }

        public void PrintInfo()
        {
            if (emp!= null)
            {

            }
            foreach (Employees item in emp)
            {
                Console.WriteLine("ФИО: {0}, ({1}) \t {2} {3}",item.FullName, item.StartDate, item.Salary, item.Position);
            }
        }

        public void Report1()
        {

        }
    }
}
