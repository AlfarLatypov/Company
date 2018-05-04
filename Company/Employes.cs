using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{

    public enum Vacancies { Manager, Boss, Clerc, Salesman}
    public struct  Employes
    {


        /* ?<center><b><font size=7>Лариса
               Бирюкова
        </font></b></center> */

        private string Fullname_ ;

        public string FullName
        {
            get { return Fullname_; }
            set
            {
                Fullname_ = value.Replace("<center><b><font size=7>", "")
                    .Replace("</font></b></center>", "").Replace("\n","");
            }
            }
        public DateTime StartDate { get; set; }
        public double Salary { get; set; }
        
        public Vacancies Position { get; set; }

    }





}
