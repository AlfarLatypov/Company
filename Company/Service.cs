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
        public List<Employes> emp;

        private Random rand;


     public void GenerateEmployes()
        {
            emp = new List<Employes>();
            rand = new Random();
            Generator genr = new Generator();

            for (int i = 0; i < rand.Next(1,100); i++)
            {
                Employes employe = new Employes();
                employe.FullName = genr.GenerateDefault((Gender)rand.Next(0, 2));
                employe.StartDate = DateTime.Now.AddMonths(rand.Next(1, 60)*-1);
                employe.Salary = rand.Next(30000, 100000)/rand.Next(1,100);
                employe.Position = (Vacancies)rand.Next(0, 4);
                emp.Add(employe);
            }

        }


        public void PrintInfo(List<Employes> empl)
        {

            if (empl != null)
            {
                foreach (Employes item in empl)
                {
                    Console.WriteLine("Name: {0} ({1})\t {2} {3} ",item.FullName, item.StartDate, item.Salary, item.Position);


                }
            }
        }


        public void Report1(Vacancies vac)
        {

            double sumSalary = 0;
            int countPossition = 0;


            foreach (Employes item in emp)
            {
                if (item.Position == Vacancies.Clerc)
                {
                    sumSalary += item.Salary;
                        countPossition++;
                }
            }

            sumSalary = sumSalary / countPossition;

            List<Employes> list = new List<Employes>();


            foreach (Employes item in emp)
            {
                if(item.Position == vac && item.Salary > sumSalary)
                {
                    list.Add(item);
                }
            }


            Console.WriteLine("\n\n---------------------------------------------\n{0} Зарплата выше среднего {1}", vac.ToString(), sumSalary, countPossition);

            list = list.OrderBy(o => o.FullName).ToList();
            PrintInfo(list);


        }


        public void Report2()
        {
            Employes boss = new Employes();
            foreach (Employes item in emp)
            {
                if(item.Position == Vacancies.Boss)
                {
                    boss = item;
                    break;
                }

            }

            List<Employes> list2 = new List<Employes>();

            foreach (Employes item in emp)
            {
                if(item.StartDate < boss.StartDate)
                {
                    list2.Add(item);
                }
            }


            Console.WriteLine(" Позже босса принят на работу: {0} ({1})", boss.FullName, boss.StartDate);
            PrintInfo(list2);

        }


    }
}
