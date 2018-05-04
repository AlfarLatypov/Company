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
            Service ser = new Service();
            ser.GenerateEmployes();
            ser.PrintInfo(ser.emp);
            ser.Report1(Vacancies.Manager);
            ser.Report2();

        }
    }
}
