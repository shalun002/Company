using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Service serv = new Service();
            serv.GenerateEmployee();
            serv.PrintInfo(serv.emp);
            Console.WriteLine();
            serv.Report1(Vacancies.Manager);
        }
    }
}
