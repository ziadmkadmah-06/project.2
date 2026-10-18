using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace project._2
{
    public class Full_Time_Employee : Employee
    {
        public Full_Time_Employee(int id,string name , decimal salary) : base( id, name)
            {
            Id=id;
            Name=name;
            Salary = salary; ; 
            }
        public override decimal CalculateSalary()
        {
            return Salary;
        }
        public override void workable()
        {
            Console.WriteLine($"{Name} is working full-time.");
        }
        public override void Displayinfo() { 

        
            base.Displayinfo();
            Console.WriteLine("Employee Type: Full-Time");
            Console.WriteLine($"Salary: {CalculateSalary()} ");
        }
    }
   

    }
